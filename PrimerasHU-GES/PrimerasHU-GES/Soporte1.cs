using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PrimerasHU_GES
{
    public partial class Soporte1 : Form
    {
        public Soporte1()
        {
            InitializeComponent();
        }

        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private SqlConnection conexion;
        private SqlDataAdapter adaptador;
        private DataSet datos;

        int busqueda = 0;


        private void Soporte1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'ges_v01DataSet8.usuarios' Puede moverla o quitarla según sea necesario.
            this.usuariosTableAdapter.Fill(this.ges_v01DataSet8.usuarios);
            // TODO: esta línea de código carga datos en la tabla 'ges_v01DataSet8.operariosMaquina' Puede moverla o quitarla según sea necesario.
            this.operariosMaquinaTableAdapter.Fill(this.ges_v01DataSet8.operariosMaquina);
            // TODO: esta línea de código carga datos en la tabla 'ges_v01DataSet8.compiladores' Puede moverla o quitarla según sea necesario.
            this.compiladoresTableAdapter.Fill(this.ges_v01DataSet8.compiladores);
            // TODO: esta línea de código carga datos en la tabla 'ges_v01DataSet8.aprobadores' Puede moverla o quitarla según sea necesario.
            this.aprobadoresTableAdapter.Fill(this.ges_v01DataSet8.aprobadores);
            conexion = new SqlConnection("Data source=.\\SQLEXPRESS; Initial Catalog = ges_v01; Integrated Security = True");
            adaptador = new SqlDataAdapter();
            datos = new DataSet();


        }

        private void BtnRegCompilador_Click(object sender, EventArgs e)
        {
            SqlCommand alta = new SqlCommand("INSERT INTO compiladores (codCompilador,nomCompilador) VALUES (@codCompilador,@nomCompilador)", conexion);

            adaptador.InsertCommand = alta;
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@codCompilador", SqlDbType.Int));
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@nomCompilador", SqlDbType.VarChar));

            adaptador.InsertCommand.Parameters["@codCompilador"].Value = txtCodCompilador.Text;
            adaptador.InsertCommand.Parameters["@nomCompilador"].Value = txtNombCompilador.Text;

            if (string.IsNullOrEmpty(txtCodCompilador.Text) || string.IsNullOrEmpty(txtNombCompilador.Text))
            
            {
                MessageBox.Show("Es obligatorio completar todos los campos.", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    conexion.Open();

                    SqlDataAdapter compCodCompilador = new SqlDataAdapter("SELECT codCompilador FROM compiladores WHERE codCompilador=@codCompilador", conexion);
                    DataTable codComp = new DataTable();
                    compCodCompilador.SelectCommand.Parameters.Add(new SqlParameter("@codCompilador", SqlDbType.Int));
                    compCodCompilador.SelectCommand.Parameters["@codCompilador"].Value = txtCodCompilador.Text;
                    compCodCompilador.Fill(codComp);


                    if (codComp.Rows.Count > 0)
                    {
                        MessageBox.Show("El 'código' ingresado ya existe.", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {

                        adaptador.InsertCommand.ExecuteNonQuery();
                        MessageBox.Show("Se ha registrado correctamente la Seccion de vehivulo.", "Operación Exitosa!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Limpiar();

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
        }

        private void Limpiar()
        {
            txtCodAprobador.Text = "";
            txtNombAprobador.Text = "";
            this.compiladoresTableAdapter.Fill(this.ges_v01DataSet8.compiladores);
            busqueda = 0;
        }

        private void BtnLimpiarCompilador_Click(object sender, EventArgs e)
        {

        }
    }
}
