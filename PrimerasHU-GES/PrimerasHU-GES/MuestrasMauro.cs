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


namespace PrimerasHU_GES
{
    public partial class MuestrasMauro : Form
    {
        public MuestrasMauro()
        {
            InitializeComponent();
        }

        private SqlConnection Conexion;
        private SqlDataAdapter adaptador;
        private SqlDataAdapter ad_ultDmo;
        private SqlDataAdapter ad_ultMuestra;

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
                int aux_codNvo = int.Parse(dt_ultMuestra.Rows[0].ToString());
                txt_codMuestra.Text = aux_codNvo.ToString();
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
                txt_ultDmo.Text = dt_ultDmo.Rows[0].ToString();
            }
        }

        private void MuestraMarcos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'ges_v01DataSetCodigosDmo.documentosDmo' Puede moverla o quitarla según sea necesario.
            this.documentosDmoTableAdapter.Fill(this.ges_v01DataSetCodigosDmo.documentosDmo);
            Conexion = new SqlConnection("Data source=.\\SQLEXPRESS; Initial Catalog = ges_v01; Integrated Security = True");
            adaptador = new SqlDataAdapter();

            recuperaUltimaMuestra();
            recuperaUltimoDmoUsado();
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
            recuperaUltimaMuestra();
            recuperaUltimoDmoUsado();
            txt_cantidadDmo.Text = "";
            txt_obserMuestra.Text = "";
        }

        private void Btn_previsual_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_cantidadDmo.Text))
            {
                MessageBox.Show("Debe ingresar la cantidad de DMO que quiere que contenga la muestra.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                string consultaUltDmo = "";
                int cantDmo = int.Parse(txt_cantidadDmo.Text); //recupero la cantidad de dmo que va a contenerla muestra
                //string ultimoDmoUsado = "";

                if (txt_ultDmo.Text == "N/A" || String.IsNullOrEmpty(txt_ultDmo.Text))
                {
                    consultaUltDmo = "SELECT TOP " + cantDmo + " codDmo AS 'Documentos DMO (no utilizados)' FROM documentosDmo";

                    SqlCommand cmd_dgvDmo = new SqlCommand(consultaUltDmo, Conexion);
                    SqlDataAdapter ad_dgvDmo = new SqlDataAdapter(cmd_dgvDmo);
                    DataTable dt_dgvDmo = new DataTable();
                    ad_dgvDmo.Fill(dt_dgvDmo);
                    dgv_docDmo.DataSource = dt_dgvDmo;
                }
                else
                {
                    consultaUltDmo = "SELECT TOP " + cantDmo + " codDmo AS 'Documentos DMO (no utilizados)' FROM documentosDmo WHERE codDmo >'" + txt_ultDmo.Text + "'";

                    SqlCommand cmd_dgvDmo = new SqlCommand(consultaUltDmo, Conexion);
                    SqlDataAdapter ad_dgvDmo = new SqlDataAdapter(cmd_dgvDmo);
                    DataTable dt_dgvDmo = new DataTable();
                    ad_dgvDmo.Fill(dt_dgvDmo);
                    dgv_docDmo.DataSource = dt_dgvDmo;
                }
            }
        }
    }
}
