using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using System.Globalization;

namespace PrimerasHU_GES
{
    public partial class RegControlPlan : Form
    {
        public RegControlPlan()
        {
            InitializeComponent();
        }
        /// <summary>
        /// prueba
        /// </summary>
        public int cantidad;

        private void BunifuFlatButton2_Click(object sender, EventArgs e)
        {
            string ruta = string.Empty;
            OpenFileDialog fDialog = new OpenFileDialog();
            fDialog.Title = "Open Image Files";
            //fDialog.Filter = "JPEG Files|*.jpeg|GIF Files|*.gif";
            //fDialog.Filter = "Excel Files|*.xls";
            fDialog.Filter = "Excel Files|*.*";
            fDialog.InitialDirectory = @"C:\Users\Roqué\Documents\GitHub\Tesis\PrimerasHU-GES\PrimerasHU-GES\Documento control plan";//Directorio inical donde se busca el archivo
        
            if (fDialog.ShowDialog() == DialogResult.OK)
            {
                ruta = fDialog.FileName.ToString();
                string strConnnectionOle = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + ruta + ";Extended Properties='Excel 12.0 Xml;HDR=NO;';";

                //Ejemplo @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + path + ";Extended Properties='Excel 8.0;HDR=YES;IMEX=1;';";
                string sqlExcel = "Select * From [" + textBox1.Text + "$C3:X9]";
                DataTable DS = new DataTable();
                OleDbConnection oledbConn = new OleDbConnection(strConnnectionOle);

                string sqlExcel2 = "Select F1,F2,F3,F4,F5,F7,F9,F10,F11,F12,F16,F17,F18 From [" + textBox1.Text + "$A15:V554]";
                DataTable DS2 = new DataTable();

                try
                {
                    oledbConn.Open();
                    OleDbCommand oledbCmd = new OleDbCommand(sqlExcel, oledbConn);
                    OleDbDataAdapter da = new OleDbDataAdapter(oledbCmd);
                    OleDbCommand oledbCmd2 = new OleDbCommand(sqlExcel2, oledbConn);
                    OleDbDataAdapter da1 = new OleDbDataAdapter(oledbCmd2);

                    da.Fill(DS);
                    cabeceraDtg.DataSource = DS;

                    da1.Fill(DS2);
                    nuevoDtgv.DataSource = DS2;
                    
                    nuevoDtgv.AutoGenerateColumns = false;
                  
                    nuevoDtgv.Columns[0].HeaderText = "Cod.de punto";
                    nuevoDtgv.Columns[1].HeaderText = "Entidad";
                    nuevoDtgv.Columns[2].HeaderText = "Denominación";
                    nuevoDtgv.Columns[3].HeaderText = "Tipologia";
                   // nuevoDtgv.Columns[4].HeaderText = "Cantidad por";
                  //  nuevoDtgv.Columns[5].HeaderText = "Clase de cierre";
                   // nuevoDtgv.Columns[4].HeaderText = "Clasif.por caracteristica";
                    nuevoDtgv.Columns[4].HeaderText = "Tipo de punto";
                    nuevoDtgv.Columns[5].HeaderText = "X nominal";
                    nuevoDtgv.Columns[6].HeaderText = "Y nominal";
                    nuevoDtgv.Columns[7].HeaderText ="Z nominal";
                    nuevoDtgv.Columns[8].HeaderText = "Nominal";
                   // nuevoDtgv.Columns[12].HeaderText = "CD I";
                    //nuevoDtgv.Columns[13].HeaderText = "CD J";
                    //nuevoDtgv.Columns[14].HeaderText = "CD K";
                    nuevoDtgv.Columns[9].HeaderText = "Unidad de medición";
                    nuevoDtgv.Columns[10].HeaderText = "Tol. Limite Inferior";
                    nuevoDtgv.Columns[11].HeaderText = "Tol. Limite Superior";
                    //nuevoDtgv.Columns[18].HeaderText = "Medio de control";
                    //nuevoDtgv.Columns[19].HeaderText = "Frecuencia de control";
                    //nuevoDtgv.Columns[20].HeaderText = "Modo de registro";
                   // nuevoDtgv.Columns[21].HeaderText = "Grupo";

                    string nombreArchivo = Path.GetFileNameWithoutExtension(ruta);
                    
                    codigoProTxt.Text = cabeceraDtg.Rows[3].Cells["F16"].Value.ToString();
                    descSeccionTxt.Text = cabeceraDtg.Rows[3].Cells["F2"].Value.ToString();
                    numDisTxt.Text = cabeceraDtg.Rows[5].Cells["F2"].Value.ToString();

                    revisionText.Text = nombreArchivo;
                    DtFecha.Value = DateTime.Parse(cabeceraDtg.Rows[4].Cells["F22"].Value.ToString());
                    // tome valores del datagrid para completar la info para el registro

                    registrarBtn.Enabled = true;

                    limpiarTxt.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            else
            {
                // cancelo 
            }
            registrarBtn.Enabled = true;

        }

        //Colocar Numeros a las filas del DatagridView
         private void ActualDtgv_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
          {
            
    }

    //registro de control plan
    private SqlConnection conexion;
        private SqlDataAdapter adaptador;
       
        private void RegControlPlan_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'ges_v01DataSet17.detallesControlPlan' Puede moverla o quitarla según sea necesario.
            this.detallesControlPlanTableAdapter1.Fill(this.ges_v01DataSet17.detallesControlPlan);
            // TODO: esta línea de código carga datos en la tabla 'ges_v01DataSet12.detallesControlPlan' Puede moverla o quitarla según sea necesario.
            this.detallesControlPlanTableAdapter.Fill(this.ges_v01DataSet12.detallesControlPlan);
            conexion = new SqlConnection("Data source=.\\SQLEXPRESS;Initial Catalog=ges_v01;Integrated Security=True");
            adaptador = new SqlDataAdapter();
            
            SqlCommand alta = new SqlCommand("INSERT INTO controlPlan values (@codPrograma,@codSeccion,@codCompilador,@codAprobador,@procesoCPlan,@numDisenioCPlan,@revCPlan,@normaRefCPlan,@fechModifCPlan)", conexion);
            adaptador.InsertCommand = alta;
           
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@codPrograma", SqlDbType.VarChar));
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@codSeccion",SqlDbType.Int));
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@codCompilador", SqlDbType.Int));
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@codAprobador", SqlDbType.Int));
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@procesoCPlan", SqlDbType.VarChar));
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@numDisenioCPlan", SqlDbType.VarChar));
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@revCPlan", SqlDbType.VarChar));
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@normaRefCPlan", SqlDbType.VarChar));
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@fechModifCPlan", SqlDbType.Date));


            




        }


        private void RegistrarBtn_Click(object sender, EventArgs e)
            
        {
            //inicio de registrar control plan

            adaptador.InsertCommand.Parameters["@codPrograma"].Value = (cabeceraDtg.Rows[3].Cells["F16"].Value.ToString());
            adaptador.InsertCommand.Parameters["@codSeccion"].Value = int.Parse(cabeceraDtg.Rows[4].Cells["F12"].Value.ToString());
            adaptador.InsertCommand.Parameters["@codCompilador"].Value = int.Parse(cabeceraDtg.Rows[4].Cells["F12"].Value.ToString());
            adaptador.InsertCommand.Parameters["@codAprobador"].Value = int.Parse(cabeceraDtg.Rows[5].Cells["F12"].Value.ToString());
            adaptador.InsertCommand.Parameters["@procesoCPlan"].Value = (cabeceraDtg.Rows[4].Cells["F2"].Value.ToString());
            adaptador.InsertCommand.Parameters["@numDisenioCPlan"].Value = (cabeceraDtg.Rows[5].Cells["F2"].Value.ToString());
            adaptador.InsertCommand.Parameters["@revCPlan"].Value = revisionText.Text;
            adaptador.InsertCommand.Parameters["@normaRefCPlan"].Value = (cabeceraDtg.Rows[6].Cells["F2"].Value.ToString());
            adaptador.InsertCommand.Parameters["@fechModifCPlan"].Value = DtFecha.Value;
           

            try
            {
                conexion.Open();

                // en las proximas lineas realiza una consulta para ver si el código utilizado ya existe
                SqlDataAdapter auxCPlan = new SqlDataAdapter("SELECT codPrograma FROM controlPlan WHERE codPrograma=@codPrograma", conexion);
                DataTable verCPlan = new DataTable();
                auxCPlan.SelectCommand.Parameters.Add(new SqlParameter("@codPrograma", SqlDbType.VarChar));
                auxCPlan.SelectCommand.Parameters["@codPrograma"].Value = codigoProTxt.Text;
                auxCPlan.Fill(verCPlan);
                if (verCPlan.Rows.Count > 0) //si la condicion se cumple, el código ingresado ya se encuentra registrado
                {
                    MessageBox.Show("El 'código' ingresado ya existe.", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    regDetCPbtn.Enabled = true;
                }
                else
                {
                    adaptador.InsertCommand.ExecuteNonQuery();
                    MessageBox.Show("Se ha registrado correctamente el 'Control Plan' ", "Operación Exitosa!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    regDetCPbtn.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR:" + ex.ToString());
            }
            finally
            {
                conexion.Close();
                
            }



        }


        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void limpiar()
        {
            codigoProTxt.Text = "";
            descSeccionTxt.Text = "";
            numDisTxt.Text = "";
            revisionText.Text = "";
           
            DataTable dt = (DataTable)nuevoDtgv.DataSource;
            dt.Clear();

            registrarBtn.Enabled = false;
            regDetCPbtn.Enabled = false;

        }


        private void LimpiarTxt_Click(object sender, EventArgs e)
        {
            limpiar();
        }
        //cargar lo siguiente para el movimiento del panel 
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void Panel2_MouseMove(object sender, MouseEventArgs e)//setear en las propiedades/acciones en el evento mouse move hacer doble click y genera este metodo
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void RegDetCPbtn_Click(object sender, EventArgs e)
        {
          
            SqlCommand detallar = new SqlCommand("INSERT INTO detallesControlPlan (codCPlan,idPtoMed,clasiTipoPto,codUnidMed,codTipoControl,codEntidad,denominacion,direcPtoMed,coordXPtoMed,coordYPtoMed,coordZPtoMed,nominalPtoMed,tolinferior,tolSuperior) values (@codCPlan,@idPtoMed,@clasiTipoPto,@codUnidMed,@codTipoControl,@codEntidad,@denominacion,@direcPtoMed,@coordXPtoMed,@coordYPtoMed,@coordZPtoMed,@nominalPtoMed,@tolinferior,@tolSuperior)", conexion);
            conexion.Open();

            try
            {
                foreach (DataGridViewRow row in nuevoDtgv.Rows)
                {
                    detallar.Parameters.Clear();

                    detallar.Parameters.AddWithValue("@codCPlan", Convert.ToInt32(row.Cells["F5"].Value));
                    detallar.Parameters.AddWithValue("@idPtoMed", Convert.ToString(row.Cells["F1"].Value));
                    detallar.Parameters.AddWithValue("@clasiTipoPto", row.Cells["F7"].Value == DBNull.Value ? "-" : Convert.ToString(row.Cells["F7"].Value));
                    detallar.Parameters.AddWithValue("@codUnidMed", Convert.ToString(row.Cells["F16"].Value));
                    detallar.Parameters.AddWithValue("@codTipoControl", Convert.ToString(row.Cells["F4"].Value));
                    detallar.Parameters.AddWithValue("@codEntidad", Convert.ToString(row.Cells["F2"].Value));
                    //carga de texto de la descripcion llamada denominacion (se agrego en base de datos como varchar max)
                    detallar.Parameters.AddWithValue("@denominacion",row.Cells["F3"].Value == DBNull.Value ? " " : Convert.ToString(row.Cells["F3"].Value));

                    string cadena = Convert.ToString(row.Cells["F1"].Value);
                    char[] aux = cadena.ToCharArray();
                    string letra = "";

                    for(int i = 0; i <= aux.Length-1;i++)
                    {
                        letra = aux[i].ToString();
                    }                  
                    if (letra == "X")
                    {                      
                        detallar.Parameters.AddWithValue("@direcPtoMed", letra);
                    }
                    else
                    {
                        if (letra =="Y")
                        {
                           
                            detallar.Parameters.AddWithValue("@direcPtoMed", letra);
                        }
                        else
                        {
                            if (letra=="Z")
                            {
                                detallar.Parameters.AddWithValue("@direcPtoMed", letra);
                            }
                            else
                            {
                                if (letra == "D")
                                {
                                    string letra2 = aux[aux.Length - 2].ToString();
                                    detallar.Parameters.AddWithValue("@direcPtoMed", letra2);
                                }
                                else
                                {
                                    detallar.Parameters.AddWithValue("@direcPtoMed", letra);
                                }
                            }
                        }
                        
                    }

                    detallar.Parameters.AddWithValue("@coordXPtoMed", row.Cells["F9"].Value == DBNull.Value ? 0 : Convert.ToDecimal(row.Cells["F9"].Value));
                    detallar.Parameters.AddWithValue("@coordYPtoMed", row.Cells["F10"].Value == DBNull.Value ? 0 : Convert.ToDecimal(row.Cells["F10"].Value));
                    detallar.Parameters.AddWithValue("@coordZPtoMed", row.Cells["F11"].Value == DBNull.Value ? 0 : Convert.ToDecimal(row.Cells["F11"].Value));
                    detallar.Parameters.AddWithValue("@nominalPtoMed", row.Cells["F12"].Value == DBNull.Value ? 0 : Convert.ToDecimal(row.Cells["F12"].Value));

                    //detallar.Parameters.AddWithValue("@tolinferior", row.Cells["F17"].Value == DBNull.Value ? 0 : Convert.ToDecimal(row.Cells["F17"].Value));
                    //detallar.Parameters.AddWithValue("@tolinferior", row.Cells["F18"].Value == DBNull.Value ? 0 : Convert.ToDecimal(row.Cells["F17"].Value));

                    // CultureInfo culture = new CultureInfo("en-US"); // nos deja manejar "puntos" para separar decimales, en lugar de "comas"

                    detallar.Parameters.AddWithValue("@tolinferior", string.IsNullOrWhiteSpace(row.Cells["F17"].Value.ToString()) == true ? 0 : decimal.Parse(row.Cells["F17"].Value.ToString())); //decimal.Parse("usar un string","objeto de CultureInfo")
                    detallar.Parameters.AddWithValue("@tolSuperior", string.IsNullOrWhiteSpace(row.Cells["F18"].Value.ToString()) == true ? 0 : decimal.Parse(row.Cells["F18"].Value.ToString())); //se puede usar string.IsNullOrWhiteSpace("string") o string.IsNullOrEmpty("string")

                    detallar.ExecuteNonQuery();
                }

                MessageBox.Show("Detalle de Control Plan agregado correctamente");
            }
            catch (SqlException excepcion)
            {
                MessageBox.Show(excepcion.ToString());
            }
            finally
            {
                conexion.Close();
            }

        }

        private void NuevoDtgv_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush b = new SolidBrush(nuevoDtgv.RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString((e.RowIndex).ToString(), e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 3, e.RowBounds.Location.Y + 2);
            }
        }
    }


}
