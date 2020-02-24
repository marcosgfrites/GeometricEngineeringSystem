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

//Probandooooooo de nuevoooooo
namespace PrimerasHU_GES
{
    public partial class tipoPuntoClasificacion : Form
    {//MARCOS GABRIEL FRITES DEBENEDETTI - PROBANDO PULL DE GITHUB
        public tipoPuntoClasificacion()
        {
            InitializeComponent();
        }
        private SqlConnection Conexion;
        private SqlDataAdapter adaptador;
        private DataSet datos1;
        private DataSet datos2;
        int busqueda = 0;


        private void TipoPuntoClasificacion_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'ges_v01DataSet5.tiposPunto' Puede moverla o quitarla según sea necesario.
            this.tiposPuntoTableAdapter.Fill(this.ges_v01DataSet5.tiposPunto);
            // TODO: esta línea de código carga datos en la tabla 'ges_v01DataSet4.clasificacionesPunto' Puede moverla o quitarla según sea necesario.
            this.clasificacionesPuntoTableAdapter1.Fill(this.ges_v01DataSet4.clasificacionesPunto);
            // TODO: esta línea de código carga datos en la tabla 'ges_v01DataSet3.clasificacionesPunto' Puede moverla o quitarla según sea necesario.
            this.clasificacionesPuntoTableAdapter.Fill(this.ges_v01DataSet3.clasificacionesPunto);

            Conexion = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=ges_v01;Integrated Security=True");
            adaptador = new SqlDataAdapter();
            datos1 = new DataSet();
            datos2 = new DataSet();

        }


