using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.InteropServices;

namespace PrimerasHU_GES
{
    public partial class MuestraMarcos : Form
    {
        public MuestraMarcos()
        {
            InitializeComponent();
        }

        private SqlConnection Conexion;
        private SqlDataAdapter adaptador;
        private SqlDataAdapter ad_ultDmo;
        private SqlDataAdapter ad_ultMuestra;
        private SqlDataAdapter ad_detMuestra;
        private SqlDataAdapter ad_muestras;


        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void recuperaUltimaMuestra()
        {
            //HAY QUE TENER EN CUENTA QUE EL CÓDIGO DE MUESTRA ES AUTOINCREMENTABLE, NO LO VAMOS A ASIGNAR NOSOTROS
            //RECUPERO EL ÚLTIMO CÓDIGO DE MUESTRA UTILIZADO Y MUESTRO EL CODIGO NUEVO QUE INGRESARA. EN CASO DE LA TABLA ESTAR VACIA SE LE ASIGNA EL PRIMERO
            SqlCommand ultMuestra = new SqlCommand("SELECT TOP 1 codMuestra FROM muestras ORDER BY codMuestra DESC", Conexion);
            ad_ultMuestra = new SqlDataAdapter(ultMuestra);
            DataTable dt_ultMuestra = new DataTable();
            ad_ultMuestra.Fill(dt_ultMuestra);
            if (dt_ultMuestra.Rows.Count == 0)
            {
                txt_codMuestra.Text = "1";
            }
            else
            {
                string aux_codNvo = dt_ultMuestra.Rows[0][0].ToString();
                int codNvo = 0;
                codNvo = Convert.ToInt32(aux_codNvo);
                codNvo++;
                txt_codMuestra.Text = codNvo.ToString(); //PRUEBA DE PUSH/PULL EN GITHUB >> ALGO ESTÁ FALLANDO
            }
        }

        private void recuperaUltimoDmoUsado()
        {
            //RECUPERO EL CÓDIGO DEL ÚLTIMO DMO UTILIZADO EN MUESTRAS
            SqlCommand ultDmo = new SqlCommand("SELECT TOP 1 codDmo FROM detalleMuestras ORDER BY codDmo DESC", Conexion);
            ad_ultDmo = new SqlDataAdapter(ultDmo);
            DataTable dt_ultDmo = new DataTable();
            ad_ultDmo.Fill(dt_ultDmo);
            if (dt_ultDmo.Rows.Count == 0)
            {
                txt_ultDmo.Text = "N/A";
            }
            else
            {
                txt_ultDmo.Text = dt_ultDmo.Rows[0][0].ToString();
            }
        }

        private void recuperarMuestras()
        {
            //RECUPERO EL LISTADO DE MUESTRAS VIGENTES
            SqlCommand listaMuestras = new SqlCommand("SELECT m.codMuestra AS 'Cód. Muestra',m.fechaMuestra AS 'Fecha Muestra',dm.codDmo AS 'Doc. DMO',(SELECT COUNT(ddd.idPtoMed) FROM detallesDocumentoDmo AS ddd WHERE ddd.idPtoMed IN(SELECT idPtoMed FROM detallesControlPlan WHERE clasiTipoPto = 'F') AND ddd.codDmo = dm.codDmo) AS 'Cant. Puntos (Semáforo)' FROM muestras AS m, detalleMuestras AS dm WHERE m.codMuestra = dm.codMuestra ORDER BY m.codMuestra ASC, dm.codDmo ASC",Conexion);
            ad_muestras = new SqlDataAdapter(listaMuestras);
            DataTable dt_listaMuestras = new DataTable();
            ad_muestras.Fill(dt_listaMuestras);
            dgv_muestras.DataSource = dt_listaMuestras;
        }

        private void MuestraMarcos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'ges_v01DataSetCodigosDmo.documentosDmo' Puede moverla o quitarla según sea necesario.
            this.documentosDmoTableAdapter.Fill(this.ges_v01DataSetCodigosDmo.documentosDmo);
            Conexion = new SqlConnection("Data source=.\\SQLEXPRESS; Initial Catalog = ges_v01; Integrated Security = True");
            adaptador = new SqlDataAdapter();

            recuperaUltimaMuestra();
            recuperaUltimoDmoUsado();
            recuperarMuestras();
        }
        
        //EN EL SIGUIENTE EVENTO KEYPRESS DE LA CANTIDAD DE DMO, VALIDO QUE SÓLO SE INGRESEN NÚMEROS
        private void Txt_cantidadDmo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Sólo se permite el ingreso de números.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void Btn_limpiarMuestra_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void limpiar()
        {
            recuperarMuestras();
            recuperaUltimaMuestra();
            recuperaUltimoDmoUsado();
            txt_cantidadDmo.Text = "";
            txt_obserMuestra.Text = "";
            dgv_docDmo.DataSource = null;
            dgv_docDmo.Rows.Clear();
            dgv_docDmo.Refresh();
            btn_registrar.Enabled = false;
            txt_cantEncontrada.Text = "";
            txt_cantSolicitada.Text = "";
        }

