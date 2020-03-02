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
    public partial class VisorDmo : Form
    {
        public VisorDmo()
        {
            InitializeComponent();
        }

        private SqlConnection Conexion;
        private SqlDataAdapter adaptador;
        private SqlDataAdapter verDatos;

        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void VisorDmo_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'ges_v01DocumentosDmo2.documentosDmo' Puede moverla o quitarla según sea necesario.
            this.documentosDmoTableAdapter.Fill(this.ges_v01DocumentosDmo2.documentosDmo);
            // TODO: esta línea de código carga datos en la tabla 'ges_v01DocumentosDmo.detallesDocumentoDmo' Puede moverla o quitarla según sea necesario.
            this.detallesDocumentoDmoTableAdapter.Fill(this.ges_v01DocumentosDmo.detallesDocumentoDmo);
            Conexion = new SqlConnection("Data source=.\\SQLEXPRESS; Initial Catalog = ges_v01; Integrated Security = True");
            adaptador = new SqlDataAdapter();

            cb_dmo.Enabled = false;
            cb_coordenada.Enabled = false;
        }

        private void Btn_actualizarDocumentosDmo_Click(object sender, EventArgs e)
        {
            SqlCommand dmo = new SqlCommand("SELECT cp.codCPlan AS 'Control Plan',cp.codPrograma AS 'Programa',sv.descSeccion AS 'Sección',dd.codDmo AS 'Documento Dmo',dd.fechaDmo AS 'Fecha del Dmo',dd.hora AS 'Hora del Dmo'" +
                "FROM controlPlan AS cp, seccionesVehiculo AS sv, documentosDmo AS dd WHERE cp.codCPlan = dd.codCPlan AND cp.codSeccion = sv.codSeccion ORDER BY dd.fechaDmo DESC, dd.hora DESC", Conexion);
            adaptador = new SqlDataAdapter(dmo);

            try
            {
                DataTable dt = new DataTable();
                adaptador.Fill(dt);
                dgv_documentosDmo.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR EX: " + ex.ToString());
            }
        }

        private void Check_dmo_CheckedChanged(object sender, EventArgs e)
        {
            if (check_dmo.Checked == true)
            {
                cb_dmo.Enabled = true;
            }
            else
            {
                cb_dmo.Enabled = false;
            }
        }

        private void Check_coordenada_CheckedChanged(object sender, EventArgs e)
        {
            if (check_coordenada.Checked == true)
            {
                cb_coordenada.Enabled = true;
            }
            else
            {
                cb_coordenada.Enabled = false;
            }
        }

        private void Btn_actualizarMediciones_Click(object sender, EventArgs e)
        {
            string cadena = "";
            string auxDmo = "";
            string auxCoord = "";
            int noEjecutar = 1;
            if (check_dmo.Checked == false && check_coordenada.Checked == false)
            {
                cadena = "SELECT DISTINCT x.codDmo AS 'Control Plan', x.codMediX AS 'Punto', x.codMedicion AS 'ID Medición', x.medidoX AS 'Medido - X (mm)', y.medidoY AS 'Medido - Y (mm)', z.medidoZ AS 'Medido - Z (mm)', x.desvX AS 'Desviación - X (mm)', y.desvY AS 'Desviación - Y (mm)', z.desvZ AS 'Desviación - Z (mm)', x.nominalX AS 'Nominal - X (mm)', y.nominalY AS 'Nominal - Y (mm)', z.nominalZ AS 'Nominal - Z (mm)' FROM puntosMedidosX AS x, puntosMedidosY AS y, puntosMedidosZ AS z, puntosMedidosD AS d WHERE x.codMediX = y.codMediY AND x.codMediX = z.codMediZ AND x.codDmo = y.codDmo AND x.codDmo = z.codDmo ORDER BY x.codMedicion ASC";
            }
            else
            {
                if (check_dmo.Checked == true && check_coordenada.Checked == false)
                {
                    auxDmo = cb_dmo.SelectedValue.ToString();
                    cadena = "SELECT DISTINCT x.codDmo AS 'Control Plan', x.codMediX AS 'Punto', x.codMedicion AS 'ID Medición', x.medidoX AS 'Medido - X (mm)', y.medidoY AS 'Medido - Y (mm)', z.medidoZ AS 'Medido - Z (mm)', x.desvX AS 'Desviación - X (mm)', y.desvY AS 'Desviación - Y (mm)', z.desvZ AS 'Desviación - Z (mm)', x.nominalX AS 'Nominal - X (mm)', y.nominalY AS 'Nominal - Y (mm)', z.nominalZ AS 'Nominal - Z (mm)' FROM puntosMedidosX AS x, puntosMedidosY AS y, puntosMedidosZ AS z, puntosMedidosD AS d WHERE x.codMediX = y.codMediY AND x.codMediX = z.codMediZ AND x.codDmo = y.codDmo AND x.codDmo = z.codDmo AND x.codDmo = '"+auxDmo+"' ORDER BY x.codMedicion ASC";
                }
                else
                {
                    if (check_dmo.Checked == false && check_coordenada.Checked == true)
                    {
                        if (cb_coordenada.SelectedItem != null)
                        {
                            auxCoord = cb_coordenada.SelectedItem.ToString();
                            if (auxCoord == "X")
                            {
                                cadena = "SELECT DISTINCT x.codDmo AS 'Control Plan', x.codMediX AS 'Punto', x.codMedicion AS 'ID Medición', x.medidoX AS 'Medido - X (mm)', x.desvX AS 'Desviación - X (mm)', x.nominalX AS 'Nominal - X (mm)' FROM puntosMedidosX AS x ORDER BY x.codMedicion ASC";
                            }
                            else
                            {
                                if (auxCoord == "Y")
                                {
                                    cadena = "SELECT DISTINCT y.codDmo AS 'Control Plan', y.codMediY AS 'Punto', y.codMedicion AS 'ID Medición', y.medidoY AS 'Medido - Y (mm)', y.desvY AS 'Desviación - Y (mm)', y.nominalY AS 'Nominal - Y (mm)' FROM puntosMedidosY AS y ORDER BY y.codMedicion ASC";
                                }
                                else
                                {
                                    if (auxCoord == "Z")
                                    {
                                        cadena = "SELECT DISTINCT z.codDmo AS 'Control Plan', z.codMediZ AS 'Punto', z.codMedicion AS 'ID Medición', z.medidoZ AS 'Medido - Z (mm)', z.desvZ AS 'Desviación - Z (mm)', z.nominalZ AS 'Nominal - Z (mm)' FROM puntosMedidosZ AS z ORDER BY z.codMedicion ASC";
                                    }
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Ha decidido aplicar el filtro de Coordenada pero no ha seleccionado ninguna opción.");
                            noEjecutar = 0;
                        }
                    }
                    else
                    {
                        auxDmo = cb_dmo.SelectedValue.ToString();
                        if (cb_coordenada.SelectedItem != null)
                        {
                            auxCoord = cb_coordenada.SelectedItem.ToString();
                            if (auxCoord == "X")
                            {
                                cadena = "SELECT DISTINCT x.codDmo AS 'Control Plan', x.codMediX AS 'Punto', x.codMedicion AS 'ID Medición', x.medidoX AS 'Medido - X (mm)', x.desvX AS 'Desviación - X (mm)', x.nominalX AS 'Nominal - X (mm)' FROM puntosMedidosX AS x WHERE x.codDmo = '" + auxDmo + "' ORDER BY x.codMedicion ASC";
                            }
                            else
                            {
                                if (auxCoord == "Y")
                                {
                                    cadena = "SELECT DISTINCT y.codDmo AS 'Control Plan', y.codMediY AS 'Punto', y.codMedicion AS 'ID Medición', y.medidoY AS 'Medido - Y (mm)', y.desvY AS 'Desviación - Y (mm)', y.nominalY AS 'Nominal - Y (mm)' FROM puntosMedidosY AS y WHERE y.codDmo = '" + auxDmo + "' ORDER BY y.codMedicion ASC";
                                }
                                else
                                {
                                    if (auxCoord == "Z")
                                    {
                                        cadena = "SELECT DISTINCT z.codDmo AS 'Control Plan', z.codMediZ AS 'Punto', z.codMedicion AS 'ID Medición', z.medidoZ AS 'Medido - Z (mm)', z.desvZ AS 'Desviación - Z (mm)', z.nominalZ AS 'Nominal - Z (mm)' FROM puntosMedidosZ AS z WHERE z.codDmo = '" + auxDmo + "' ORDER BY z.codMedicion ASC";
                                    }
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Ha decidido aplicar el filtro de Coordenada pero no ha seleccionado ninguna opción.");
                            noEjecutar = 0;
                        }
                    }
                }
            }


            SqlCommand datos = new SqlCommand(cadena, Conexion);
            verDatos = new SqlDataAdapter(datos);

            if (noEjecutar == 1)
            {
                try
                {
                    DataTable dt2 = new DataTable();
                    verDatos.Fill(dt2);
                    dgv_mediciones.DataSource = dt2;
                }
                catch (Exception ex2)
                {
                    MessageBox.Show("ERROR EX2: " + ex2.ToString());
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.WindowState = FormWindowState.Minimized;

        }

        private void btn_Salir_Click_1(object sender, EventArgs e)
        {
            this.Dispose();

        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
