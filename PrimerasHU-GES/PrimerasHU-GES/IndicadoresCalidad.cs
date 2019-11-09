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
    public partial class IndicadoresCalidad : Form
    {
        public IndicadoresCalidad()
        {
            InitializeComponent();
        }
        private SqlConnection conexion;
        private SqlDataAdapter adaptador;


        private void IndicadoresCalidad_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'ges_v01DataSet18.indicadoresCalidad' Puede moverla o quitarla según sea necesario.
            this.indicadoresCalidadTableAdapter.Fill(this.ges_v01DataSet18.indicadoresCalidad);
            conexion = new SqlConnection("Data source=.\\SQLEXPRESS;Initial Catalog=ges_v01;Integrated Security=True");
            adaptador = new SqlDataAdapter();

            SqlCommand alta = new SqlCommand("INSERT INTO indicadoresCalidad values (@fechoraModIndicador,@nomIndicador,@valorIndicador)", conexion);
            adaptador.InsertCommand = alta;

            
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@fechoraModIndicador", SqlDbType.Date));
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@nomIndicador", SqlDbType.VarChar));
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@valorIndicador", SqlDbType.Int));

           


        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {

            adaptador.InsertCommand.Parameters["@fechoraModIndicador"].Value = dtFecha.Value;
            adaptador.InsertCommand.Parameters["@nomIndicador"].Value = txtNomIndi.Text;
            adaptador.InsertCommand.Parameters["@valorIndicador"].Value = txtValor.Text;

            if (string.IsNullOrEmpty(txtValor.Text) || string.IsNullOrEmpty(txtValor.Text))

            {
                MessageBox.Show("Es obligatorio completar todos los campos para registrar el Indicador.", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    conexion.Open();
                   
                    adaptador.InsertCommand.ExecuteNonQuery();

                    MessageBox.Show("Registro de indicador cargado con exito");
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
        }
    }
}