        private void Btn_previsual_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_cantidadDmo.Text))
            {
                MessageBox.Show("Revise la cantidad de DMO que quiere que contenga la muestra.", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                btn_registrar.Enabled = false;
            }
            else
            {
                int cantidad = Convert.ToInt32(txt_cantidadDmo.Text);
                if (cantidad < 8 || cantidad > 30)
                {
                    MessageBox.Show("Revise la cantidad de DMO que quiere que contenga la muestra. " + "\n" + "Recuerde que el valor mínimo permitido es 8 y el máximo es 30.", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    txt_cantSolicitada.Text = txt_cantidadDmo.Text;
                    string consultaUltDmo = "";
                    int cantDmo = int.Parse(txt_cantidadDmo.Text); //recupero la cantidad de dmo que va a contenerla muestra
                    string ultimoDmoUsado = "";
                    btn_registrar.Enabled = true;
                    int cantEncontrada = 0;

                    if (txt_ultDmo.Text == "N/A" || String.IsNullOrEmpty(txt_ultDmo.Text))
                    {
                        consultaUltDmo = "SELECT TOP " + cantDmo + " codDmo AS 'Documentos DMO (no utilizados)' FROM documentosDmo";

                        SqlCommand cmd_dgvDmo = new SqlCommand(consultaUltDmo, Conexion);
                        SqlDataAdapter ad_dgvDmo = new SqlDataAdapter(cmd_dgvDmo);
                        DataTable dt_dgvDmo = new DataTable();
                        ad_dgvDmo.Fill(dt_dgvDmo);
                        dgv_docDmo.DataSource = dt_dgvDmo;
                        cantEncontrada = dt_dgvDmo.Rows.Count;
                    }
                    else
                    {
                        consultaUltDmo = "SELECT TOP " + cantDmo + " codDmo AS 'Documentos DMO (no utilizados)' FROM documentosDmo WHERE codDmo >'" + txt_ultDmo.Text + "'";

                        SqlCommand cmd_dgvDmo = new SqlCommand(consultaUltDmo, Conexion);
                        SqlDataAdapter ad_dgvDmo = new SqlDataAdapter(cmd_dgvDmo);
                        DataTable dt_dgvDmo = new DataTable();
                        ad_dgvDmo.Fill(dt_dgvDmo);
                        dgv_docDmo.DataSource = dt_dgvDmo;
                        cantEncontrada = dt_dgvDmo.Rows.Count;
                    }
                    txt_cantEncontrada.Text = cantEncontrada.ToString();
                    if (cantEncontrada == 0)
                    {
                        MessageBox.Show("No se han encontrado Documentos DMO nuevos para registrar en las muestras. Póngase en contacto con el Administrador/Encargado.", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        limpiar();
                    }
                }
            }
        }

        private void Btn_registrar_Click(object sender, EventArgs e)
        {

                string mensaje = "Se ha registrado correctamente: " + "\n";
                if (txt_cantSolicitada.Text != txt_cantEncontrada.Text)
                {
                    DialogResult registrar = MessageBox.Show("Ud. desea registrar una muestra de " + txt_cantSolicitada.Text + " DMO, pero en el sistema, sin utilizar sólo se encontraron " + txt_cantEncontrada.Text + ". \n \n - Presione 'SI' si desea que el sistema corrija los datos automáticamente para evitar errores y registre de igual manera. \n \n - Presione 'NO' para abrir el gestor de 'Documentos DMO' y registrar los faltantes. \n \n - Presione 'CANCELAR' para revisar si los datos fueron ingresados correctamente o corregirlos.", "Atención!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                    if (registrar == DialogResult.Yes)
                    {
                        txt_cantidadDmo.Text = txt_cantEncontrada.Text;
                        txt_cantSolicitada.Text = txt_cantidadDmo.Text;

                        //INSERCION DE MUESTRAS
                        SqlCommand altaMuestra = new SqlCommand("INSERT INTO muestras VALUES (@fechaMuestra,@obserMuestra,@cantidadDmo)", Conexion);
                        adaptador.InsertCommand = altaMuestra;
                        adaptador.InsertCommand.Parameters.Add(new SqlParameter("@fechaMuestra", SqlDbType.Date));
                        adaptador.InsertCommand.Parameters.Add(new SqlParameter("@obserMuestra", SqlDbType.Text));
                        adaptador.InsertCommand.Parameters.Add(new SqlParameter("@cantidadDmo", SqlDbType.Int));

                        adaptador.InsertCommand.Parameters["@fechaMuestra"].Value = dtp_fechaMuestra.Value.ToString("yyyy-MM-dd");
                        string aux_obser = null;
                        if (txt_obserMuestra.Text != null)
                        {
                            aux_obser = txt_obserMuestra.Text;
                        }
                        adaptador.InsertCommand.Parameters["@obserMuestra"].Value = aux_obser;
                        adaptador.InsertCommand.Parameters["@cantidadDmo"].Value = int.Parse(txt_cantidadDmo.Text);

                        try
                        {
                            Conexion.Open();
                            adaptador.InsertCommand.ExecuteNonQuery();
                            mensaje += "- Muestras" + "\n";

                            //INSERCION DE DETALLE DE MUESTRAS
                            try
                            {
                                ad_detMuestra = new SqlDataAdapter();
                                SqlCommand altaDetalleMuestra = new SqlCommand("INSERT INTO detalleMuestras (codMuestra,codDmo) VALUES (@codMuestra,@codDmo)", Conexion);
                                ad_detMuestra.InsertCommand = altaDetalleMuestra;

                                foreach (DataGridViewRow fila_docDmo in dgv_docDmo.Rows)
                                {
                                    ad_detMuestra.InsertCommand.Parameters.Clear();

                                    ad_detMuestra.InsertCommand.Parameters.Add(new SqlParameter("@codMuestra", SqlDbType.Int));
                                    ad_detMuestra.InsertCommand.Parameters.Add(new SqlParameter("@codDmo", SqlDbType.VarChar));

                                    ad_detMuestra.InsertCommand.Parameters["@codMuestra"].Value = Convert.ToInt32(txt_codMuestra.Text);
                                    ad_detMuestra.InsertCommand.Parameters["@codDmo"].Value = fila_docDmo.Cells[0].Value;

                                    ad_detMuestra.InsertCommand.ExecuteNonQuery();

                                }
                                mensaje += "- Detalles de Muestra";
                                MessageBox.Show(mensaje, "Felicitaciones!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                limpiar();
                            }
                            catch (Exception ex2)
                            {
                                MessageBox.Show(ex2.ToString());
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString());
                        }
                        finally
                        {
                            Conexion.Close();
                        }

                    }
                    else
                    {
                        if (registrar == DialogResult.No)
                        {
                            MarcosDmo md = new MarcosDmo();
                            md.Show();
                        }
                        else
                        {
                            return;
                        }
                    }
                }
                else
                {
                    //INSERCION DE MUESTRAS
                    SqlCommand altaMuestra = new SqlCommand("INSERT INTO muestras VALUES (@fechaMuestra,@obserMuestra,@cantidadDmo)", Conexion);
                    adaptador.InsertCommand = altaMuestra;
                    adaptador.InsertCommand.Parameters.Add(new SqlParameter("@fechaMuestra", SqlDbType.Date));
                    adaptador.InsertCommand.Parameters.Add(new SqlParameter("@obserMuestra", SqlDbType.Text));
                    adaptador.InsertCommand.Parameters.Add(new SqlParameter("@cantidadDmo", SqlDbType.Int));

                    adaptador.InsertCommand.Parameters["@fechaMuestra"].Value = dtp_fechaMuestra.Value.ToString("yyyy-MM-dd");
                    string aux_obser = null;
                    if (txt_obserMuestra.Text != null)
                    {
                        aux_obser = txt_obserMuestra.Text;
                    }
                    adaptador.InsertCommand.Parameters["@obserMuestra"].Value = aux_obser;
                    adaptador.InsertCommand.Parameters["@cantidadDmo"].Value = int.Parse(txt_cantidadDmo.Text);

                    try
                    {
                        Conexion.Open();
                        adaptador.InsertCommand.ExecuteNonQuery();
                        mensaje += "- Muestras" + "\n";

                        //INSERCION DE DETALLE DE MUESTRAS
                        try
                        {
                            ad_detMuestra = new SqlDataAdapter();
                            SqlCommand altaDetalleMuestra = new SqlCommand("INSERT INTO detalleMuestras (codMuestra,codDmo) VALUES (@codMuestra,@codDmo)", Conexion);
                            ad_detMuestra.InsertCommand = altaDetalleMuestra;

                            foreach (DataGridViewRow fila_docDmo in dgv_docDmo.Rows)
                            {
                                ad_detMuestra.InsertCommand.Parameters.Clear();

                                ad_detMuestra.InsertCommand.Parameters.Add(new SqlParameter("@codMuestra", SqlDbType.Int));
                                ad_detMuestra.InsertCommand.Parameters.Add(new SqlParameter("@codDmo", SqlDbType.VarChar));

                                ad_detMuestra.InsertCommand.Parameters["@codMuestra"].Value = Convert.ToInt32(txt_codMuestra.Text);
                                ad_detMuestra.InsertCommand.Parameters["@codDmo"].Value = fila_docDmo.Cells[0].Value;

                                ad_detMuestra.InsertCommand.ExecuteNonQuery();

                            }
                            mensaje += "- Detalles de Muestra";
                            MessageBox.Show(mensaje, "Felicitaciones!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            limpiar();
                        }
                        catch (Exception ex2)
                        {
                            MessageBox.Show(ex2.ToString());
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                    finally
                    {
                    Conexion.Close();
                    }

                }

        }

        //cargar lo siguiente para el movimiento del panel 
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void MuestraMarcos_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void txt_cantidadDmo_TextChanged(object sender, EventArgs e)
        {
            btn_registrar.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
