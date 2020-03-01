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
using System.Runtime.InteropServices;
using System.Collections;

namespace PrimerasHU_GES
{
    //[ProvideProperty("CueText", typeof(TextBox))]

    public partial class Usuarios : Form
    {
        //Prueba
        #region DLLs para poder mover el form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        #endregion

        /*
        #region DLL para "PlaceHolder"
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = false)]
        private static extern IntPtr SendMessage(IntPtr hWnd, Int32 Msg, IntPtr wParam, IntPtr lParam);
        private const int ECM_FIRST = 0x1500;
        private const int EM_SETCUEBANNER = ECM_FIRST + 1;
        private readonly IntPtr TRUE = (IntPtr)1;

        private Hashtable cueBannerTable = new Hashtable();
        public bool CanExtend(object extendee)
        {
            if (extendee is Control)
                return true;
            return false;
        }

        [DefaultValue("")]
        [DisplayName("CueText")]
        public string GetCueText(TextBox control)
        {
            if (control is TextBox)
            {
                string cueText = (string)this.cueBannerTable[control];
                return cueText == null ? string.Empty : cueText;
            }
            return string.Empty;
        }
        public void SetCueText(TextBox control, string cueText)
        {
            if (control is TextBox)
            {
                this.cueBannerTable[control] = cueText;
                SendMessage(control.Handle, EM_SETCUEBANNER, TRUE, Marshal.StringToBSTR(cueText));
            }
        }
        #endregion
        */

        public Usuarios()
        {
            InitializeComponent();
        }   
        private SqlConnection conexion;
        private SqlDataAdapter adaptador;
        private DataSet datos;
        int busqueda = 0;
        int posicion = 0;

        private void Usuarios_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'ges_v01DataSet18Estados.estados' Puede moverla o quitarla según sea necesario.
            this.estadosTableAdapter.Fill(this.ges_v01DataSet18Estados.estados);
            // TODO: esta línea de código carga datos en la tabla 'ges_v01DataSet18TiposUsuario.tiposUsuario' Puede moverla o quitarla según sea necesario.
            this.tiposUsuarioTableAdapter1.Fill(this.ges_v01DataSet18TiposUsuario.tiposUsuario);
            // TODO: esta línea de código carga datos en la tabla 'ges_v01DataSet15.tiposUsuario' Puede moverla o quitarla según sea necesario.
            this.tiposUsuarioTableAdapter.Fill(this.ges_v01DataSet15.tiposUsuario);
            // TODO: esta línea de código carga datos en la tabla 'ges_v01DataSet13.usuarios' Puede moverla o quitarla según sea necesario.
            this.usuariosTableAdapter1.Fill(this.ges_v01DataSet13.usuarios);
            // TODO: esta línea de código carga datos en la tabla 'ges_v01DataSet11.usuarios' Puede moverla o quitarla según sea necesario.
            this.usuariosTableAdapter.Fill(this.ges_v01DataSet11.usuarios);
            conexion = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=ges_v01;Integrated Security=True");
            adaptador = new SqlDataAdapter();
            datos = new DataSet();

            txtClaveUsuario.MaxLength = 16;
            

            //txtClaveUsuario.GotFocus += new EventHandler(this.TextGotFocus);
            //txtClaveUsuario.LostFocus += new EventHandler(this.TextLostFocus);
        }
       /* #region "PlaceHolder con eventos"
        public void TextGotFocus(object sender, EventArgs e)
        {

            if (txtClaveUsuario.Text == "Escriba aquí la contraseña que se le designará al Usuario")
            {
                txtClaveUsuario.Text = "";
                txtClaveUsuario.ForeColor = Color.Black;
            }
        }

        public void TextLostFocus(object sender, EventArgs e)
        {

            if (txtClaveUsuario.Text == "")
            {
                txtClaveUsuario.Text = "Escriba aquí la contraseña que se le designará al Usuario";
                txtClaveUsuario.ForeColor = Color.LightGray;
            }
        }
        #endregion 
        */
        private void LimpiarUsuario()
        {
            txtClaveUsuario.Text = "";
            this.tiposUsuarioTableAdapter1.Fill(this.ges_v01DataSet18TiposUsuario.tiposUsuario);
            txtCodigoUsuario.Text = "";
            this.estadosTableAdapter.Fill(this.ges_v01DataSet18Estados.estados);
            txtNombreUsuario.Text = "";
            this.usuariosTableAdapter.Fill(this.ges_v01DataSet11.usuarios);
            busqueda = 0;
        }

