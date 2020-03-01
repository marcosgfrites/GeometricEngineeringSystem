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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private SqlConnection Conexion;
        private SqlDataAdapter adaptador;
        private DataSet datos;

        private void btn_Salir_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            Conexion = new SqlConnection("Data source=.\\SQLEXPRESS; Initial Catalog = ges_v01; Integrated Security = True");
            adaptador = new SqlDataAdapter();
            datos = new DataSet();

            SqlCommand consulta = new SqlCommand("SELECT codUsu,codTipoUsu,nomUsu,codEstado,claveUsu FROM usuarios WHERE codUsu=@txt_Usuario AND claveUsu=@txt_Clave AND codEstado=1", Conexion);
            adaptador.SelectCommand = consulta;
            adaptador.SelectCommand.Parameters.Add("@txt_Usuario", SqlDbType.Int);
            adaptador.SelectCommand.Parameters.Add("@txt_Clave", SqlDbType.VarChar);
        }

        private void btn_Entrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_Usuario.Text) || string.IsNullOrEmpty(txt_Clave.Text))
            {
                MessageBox.Show("Falta uno o más datos de ingresar!","ATENCIÓN!",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    Conexion.Open();
                    adaptador.SelectCommand.Parameters["@txt_Usuario"].Value = int.Parse(txt_Usuario.Text);
                    adaptador.SelectCommand.Parameters["@txt_Clave"].Value = txt_Clave.Text;
                    adaptador.Fill(datos, "usuarios");
                    int registro = int.Parse(datos.Tables["usuarios"].Rows.Count.ToString());
                    if (registro == 1)
                    {
                        PrimeraPantalla f = new PrimeraPantalla();
                        foreach (DataRow fila in datos.Tables["usuarios"].Rows)
                        { 
                            f.lbl_Usuario.Text = fila["nomUsu"].ToString();
                            // recupera tipo usuario
                            string aux = fila["codTipoUsu"].ToString();
                            string tipo = "";
                            if (aux == "1")
                            {
                                tipo = "Administrador";
                            }
                            else
                            {
                                if (aux == "2")
                                {
                                    tipo = "Encargado DE&MS";
                                }
                                else
                                {
                                    tipo = "Responsable Analista";
                                }
                            }
                            f.lbl_TipoUsu.Text = tipo;

                            //Avisa si estado es DESHABILITADO para que se pongan en contacto con el Administrador
                            aux = fila["codEstado"].ToString();
                            if(aux == "2")
                            {
                                MessageBox.Show("Usuario deshabilitado! Póngase en contacto con el administrador.");
                            }
                        }
                        f.lb_CodUsu.Text = txt_Usuario.Text;

                        //registro Fecha y Hora de la Última Sesión del Usuario
                        SqlCommand cmd = new SqlCommand("UPDATE usuarios SET fechoraUltSesion=@fechoraUltSesion WHERE codUsu=@codUsu", Conexion);
                        adaptador.UpdateCommand = cmd;
                        adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@codUsu", SqlDbType.Int));
                        adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@fechoraUltSesion", SqlDbType.DateTime));
                        adaptador.UpdateCommand.Parameters["@codUsu"].Value = Convert.ToInt32(txt_Usuario.Text);
                        adaptador.UpdateCommand.Parameters["@fechoraUltSesion"].Value = DateTime.Now;
                        try
                        {
                            adaptador.UpdateCommand.ExecuteNonQuery();
                            //MessageBox.Show("Login registrado!","Atención!",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        }
                        catch (SqlException ex2)
                        {
                            MessageBox.Show(ex2.ToString());
                        }

                        f.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Al menos uno de los datos ingresados es incorrecto o su cuenta puede encontrarse deshabilitada."+"\n"+"Reintente nuevamente. Si el problema persiste, póngase en contacto con el administrador.","ERROR!",MessageBoxButtons.OK,MessageBoxIcon.Error);
                        limpiar();
                    }

                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                finally
                {
                    Conexion.Close();
                }
            }

        }

        private void limpiar()
        {
            txt_Usuario.Text = "";
            txt_Clave.Text = "";
        }

        private void txt_Usuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back);
        }

        private void bunifuCustomLabel2_Click(object sender, EventArgs e)
        {

        }

        private void txt_Clave_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Usuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void txt_Clave_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (string.IsNullOrEmpty(txt_Usuario.Text) || string.IsNullOrEmpty(txt_Clave.Text))
                {
                    MessageBox.Show("Falta uno o más datos de ingresar!", "ATENCIÓN!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    try
                    {
                        Conexion.Open();
                        adaptador.SelectCommand.Parameters["@txt_Usuario"].Value = int.Parse(txt_Usuario.Text);
                        adaptador.SelectCommand.Parameters["@txt_Clave"].Value = txt_Clave.Text;
                        adaptador.Fill(datos, "usuarios");
                        int registro = int.Parse(datos.Tables["usuarios"].Rows.Count.ToString());
                        if (registro == 1)
                        {
                            PrimeraPantalla f = new PrimeraPantalla();
                            foreach (DataRow fila in datos.Tables["usuarios"].Rows)
                            {
                                f.lbl_Usuario.Text = fila["nomUsu"].ToString();
                                // recupera tipo usuario
                                string aux = fila["codTipoUsu"].ToString();
                                string tipo = "";
                                if (aux == "1")
                                {
                                    tipo = "Administrador";
                                }
                                else
                                {
                                    if (aux == "2")
                                    {
                                        tipo = "Encargado DE&MS";
                                    }
                                    else
                                    {
                                        tipo = "Responsable Analista";
                                    }
                                }
                                f.lbl_TipoUsu.Text = tipo;
                                f.lb_CodUsu.Text = txt_Usuario.Text;

                                //Avisa si estado es DESHABILITADO para que se pongan en contacto con el Administrador
                                aux = fila["codEstado"].ToString();
                                if (aux == "2")
                                {
                                    MessageBox.Show("Usuario deshabilitado! Póngase en contacto con el administrador.");
                                }
                            }
                            f.Show();

                            //registro Fecha y Hora de la Última Sesión del Usuario
                            SqlCommand cmd = new SqlCommand("UPDATE usuarios SET fechoraUltSesion=@fechoraUltSesion WHERE codUsu=@codUsu", Conexion);
                            adaptador.UpdateCommand = cmd;
                            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@codUsu", SqlDbType.Int));
                            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@fechoraUltSesion", SqlDbType.DateTime));
                            adaptador.UpdateCommand.Parameters["@codUsu"].Value = Convert.ToInt32(txt_Usuario.Text);
                            adaptador.UpdateCommand.Parameters["@fechoraUltSesion"].Value = DateTime.Now;
                            try
                            {
                                adaptador.UpdateCommand.ExecuteNonQuery();
                                //MessageBox.Show("Login registrado!","Atención!",MessageBoxButtons.OK,MessageBoxIcon.Information);
                            }
                            catch (SqlException ex2)
                            {
                                MessageBox.Show(ex2.ToString());
                            }

                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Al menos uno de los datos ingresados es incorrecto o su cuenta puede encontrarse deshabilitada." + "\n" + "Reintente nuevamente. Si el problema persiste, póngase en contacto con el administrador.", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            limpiar();
                        }

                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                    finally
                    {
                        Conexion.Close();
                    }
                }
            }
        }
    }
}