        private void Btn_altaTipoV_Click(object sender, EventArgs e)
        {
            SqlCommand alta = new SqlCommand("INSERT INTO clasificacionesPunto VALUES (@codClasifPto,@descClasifPto)", Conexion);
            adaptador.InsertCommand = alta;
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@codClasifPto", SqlDbType.VarChar));
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@descClasifPto", SqlDbType.VarChar));

            adaptador.InsertCommand.Parameters["@codClasifPto"].Value = txt_codClasifi.Text;
            adaptador.InsertCommand.Parameters["@descClasifPto"].Value = txt_descClasifi.Text;

            if (string.IsNullOrEmpty(txt_codClasifi.Text) || string.IsNullOrEmpty(txt_descClasifi.Text))
            {
                MessageBox.Show("Es obligatorio completar los campos Código y Descripción", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    Conexion.Open();

                    // en las proximas lineas realiza una consulta para ver si el código utilizado ya existe
                    SqlDataAdapter auxTipoCla = new SqlDataAdapter("SELECT codClasifPto FROM clasificacionesPunto WHERE codClasifPto=@codClasifPto", Conexion);
                    DataTable tipoCla = new DataTable();
                    auxTipoCla.SelectCommand.Parameters.Add(new SqlParameter("@codClasifPto", SqlDbType.VarChar));
                    auxTipoCla.SelectCommand.Parameters["@codClasifPto"].Value = txt_codClasifi.Text;
                    auxTipoCla.Fill(tipoCla);

                    if (tipoCla.Rows.Count > 0) //si la condicion se cumple, el código ingresado ya se encuentra registrado
                    {
                        MessageBox.Show("El 'código' ingresado ya existe.", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        adaptador.InsertCommand.ExecuteNonQuery();
                        MessageBox.Show("Se ha registrado correctamente la 'Clasificación'", "Operación Exitosa!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR:" + ex.ToString());
                }
                finally
                {
                    Conexion.Close();
                    limpiarClasiPto();
                }
            }
        }

        private void Btn_Salir_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void LimpClasiBtn_Click(object sender, EventArgs e)
        {
            limpiarClasiPto();
        }
        private void limpiarClasiPto()
        {
            this.clasificacionesPuntoTableAdapter1.Fill(this.ges_v01DataSet4.clasificacionesPunto); //recargo el DGV para actualizarlo a cada manejo de datos
            txt_codClasifi.Text = "";
            txt_descClasifi.Text = "";
            busqueda = 0; //establezco busqueda a 0, para poder conocer previamente si antes de "Modificar" se realizo una búsqueda
        }

        private void limpiarTipoPto()
        {
            this.tiposPuntoTableAdapter.Fill(this.ges_v01DataSet5.tiposPunto);//recargo el DGV para actualizarlo a cada manejo de datos
            codTipoPtoTxt.Text = "";
            codClasiPtoCmb.Text = "";
            descClasiPtoTxt.Text = "";
            busqueda = 0; //establezco busqueda a 0, para poder conocer previamente si antes de "Modificar" se realizo una búsqueda
        }

        private void ModifiClasiBtn_Click(object sender, EventArgs e)
        {
            SqlCommand modifica = new SqlCommand("UPDATE clasificacionesPunto SET descClasifPto=@descClasifPto WHERE codClasifPto=@codClasifPto", Conexion);
            adaptador.UpdateCommand = modifica;
            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@descClasifPto", SqlDbType.VarChar));
            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@codClasifPto", SqlDbType.VarChar));

            adaptador.UpdateCommand.Parameters["@codClasifPto"].Value = txt_codClasifi.Text;
            adaptador.UpdateCommand.Parameters["@descClasifPto"].Value = txt_descClasifi.Text;

            if ((string.IsNullOrEmpty(txt_codClasifi.Text) || string.IsNullOrEmpty(txt_descClasifi.Text)) && busqueda == 0)
            {
                MessageBox.Show("Por seguridad de los datos, primero debe realizar la búsqueda del 'codigo de clasificación' a modificar", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    Conexion.Open();
                    adaptador.UpdateCommand.ExecuteNonQuery();
                    MessageBox.Show("Se ha modificado correctamente la 'Clasificación'", "Operación Exitosa!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR:" + ex.ToString());
                }
                finally
                {
                    Conexion.Close();
                    limpiarClasiPto();
                }
            }
        }

        private void ElimiClasiBtn_Click(object sender, EventArgs e)
        {
            SqlCommand baja = new SqlCommand("DELETE FROM clasificacionesPunto WHERE codClasifPto=@codClasifPto", Conexion);
            adaptador.DeleteCommand = baja;
            adaptador.DeleteCommand.Parameters.Add(new SqlParameter("@codClasifPto", SqlDbType.VarChar));

            adaptador.DeleteCommand.Parameters["@codClasifPto"].Value = txt_codClasifi.Text;

            if (string.IsNullOrEmpty(txt_codClasifi.Text))
            {
                MessageBox.Show("Es obligatorio completar el campo 'Código' para buscar el elemento a eliminar", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    Conexion.Open();
                    int cantidad = adaptador.DeleteCommand.ExecuteNonQuery();
                    if (cantidad == 0)
                    {
                        MessageBox.Show("El 'Código' ingresado no existe en la base de datos.", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        MessageBox.Show("El 'Código':" + txt_codClasifi.Text + ", fue eliminado correctamente.", "Operación Exitosa!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR:" + ex.ToString());
                }
                finally
                {
                    Conexion.Close();
                    limpiarClasiPto();
                }
            }
        }

        private void BuscarClasiBtn_Click(object sender, EventArgs e)
        {
            SqlCommand consulta = new SqlCommand("SELECT * FROM clasificacionesPunto WHERE codClasifPto=@codClasifPto", Conexion);
            adaptador.SelectCommand = consulta;
            adaptador.SelectCommand.Parameters.Add(new SqlParameter("@codClasifPto", SqlDbType.VarChar));

            adaptador.SelectCommand.Parameters["@codClasifPto"].Value = txt_codClasifi.Text;

            if (string.IsNullOrEmpty(txt_codClasifi.Text))
            {
                MessageBox.Show("Es obligatorio completar el campo 'Código' para buscar el elemento a modificar/eliminar", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    Conexion.Open();
                    datos1 = new DataSet();
                    adaptador.Fill(datos1, "clasificacionesPunto");
                    int registro = int.Parse(datos1.Tables["clasificacionesPunto"].Rows.Count.ToString());
                    if (registro == 1)
                    {
                        foreach (DataRow fila in datos1.Tables["clasificacionesPunto"].Rows)
                        {
                            txt_codClasifi.Text = fila["codClasifPto"].ToString();
                            txt_descClasifi.Text = fila["descClasifPto"].ToString();
                        }
                        busqueda = 1;
                    }
                    else
                    {
                        MessageBox.Show("El 'Código' ingresado no existe en la base de datos.", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR:" + ex.ToString());
                }
                finally
                {
                    Conexion.Close();
                }
            }
        }

        private void RegTipoPtoBtn_Click(object sender, EventArgs e)
        {
            SqlCommand alta = new SqlCommand("INSERT INTO tiposPunto VALUES (@codTipoPto,@codClasifPto,@descTipoPto)", Conexion);
            adaptador.InsertCommand = alta;
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@codTipoPto", SqlDbType.VarChar));
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@codClasifPto", SqlDbType.VarChar));
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@descTipoPto", SqlDbType.VarChar));
            ;

            if (string.IsNullOrEmpty(codTipoPtoTxt.Text) || string.IsNullOrEmpty(descClasiPtoTxt.Text))
            {
                MessageBox.Show("Es obligatorio completar los campos Código y Decripcion", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    adaptador.InsertCommand.Parameters["@codTipoPto"].Value = codTipoPtoTxt.Text;
                    adaptador.InsertCommand.Parameters["@codClasifPto"].Value = codClasiPtoCmb.SelectedValue;
                    adaptador.InsertCommand.Parameters["@descTipoPto"].Value = descClasiPtoTxt.Text;
                   

                    Conexion.Open();

                    // en las proximas lineas realiza una consulta para ver si el código utilizado ya existe
                    SqlDataAdapter auxModV = new SqlDataAdapter("SELECT codTipoPto FROM tiposPunto WHERE codTipoPto=@codTipoPto", Conexion);
                    DataTable tipoPto = new DataTable();
                    auxModV.SelectCommand.Parameters.Add(new SqlParameter("@codTipoPto", SqlDbType.VarChar));
                    auxModV.SelectCommand.Parameters["@codTipoPto"].Value = codTipoPtoTxt.Text;
                    auxModV.Fill(tipoPto);
                    if (tipoPto.Rows.Count > 0) //si la condicion se cumple, el código ingresado ya se encuentra registrado
                    {
                        MessageBox.Show("El 'código' ingresado ya existe.", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        adaptador.InsertCommand.ExecuteNonQuery();
                        MessageBox.Show("Se ha registrado correctamente un nuevo 'Tipo de Punto': " + descClasiPtoTxt.Text, "Operación Exitosa!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR:" + ex.ToString());
                }
                finally
                {
                    Conexion.Close();
                    limpiarTipoPto();
                }
            }
        }

        private void BuscarTipoPtoBtn_Click(object sender, EventArgs e)
        {
            SqlCommand consulta = new SqlCommand("SELECT * FROM tiposPunto WHERE codTipoPto=@codTipoPto", Conexion);
            adaptador.SelectCommand = consulta;
            adaptador.SelectCommand.Parameters.Add(new SqlParameter("@codTipoPto", SqlDbType.VarChar));

            adaptador.SelectCommand.Parameters["@codTipoPto"].Value = codTipoPtoTxt.Text;

            if (string.IsNullOrEmpty(codTipoPtoTxt.Text))
            {
                MessageBox.Show("Es obligatorio completar el campo 'Código' para buscar el elemento a modificar/eliminar", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    Conexion.Open();
                    datos2 = new DataSet();
                    adaptador.Fill(datos2,"tiposPunto");
                    int registro = int.Parse(datos2.Tables["tiposPunto"].Rows.Count.ToString());
                    if (registro == 1)
                    {
                        foreach (DataRow fila in datos2.Tables["tiposPunto"].Rows)
                        {
                            codTipoPtoTxt.Text = fila["codTipoPto"].ToString();
                            codClasiPtoCmb.SelectedValue = fila["codClasifPto"];
                            descClasiPtoTxt.Text= fila["descTipoPto"].ToString();
                          
                        }
                        busqueda = 1;
                    }
                    else
                    {
                        MessageBox.Show("El 'Código' ingresado no existe en la base de datos.", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR:" + ex.ToString());
                }
                finally
                {
                    Conexion.Close();
                }
            }
        }

        private void ElimTipoPtoBtn_Click(object sender, EventArgs e)
        {
            SqlCommand baja = new SqlCommand("DELETE FROM tiposPunto WHERE codTipoPto=@codTipoPto", Conexion);
            adaptador.DeleteCommand = baja;
            adaptador.DeleteCommand.Parameters.Add(new SqlParameter("@codTipoPto", SqlDbType.VarChar));

            adaptador.DeleteCommand.Parameters["@codTipoPto"].Value = codTipoPtoTxt.Text;

            if (string.IsNullOrEmpty(codTipoPtoTxt.Text))
            {
                MessageBox.Show("Es obligatorio completar el campo 'Código' para buscar el elemento a eliminar", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    Conexion.Open();
                    int cantidad = adaptador.DeleteCommand.ExecuteNonQuery();
                    if (cantidad == 0)
                    {
                        MessageBox.Show("El 'Código' ingresado no existe en la base de datos.", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        MessageBox.Show("El 'Código':" + codTipoPtoTxt.Text + ", fue eliminado correctamente.", "Operación Exitosa!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR:" + ex.ToString());
                }
                finally
                {
                    Conexion.Close();
                    limpiarTipoPto();
                }
            }
        }

        private void ModifiTipoPtoBtn_Click(object sender, EventArgs e)
        {
            SqlCommand modifica = new SqlCommand("UPDATE tiposPunto SET codTipoPto=@codTipoPto,codClasifPto=@codClasifPto,descTipoPto=@descTipoPto WHERE codTipoPto=@codTipoPto", Conexion);
            adaptador.UpdateCommand = modifica;
            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@codTipoPto", SqlDbType.VarChar));
            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@codClasifPto", SqlDbType.VarChar));
            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@descTipoPto", SqlDbType.VarChar));
           

            adaptador.UpdateCommand.Parameters["@codTipoPto"].Value = codTipoPtoTxt.Text;
            adaptador.UpdateCommand.Parameters["@codClasifPto"].Value = codClasiPtoCmb.SelectedValue;
            adaptador.UpdateCommand.Parameters["@descTipoPto"].Value = descClasiPtoTxt.Text;
           ;

            if ((string.IsNullOrEmpty(codTipoPtoTxt.Text) || string.IsNullOrEmpty(descClasiPtoTxt.Text)) && busqueda == 0)
            {
                MessageBox.Show("Por seguridad de los datos, primero debe realizar la búsqueda del 'Tipo de Punto' a modificar", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    Conexion.Open();
                    adaptador.UpdateCommand.ExecuteNonQuery();
                    MessageBox.Show("Se ha modificado correctamente el 'Tipo de punto'", "Operación Exitosa!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpiarTipoPto();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR:" + ex.ToString());
                }
                finally
                {
                    Conexion.Close();
                }
            }
        }

        private void LimpTipoPtoBtn_Click(object sender, EventArgs e)
        {
            limpiarTipoPto();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.WindowState = FormWindowState.Minimized;

        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Dispose();

        }
    }
}