        private void LimpiarDGVUsuarios()
        {
            txtClaveUsuario.Text = "";
            this.tiposUsuarioTableAdapter1.Fill(this.ges_v01DataSet18TiposUsuario.tiposUsuario);
            txtCodigoUsuario.Text = "";
            this.estadosTableAdapter.Fill(this.ges_v01DataSet18Estados.estados);
            txtNombreUsuario.Text = "";
            dgvUsuarios.DataSource = "";
        }
        private void BotonRegistrarUsuario_Click(object sender, EventArgs e)
        {
            SqlCommand alta = new SqlCommand("INSERT INTO usuarios VALUES (@codTipoUsu,@codEstado,@nomUsu,@claveUsu,@fechoraUltSesion)", conexion);
            adaptador.InsertCommand = alta;
            //adaptador.InsertCommand.Parameters.Add(new SqlParameter("@codUsu", SqlDbType.Int));
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@codTipoUsu", SqlDbType.Int));
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@codEstado", SqlDbType.Int));
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@nomUsu", SqlDbType.VarChar));
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@claveUsu", SqlDbType.VarChar));
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@fechoraUltSesion", SqlDbType.DateTime));

            //adaptador.InsertCommand.Parameters["@codUsu"].Value = Convert.ToInt32(txtCodigoUsuario.Text);
            adaptador.InsertCommand.Parameters["@codTipoUsu"].Value = cbCodTipoUsu.SelectedValue;
            adaptador.InsertCommand.Parameters["@codEstado"].Value = cbEstadoUsuario.SelectedValue;
            adaptador.InsertCommand.Parameters["@nomUsu"].Value = txtNombreUsuario.Text;
            adaptador.InsertCommand.Parameters["@claveUsu"].Value = txtClaveUsuario.Text;
            adaptador.InsertCommand.Parameters["@fechoraUltSesion"].Value = dateTimePicker1.Value;

            if (string.IsNullOrEmpty(cbCodTipoUsu.Text) || string.IsNullOrEmpty(txtNombreUsuario.Text) || string.IsNullOrEmpty(txtClaveUsuario.Text))

            {
                MessageBox.Show("Es obligatorio completar los campos: Nombre, Tipo y Clave para registrar el Usuario.", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {

                try
                {
                    conexion.Open();
                    SqlDataAdapter compCodigoUsuario = new SqlDataAdapter("SELECT codUsu FROM usuarios WHERE codUsu=@codUsu", conexion);
                    DataTable codUsuario = new DataTable();
                    compCodigoUsuario.SelectCommand.Parameters.Add(new SqlParameter("@codUsu", SqlDbType.VarChar));
                    compCodigoUsuario.SelectCommand.Parameters["@codUsu"].Value = txtCodigoUsuario.Text;
                    compCodigoUsuario.Fill(codUsuario);

                    if (codUsuario.Rows.Count > 0)
                    {
                        MessageBox.Show("El 'código' ingresado ya existe.", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    if (txtClaveUsuario.TextLength < 6 || txtClaveUsuario.TextLength > 16)
                    {
                        MessageBox.Show("Recuerde que la contraseña no puede tener menos de 6 caracteres ni mas de 16");
                    }

                    else if (MessageBox.Show("¿Está seguro que desea registrar este nuevo Usuario?.", "Atención!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {  
                        adaptador.InsertCommand.ExecuteNonQuery();
                        MessageBox.Show("Se ha registrado correctamente El Usuario.", "Operación Exitosa!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarUsuario();
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

        private void BotonConsultarUsuario_Click(object sender, EventArgs e)
        {
            /*SqlCommand consultar = new SqlCommand("SELECT * FROM usuarios WHERE codUsu=@codUsu", conexion);
            adaptador.SelectCommand = consultar;
            adaptador.SelectCommand.Parameters.Add(new SqlParameter("@codUsu", SqlDbType.Int));

            adaptador.SelectCommand.Parameters["@codUsu"].Value = txtCodigoUsuario.Text;

            if (string.IsNullOrEmpty(txtCodigoUsuario.Text))
            {
                MessageBox.Show("Es obligatorio completar el campo 'Código de Usuario' para buscar el Usuario a modificar", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {

                    conexion.Open();
                    adaptador.Fill(datos, "usuarios");
                    int registro = int.Parse(datos.Tables["usuarios"].Rows.Count.ToString());
                    if (registro >= 0)
                    {
                        foreach (DataRow fila in datos.Tables["usuarios"].Rows)
                        {
                            txtCodigoUsuario.Text = fila["codUsu"].ToString();
                            txtNombreUsuario.Text = fila["nomUsu"].ToString();
                            txtClaveUsuario.Text = fila["claveUsu"].ToString();
                            txtEstado.Text = fila["codEstado"].ToString();
                            txtCodigoTipoUsuario.Text = fila["codTipoUsu"].ToString();
                        }
                        busqueda = 1;
                    }
                    else
                    {
                        MessageBox.Show("El 'Código de Usuario' ingresado no existe en la base de datos.", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    SqlDataAdapter da = new SqlDataAdapter("select * from usuarios", conexion);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvUsuarios.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR:" + ex.ToString());
                }

                finally
                {
                    conexion.Close();
                }
            }*/
        }

        private void BotonModificarUsuario_Click(object sender, EventArgs e)
        {
            SqlCommand modificar = new SqlCommand("UPDATE usuarios SET codTipoUsu=@codTipoUsu, codEstado=@codEstado, nomUsu=@nomUsu, claveUsu=@claveUsu  WHERE codUsu=@codUsu", conexion);
            adaptador.UpdateCommand = modificar;

            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@codUsu", SqlDbType.Int));
            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@codTipoUsu", SqlDbType.Int));
            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@codEstado", SqlDbType.Int));
            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@nomUsu", SqlDbType.VarChar));
            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@claveUsu", SqlDbType.VarChar));

            adaptador.UpdateCommand.Parameters["@codUsu"].Value = txtCodigoUsuario.Text;
            adaptador.UpdateCommand.Parameters["@codTipoUsu"].Value = cbCodTipoUsu.SelectedValue;
            adaptador.UpdateCommand.Parameters["@codEstado"].Value = cbEstadoUsuario.SelectedValue;
            adaptador.UpdateCommand.Parameters["@nomUsu"].Value = txtNombreUsuario.Text;
            adaptador.UpdateCommand.Parameters["@claveUsu"].Value = txtClaveUsuario.Text;


            if (string.IsNullOrEmpty(txtCodigoUsuario.Text) || string.IsNullOrEmpty(txtNombreUsuario.Text) && busqueda == 0)
            {
                MessageBox.Show("Por seguridad de los datos, primero debe seleccionar el Usuario a modificar, recuerde que para ésto debe hacer 'Clic' sobre alguna celda del panel que represente al usuario. Por cualquier duda o consulta comuniquese con un Administrador", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    conexion.Open();
                    //adaptador.UpdateCommand.ExecuteNonQuery();
                    // MessageBox.Show("Se ha modificado correctamente el Usuario", "Operación Exitosa!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //LimpiarUsuario();
                    if (MessageBox.Show("¿Está seguro que desea modificar al usuario seleccionado: " + txtCodigoUsuario.Text + "?", "Atención!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        MessageBox.Show("El Usuario: " + txtCodigoUsuario.Text + " - " + txtNombreUsuario.Text + ", fue modificado correctamente.", "Operación Exitosa!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarUsuario();
                        adaptador.UpdateCommand.ExecuteNonQuery();
                    }
                    //else
                    //MessageBox.Show("Se ha modificado correctamente el Usuario", "Operación Exitosa!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //LimpiarUsuario();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR:" + ex.ToString());
                }
                finally
                {
                    conexion.Close();
                }
                SqlDataAdapter da = new SqlDataAdapter("select * from usuarios", conexion);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvUsuarios.DataSource = dt;
            }
        }

        private void BotonLimpiarSeleccion_Click(object sender, EventArgs e)
        {
            LimpiarUsuario();
            LimpiarDGVUsuarios();
        }

        private void BotonEliminarUsuario_Click(object sender, EventArgs e)
        {
            SqlCommand baja = new SqlCommand("DELETE FROM usuarios WHERE codUsu=@codUsu", conexion);
            adaptador.DeleteCommand = baja;
            adaptador.DeleteCommand.Parameters.Add(new SqlParameter("@codUsu", SqlDbType.Int));

            adaptador.DeleteCommand.Parameters["@codUsu"].Value = txtCodigoUsuario.Text;

            if (string.IsNullOrEmpty(txtCodigoUsuario.Text) || string.IsNullOrEmpty(txtNombreUsuario.Text) && busqueda == 0)
            {
                MessageBox.Show("Primero debe seleccionar el Usuario a eliminar, recuerde que debe posicionarse y hacer 'Clic' sobre una celda del panel para seleccionar el Usuario a eliminar", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {

                    conexion.Open();
                    
                    /*if (cantidad == 0)
                    {
                        MessageBox.Show("El 'Código' ingresado no existe en la base de datos.", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }*/
                    if (MessageBox.Show("¿Está seguro que desea eliminar al usuario seleccionado: " + txtNombreUsuario.Text +"?", "Atención!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        MessageBox.Show("El Usuario: " + txtCodigoUsuario.Text + " - " + txtNombreUsuario.Text + ", fue eliminado correctamente.", "Operación Exitosa!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarUsuario();
                        int cantidad = adaptador.DeleteCommand.ExecuteNonQuery();
                    }

                    SqlDataAdapter da = new SqlDataAdapter("select * from usuarios", conexion);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvUsuarios.DataSource = dt;
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

        private void BotonVerUsuarios_Click(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from usuarios", conexion);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvUsuarios.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron cargar los datos en el Panel: " + ex.ToString());
            }
        }

        private void TxtClaveUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void DgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                posicion = dgvUsuarios.CurrentRow.Index;

                txtCodigoUsuario.Text = dgvUsuarios[1, posicion].Value.ToString();
                //txtCodigoTipoUsuario.Text = dgvUsuarios[1, posicion].Value.ToString();
                cbCodTipoUsu.SelectedValue = dgvUsuarios[4, posicion].Value;
                cbEstadoUsuario.SelectedValue = dgvUsuarios[3, posicion].Value;
                txtNombreUsuario.Text = dgvUsuarios[0, posicion].Value.ToString();
                txtClaveUsuario.Text = dgvUsuarios[2, posicion].Value.ToString();
                /**
                if (cbCodTipoUsu.Text == "1") 
                {
                    cbCodTipoUsu.Text = "Administrador";
                }
                if (cbCodTipoUsu.Text == "2")
                {
                    cbCodTipoUsu.Text = "Encargado DE&MS";
                }
                if (cbCodTipoUsu.Text == "3")
                {
                    cbCodTipoUsu.Text = "Responsable Analista";
                }
                **/
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Usuarios_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Minimized;
            }
            else if (WindowState == FormWindowState.Minimized)
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void panel1_MouseDown_1(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void txtClaveUsuario_MouseDown(object sender, MouseEventArgs e)
        {
            if (string.IsNullOrEmpty (txtClaveUsuario.Text))
            {
                MessageBox.Show("La contraseña que se establezca debe contener entre 6 y 16 caracteres.");
            }
                
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            this.WindowState = FormWindowState.Minimized;

        }

        private void btn_Salir_Click_1(object sender, EventArgs e)
        {
            this.Dispose();

        }
    }
}
