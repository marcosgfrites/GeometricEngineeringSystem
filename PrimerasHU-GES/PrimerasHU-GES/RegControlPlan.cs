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

        /// </summary>
        public int cantidad;
        private SqlDataAdapter ad_actualCP;

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

                string sqlExcel2 = "Select F1,F2,F3,F4,F7,F9,F10,F11,F12,F16,F17,F18 From [" + textBox1.Text + "$A15:V554]";
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

                    nuevoDtgv.Columns[0].HeaderText = "Cod. de punto";
                    nuevoDtgv.Columns[1].HeaderText = "Entidad";
                    nuevoDtgv.Columns[2].HeaderText = "Denominación";
                    nuevoDtgv.Columns[3].HeaderText = "Tipologia";
                    // nuevoDtgv.Columns[4].HeaderText = "Cantidad por";
                    //  nuevoDtgv.Columns[5].HeaderText = "Clase de cierre";
                    // nuevoDtgv.Columns[4].HeaderText = "Clasif.por caracteristica";
                    nuevoDtgv.Columns[4].HeaderText = "Tipo de punto";
                    nuevoDtgv.Columns[5].HeaderText = "X nominal";
                    nuevoDtgv.Columns[6].HeaderText = "Y nominal";
                    nuevoDtgv.Columns[7].HeaderText = "Z nominal";
                    nuevoDtgv.Columns[8].HeaderText = "Nominal";
                    // nuevoDtgv.Columns[12].HeaderText = "CD I";
                    //nuevoDtgv.Columns[13].HeaderText = "CD J";
                    //nuevoDtgv.Columns[14].HeaderText = "CD K";
                    nuevoDtgv.Columns[9].HeaderText = "Unidad de medición";
                    nuevoDtgv.Columns[10].HeaderText = "Tol. limite inferior";
                    nuevoDtgv.Columns[11].HeaderText = "Tol. limite superior";
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

                    btnLimpiar.Enabled = true;


                  /*  foreach (DataGridViewRow fila in nuevoDtgv.Rows)
                    {
                        if (string.IsNullOrEmpty(fila.Cells[5].Value.ToString()))
                        {
                            fila.Cells[5].Value = Convert.ToDouble("0.0000");
                        }
                        if (string.IsNullOrEmpty(fila.Cells[6].Value.ToString()))
                        {
                            fila.Cells[6].Value = Convert.ToDouble("0.0000");
                        }
                        if (string.IsNullOrEmpty(fila.Cells[7].Value.ToString()))
                        {
                            fila.Cells[7].Value = Convert.ToDouble("0.0000");
                        }
                        if (string.IsNullOrEmpty(fila.Cells[8].Value.ToString()))
                        {
                            fila.Cells[8].Value = Convert.ToDouble("0.0000");
                        }
                        if (string.IsNullOrEmpty(fila.Cells[10].Value.ToString()))
                        {
                            fila.Cells[10].Value = Convert.ToDouble("0.0000");
                        }
                        if (string.IsNullOrEmpty(fila.Cells[11].Value.ToString()))
                        {
                            fila.Cells[11].Value = Convert.ToDouble("0.0000");
                        }
                    }*/
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
            bunifuFlatButton1.Enabled = true;
            btnLimpiar.Enabled = true;

            //reordeno el NuevoDTGV por Código de Punto, de manera ascendente para luego poder comparar sin problemas
            nuevoDtgv.Sort(nuevoDtgv.Columns[0], ListSortDirection.Ascending);
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
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@codSeccion", SqlDbType.Int));
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@codCompilador", SqlDbType.Int));
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@codAprobador", SqlDbType.Int));
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@procesoCPlan", SqlDbType.VarChar));
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@numDisenioCPlan", SqlDbType.VarChar));
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@revCPlan", SqlDbType.VarChar));
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@normaRefCPlan", SqlDbType.VarChar));
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@fechModifCPlan", SqlDbType.Date));



            SqlCommand conocerActual = new SqlCommand("SELECT TOP 1 cp.codCPlan,cp.codPrograma,s.descSeccion,cp.numDisenioCPlan,cp.revCPlan,cp.fechModifCPlan FROM controlPlan AS cp JOIN seccionesVehiculo AS s ON s.codSeccion = cp.codSeccion ORDER BY cp.codCPlan DESC", conexion);
            ad_actualCP = new SqlDataAdapter();
            ad_actualCP.SelectCommand = conocerActual;
            DataTable dt_actualCP = new DataTable();
            ad_actualCP.Fill(dt_actualCP);
            if (dt_actualCP.Rows.Count != 0)
            {
                txt_codPrograma_Actual.Text = dt_actualCP.Rows[0][1].ToString();
                txt_seccion_Actual.Text = dt_actualCP.Rows[0][2].ToString();
                txt_numDisenio_Actual.Text = dt_actualCP.Rows[0][3].ToString();
                txt_revision_Actual.Text = dt_actualCP.Rows[0][4].ToString();
                txt_fechaActual_Actual.Text = dt_actualCP.Rows[0][5].ToString();
            }
            else
            {
                txt_codPrograma_Actual.Text = "No hay datos registrados";
                txt_seccion_Actual.Text = "No hay datos registrados";
                txt_numDisenio_Actual.Text = "No hay datos registrados";
                txt_revision_Actual.Text = "No hay datos registrados";
                txt_fechaActual_Actual.Text = "No hay datos registrados";
            }
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
                SqlDataAdapter auxCPlan = new SqlDataAdapter("SELECT codPrograma FROM controlPlan WHERE codPrograma=@codPrograma AND revCPlan=@revCPlan AND numDisenioCPlan=@numDisenioCPlan", conexion);
                DataTable verCPlan = new DataTable();
                auxCPlan.SelectCommand.Parameters.Add(new SqlParameter("@codPrograma", SqlDbType.VarChar));
                auxCPlan.SelectCommand.Parameters["@codPrograma"].Value = codigoProTxt.Text;
                auxCPlan.SelectCommand.Parameters.Add(new SqlParameter("@revCPlan", SqlDbType.VarChar));
                auxCPlan.SelectCommand.Parameters["@revCPlan"].Value = revisionText.Text;
                auxCPlan.SelectCommand.Parameters.Add(new SqlParameter("@numDisenioCPlan", SqlDbType.VarChar));
                auxCPlan.SelectCommand.Parameters["@numDisenioCPlan"].Value = numDisTxt.Text;
                auxCPlan.Fill(verCPlan);
                if (verCPlan.Rows.Count > 0) //si la condicion se cumple, el código ingresado ya se encuentra registrado
                {
                    DialogResult duda = MessageBox.Show("El 'código' ingresado ya existe. Si necesita continuar con el registro presione ACEPTAR, sino CANCELAR.", "Atención!", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                    if (duda == DialogResult.OK)
                    {
                        regDetCPbtn.Enabled = true;
                        registrarBtn.Enabled = false;
                        bunifuFlatButton1.Enabled = false;
                    }
                    else
                    {
                        return;
                    }
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
            codigoProTxt.BackColor = Color.WhiteSmoke;
            descSeccionTxt.Text = "";
            descSeccionTxt.BackColor = Color.WhiteSmoke;
            numDisTxt.Text = "";
            numDisTxt.BackColor = Color.WhiteSmoke;
            revisionText.Text = "";
            revisionText.BackColor = Color.WhiteSmoke;

            //DataTable dt = (DataTable)nuevoDtgv.DataSource;
            //dt.Clear();
            if (nuevoDtgv.Rows.Count != 0)
            {
                nuevoDtgv.DataSource = null;
                nuevoDtgv.Rows.Clear();
                nuevoDtgv.Refresh();
            }

            registrarBtn.Enabled = false;
            regDetCPbtn.Enabled = false;
            bunifuFlatButton1.Enabled = false;
            btnLimpiar.Enabled = false;
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

                    SqlCommand ultCPlan = new SqlCommand("SELECT TOP 1 codCPlan FROM controlPlan ORDER BY codCPlan DESC", conexion);
                    adaptador = new SqlDataAdapter();
                    adaptador.SelectCommand = ultCPlan;
                    DataTable dtUltCPlan = new DataTable();
                    adaptador.Fill(dtUltCPlan);
                    int codUltCPlan = 1;
                    if (dtUltCPlan.Rows.Count != 0)
                    {
                        codUltCPlan = Convert.ToInt32(dtUltCPlan.Rows[0][0].ToString());
                    }

                    detallar.Parameters.AddWithValue("@codCPlan", codUltCPlan);
                    //detallar.Parameters.AddWithValue("@codCPlan", Convert.ToInt32(row.Cells["F5"].Value));
                    detallar.Parameters.AddWithValue("@idPtoMed", Convert.ToString(row.Cells["F1"].Value));
                    detallar.Parameters.AddWithValue("@clasiTipoPto", row.Cells["F7"].Value == DBNull.Value ? "-" : Convert.ToString(row.Cells["F7"].Value));
                    detallar.Parameters.AddWithValue("@codUnidMed", Convert.ToString(row.Cells["F16"].Value));
                    detallar.Parameters.AddWithValue("@codTipoControl", Convert.ToString(row.Cells["F4"].Value));
                    detallar.Parameters.AddWithValue("@codEntidad", Convert.ToString(row.Cells["F2"].Value));
                    //carga de texto de la descripcion llamada denominacion (se agrego en base de datos como varchar max)
                    detallar.Parameters.AddWithValue("@denominacion", row.Cells["F3"].Value == DBNull.Value ? " " : Convert.ToString(row.Cells["F3"].Value));

                    string cadena = Convert.ToString(row.Cells["F1"].Value);
                    char[] aux = cadena.ToCharArray();
                    string letra = "";

                    for (int i = 0; i <= aux.Length - 1; i++)
                    {
                        letra = aux[i].ToString();
                    }
                    if (letra == "X")
                    {
                        detallar.Parameters.AddWithValue("@direcPtoMed", letra);
                    }
                    else
                    {
                        if (letra == "Y")
                        {

                            detallar.Parameters.AddWithValue("@direcPtoMed", letra);
                        }
                        else
                        {
                            if (letra == "Z")
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
                    //detallar.Parameters.AddWithValue("@nominalPtoMed",row.Cells["F12"]);

                    if (row.Cells["F12"].Value == null)
                    {
                        detallar.Parameters.AddWithValue("@nominalPtoMed", DBNull.Value);
                    }
                    else
                    {
                        //detallar.Parameters.AddWithValue("@nominalPtoMed", Convert.ToDecimal(row.Cells["F12"].Value));
                        detallar.Parameters.AddWithValue("@nominalPtoMed", (row.Cells["F12"].Value));
                    }
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

            registrarBtn.Enabled = false;
            bunifuFlatButton1.Enabled = false;
            regDetCPbtn.Enabled = false;
            btnLimpiar.Enabled = false;
            limpiar();

        }

        private void NuevoDtgv_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush b = new SolidBrush(nuevoDtgv.RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString((e.RowIndex).ToString(), e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 3, e.RowBounds.Location.Y + 2);
            }
        }



        private void actualizarBtn_Click(object sender, EventArgs e)
        {
           // DataTable src1 = actualDTGV.DataSource as DataTable;
            DataTable dt = (DataTable)nuevoDtgv.DataSource;

            DataTable src2 = (DataTable)actualDTGV.DataSource ;


           
         // int index1 = 0;
            
            for (int i = 0; i < dt.Rows.Count; i++)

            {
                var row1 = dt.Rows[i].ItemArray;
                var row2 = src2.Rows[i].ItemArray;

                for (int j = 0; j < row1.Length; j++)
                {
                    if (!row1[j].ToString().Equals(row2[j].ToString()))
                    {
                        nuevoDtgv.Rows[i].Cells[j].Style.BackColor = Color.Red;

                        actualDTGV.Rows[i].Cells[j].Style.BackColor = Color.Red;

                    }

                }

            }
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            int f = 0;
            int c = 0;
            if (nuevoDtgv.Rows.Count != 0)
            {

                for (f = 0; f < actualDTGV.RowCount; f++)
                {
                    for (c = 0; c < actualDTGV.ColumnCount; c++)
                    {

                        string cell1 = Convert.ToString(actualDTGV.Rows[f].Cells[c].Value);
                        string cell2 = Convert.ToString(nuevoDtgv.Rows[f].Cells[c].Value);

                        if (cell1 != cell2)
                        {
                            //  MOSTRAR EN PANTALLA LA DIFERENCIA, SI HAY, DE LOS DOS ARCHIVOS
                            nuevoDtgv.Rows[f].Cells[c].Style.BackColor = Color.OrangeRed;
                        }
                        else
                        {
                            nuevoDtgv.Rows[f].Cells[c].Style.BackColor = Color.LightGreen;
                        }

                    }
                }

                if (codigoProTxt.Text == txt_codPrograma_Actual.Text)
                {
                    codigoProTxt.BackColor = Color.LightGreen;
                }
                else
                {
                    codigoProTxt.BackColor = Color.OrangeRed;
                }

                if (descSeccionTxt.Text == txt_seccion_Actual.Text)
                {
                    descSeccionTxt.BackColor = Color.LightGreen;
                }
                else
                {
                    descSeccionTxt.BackColor = Color.OrangeRed;
                }

                if (numDisTxt.Text == txt_numDisenio_Actual.Text)
                {
                    numDisTxt.BackColor = Color.LightGreen;
                }
                else
                {
                    numDisTxt.BackColor = Color.OrangeRed;
                }

                if (revisionText.Text == txt_revision_Actual.Text)
                {
                    revisionText.BackColor = Color.LightGreen;
                }
                else
                {
                    revisionText.BackColor = Color.OrangeRed;
                }

                if (DtFecha.ToString() == txt_fechaActual_Actual.Text)
                {
                    DtFecha.BackColor = Color.LightGreen;
                }
                else
                {
                    DtFecha.BackColor = Color.OrangeRed;
                }
            }
        }

        private void btnLimpiar_Click_1(object sender, EventArgs e)
        {
            limpiar();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.WindowState = FormWindowState.Minimized;

        }

        private void btn_Salir_Click_1(object sender, EventArgs e)
        {
            this.Dispose();

        }
    }      
}    
   



