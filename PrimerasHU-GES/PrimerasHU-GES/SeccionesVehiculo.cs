using System;
using System.Activities.Expressions;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace PrimerasHU_GES
{
    public partial class SeccionesVehiculo : Form
    {
        /* #region DLLs para poder mover el form
         [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
         private extern static void ReleaseCapture();

         [DllImport("user32.DLL", EntryPoint = "SendMessage")]
         private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        // Rectangle SizeGripRectangle();
         bool inSizeDrag = false;
         const int GRIP_SIZE = 15;

         int w = 0;
         int h = 0;
         #endregion
         */

        #region DLLs para poder mover el form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        #endregion

        public SeccionesVehiculo()
        {
            InitializeComponent();
        }
        private SqlConnection conexion;
        private SqlDataAdapter adaptador;
        private DataSet datos;
        //private SqlDataReader leer;
        //private SqlCommand comando;

        int busqueda = 0;
        int posicion = 0;
        //SoundPlayer sonidoCierrePrograma;

        private void SeccionesVehiculo_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'ges_v01DataSet22NuevoProyecto.modelosVehiculo' Puede moverla o quitarla según sea necesario.
            this.modelosVehiculoTableAdapter1.Fill(this.ges_v01DataSet22NuevoProyecto.modelosVehiculo);
            // TODO: esta línea de código carga datos en la tabla 'ges_v01DataSet6.modelosVehiculo' Puede moverla o quitarla según sea necesario.
            this.modelosVehiculoTableAdapter.Fill(this.ges_v01DataSet6.modelosVehiculo);
            // TODO: esta línea de código carga datos en la tabla 'ges_v01DataSet2.seccionesVehiculo' Puede moverla o quitarla según sea necesario.
            this.seccionesVehiculoTableAdapter.Fill(this.ges_v01DataSet2.seccionesVehiculo);

            conexion = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=ges_v01;Integrated Security=True");
            adaptador = new SqlDataAdapter();
            datos = new DataSet();
            //leer = new SqlDataReader();
            //comando = new SqlCommand();
            //txtDescSec.AutoCompleteCustomSource = AutoCompletar();
            //AutoCompletar(txtDescSec);

            ////txtDescSec.AutoCompleteCustomSource = AutoCompletar();
            ////txtDescSec.AutoCompleteMode = AutoCompleteMode.Suggest;
            ////txtDescSec.AutoCompleteSource = AutoCompleteSource.CustomSource;

            //cargar los datos para el autocomplete del textbox
            txtDescSec.AutoCompleteCustomSource = AutoCompletar.Autocomplete();
            txtDescSec.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtDescSec.AutoCompleteSource = AutoCompleteSource.CustomSource;

            // Cargo los datos que tendra el combobox
            /*cbCodProyecto.DataSource = AutoCompletar.Datos();
            cbCodProyecto.DisplayMember = "codProyecto";
            cbCodProyecto.ValueMember = "codProyecto";

            // cargo la lista de items para el autocomplete del combobox
            cbCodProyecto.AutoCompleteCustomSource = AutoCompletar.Autocomplete();
            cbCodProyecto.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbCodProyecto.AutoCompleteSource = AutoCompleteSource.CustomSource;*/
        }

        private void LimpiarDG()
        {
            txtCodSec.Text = "";
            this.modelosVehiculoTableAdapter1.Fill(this.ges_v01DataSet22NuevoProyecto.modelosVehiculo);
            txtDescSec.Text = "";
            txtVerSec.Text = "";
            dgvSeccionesVehiculo.DataSource = "";

        }



        private void Limpiar()
        {
            txtCodSec.Text = "";
            this.modelosVehiculoTableAdapter1.Fill(this.ges_v01DataSet22NuevoProyecto.modelosVehiculo);
            txtDescSec.Text = "";
            txtVerSec.Text = "";
            this.seccionesVehiculoTableAdapter.Fill(this.ges_v01DataSet2.seccionesVehiculo);
            busqueda = 0;
        }

        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            this.Dispose();
            /* PrimeraPantalla primeraPantalla = new PrimeraPantalla();
            primeraPantalla.Show();
            this.Dispose(); */

            /* if (MessageBox.Show("¿Está seguro que desea salir de 'Secciones de Vehiculo' y dirigirse a la Pantalla Principal? " +
                 "Presione 'Aceptar' para dirigirse a la Pantalla Principal.", "Atención!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
             {
                 //PrimeraPantalla primeraPantalla = new PrimeraPantalla();
                 //primeraPantalla.Show();
                 this.Dispose();

             }
             else 

                     if (MessageBox.Show("¿Desea salir del Sistema GES? Si presiona 'NO' usted quedara sobre 'Secciones de Vehiculo'.", "Atención!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                     {
                         //sonidoCierrePrograma = new SoundPlayer(Application.StartupPath + @"RUTA");
                         this.Dispose();
                     }*/
        }

        private void BtnRegCodSec_Click_1(object sender, EventArgs e)
        {
            SqlCommand alta = new SqlCommand("INSERT INTO seccionesVehiculo (codProyecto,descSeccion,verSeccion) VALUES (@codProyecto,@descSeccion,@verSeccion)", conexion);

            adaptador.InsertCommand = alta;
            //adaptador.InsertCommand.Parameters.Add(new SqlParameter("@codSeccion", SqlDbType.VarChar));
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@codProyecto", SqlDbType.Int));
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@descSeccion", SqlDbType.VarChar));
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@verSeccion", SqlDbType.Int));


            if /*(string.IsNullOrEmpty(txtCodSec.Text) || */ (string.IsNullOrEmpty(cbCodProyecto.Text) || string.IsNullOrEmpty(txtDescSec.Text) || string.IsNullOrEmpty(txtVerSec.Text))
            // if(txtVerSec.Text.Trim() == "")
            {
                MessageBox.Show("Es obligatorio completar todos los campos.", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                //adaptador.InsertCommand.Parameters["@codSeccion"].Value = txtCodSec.Text;
                adaptador.InsertCommand.Parameters["@codProyecto"].Value = cbCodProyecto.SelectedValue;
                adaptador.InsertCommand.Parameters["@descSeccion"].Value = txtDescSec.Text;
                adaptador.InsertCommand.Parameters["@verSeccion"].Value = Convert.ToInt32(txtVerSec.Text);

                try
                {
                    conexion.Open();

                    SqlDataAdapter compCodSec = new SqlDataAdapter("SELECT descSeccion FROM seccionesVehiculo WHERE descSeccion=@descSeccion", conexion);
                    DataTable codV = new DataTable();
                    compCodSec.SelectCommand.Parameters.Add(new SqlParameter("@descSeccion", SqlDbType.VarChar));
                    compCodSec.SelectCommand.Parameters["@descSeccion"].Value = txtDescSec.Text;
                    compCodSec.Fill(codV);


                    if (codV.Rows.Count > 0)
                    {
                        MessageBox.Show("La descripción de 'sección' ingresada ya existe.", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    if (MessageBox.Show("¿Está seguro que desea registrar esta nueva Seccion?", "Atención!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        adaptador.InsertCommand.ExecuteNonQuery();
                        MessageBox.Show("Se ha registrado correctamente la nueva Seccion.", "Operación Exitosa!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void BtnLimpiar_Click_1(object sender, EventArgs e)
        {
            Limpiar();
            LimpiarDG();
        }

        private void BtnModSecVeh_Click_1(object sender, EventArgs e)
        {
            SqlCommand modificar = new SqlCommand("UPDATE seccionesVehiculo SET descSeccion=@descSeccion, verSeccion=@verSeccion WHERE codSeccion=@codSeccion", conexion);
            adaptador.UpdateCommand = modificar;

            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@codSeccion", SqlDbType.VarChar));
            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@codProyecto", SqlDbType.VarChar));
            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@descSeccion", SqlDbType.VarChar));
            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@verSeccion", SqlDbType.VarChar));

            adaptador.UpdateCommand.Parameters["@codSeccion"].Value = txtCodSec.Text;
            adaptador.UpdateCommand.Parameters["@codProyecto"].Value = cbCodProyecto.Text;
            adaptador.UpdateCommand.Parameters["@descSeccion"].Value = txtDescSec.Text;
            adaptador.UpdateCommand.Parameters["@verSeccion"].Value = txtVerSec.Text;

            if (string.IsNullOrEmpty(txtCodSec.Text) || string.IsNullOrEmpty(cbCodProyecto.Text) || string.IsNullOrEmpty(txtDescSec.Text) || string.IsNullOrEmpty(txtVerSec.Text) && busqueda == 0)
            {
                MessageBox.Show("Por seguridad de los datos, primero debe seleccionar la Seccion a modificar, recuerde que para ésto debe hacer 'Clic' sobre alguna celda del panel que represente a la Seccion. Por cualquier duda o consulta comuniquese con un Administrador", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    conexion.Open();
                    if (MessageBox.Show("¿Está seguro que desea modificar la Seccion seleccionada: " + txtCodSec.Text + "?", "Atención!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        MessageBox.Show("La Seccion: " + txtCodSec.Text + ", fue modificada correctamente.", "Operación Exitosa!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Limpiar();
                        adaptador.UpdateCommand.ExecuteNonQuery();
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
                SqlDataAdapter da = new SqlDataAdapter("select * from seccionesVehiculo", conexion);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvSeccionesVehiculo.DataSource = dt;
            }
        }

        private void BtnConsultar_Click_1(object sender, EventArgs e)
        {
            /*
             SqlCommand consultar = new SqlCommand("SELECT * FROM seccionesVehiculo WHERE codSeccion=@codSeccion", conexion);
             adaptador.SelectCommand = consultar;
             adaptador.SelectCommand.Parameters.Add(new SqlParameter("@codSeccion", SqlDbType.VarChar));
 
            adaptador.SelectCommand.Parameters["@codSeccion"].Value = txtCodSec.Text;

             if (string.IsNullOrEmpty(txtCodSec.Text))
             {
                 MessageBox.Show("Es obligatorio completar el campo 'Código seccion' para buscar la seccion a modificar", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
             }
             else
             {
                 try
                 {

                     conexion.Open();
                     adaptador.Fill(datos, "seccionesVehiculo");
                     int registro = int.Parse(datos.Tables["seccionesVehiculo"].Rows.Count.ToString());
                     if (registro >= 0)
                     {
                         foreach (DataRow fila in datos.Tables["seccionesVehiculo"].Rows)
                         {
                             txtCodSec.Text = fila["codSeccion"].ToString();
                             cbCodProyecto.Text = fila["codProyecto"].ToString();
                             txtDescSec.Text = fila["descSeccion"].ToString();
                             txtVerSec.Text = fila["verSeccion"].ToString();
                        }
                         busqueda = 1;
                     }
                     else
                     {
                         MessageBox.Show("El 'Código' ingresado no existe en la base de datos.", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                     }
                    SqlDataAdapter da = new SqlDataAdapter("select * from seccionesVehiculo", conexion);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvSeccionesVehiculo.DataSource = dt;
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

        private void BtnEliminar_Click_1(object sender, EventArgs e)
        {
            SqlCommand baja = new SqlCommand("DELETE FROM seccionesVehiculo WHERE codSeccion=@codSeccion", conexion);
            adaptador.DeleteCommand = baja;
            adaptador.DeleteCommand.Parameters.Add(new SqlParameter("@codSeccion", SqlDbType.VarChar));

            adaptador.DeleteCommand.Parameters["@codSeccion"].Value = txtCodSec.Text;

            if (string.IsNullOrEmpty(txtCodSec.Text))
            {
                MessageBox.Show("Primero debe seleccionar la Seccion a eliminar, recuerde que debe posicionarse y hacer 'Clic' sobre una celda del panel para seleccionar la Seccion a eliminar", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {

                    conexion.Open();
                    /*int cantidad = adaptador.DeleteCommand.ExecuteNonQuery();
                    if (cantidad == 0)
                    {
                        MessageBox.Show("El 'Código' ingresado no existe en la base de datos.", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        MessageBox.Show("La seccion: " + txtCodSec.Text + ", fue eliminada correctamente.", "Operación Exitosa!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Limpiar();
                    }*/
                    if (MessageBox.Show("¿Está seguro que desea eliminar la Seccion seleccionada: " + txtCodSec.Text + "?", "Atención!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        MessageBox.Show("La Seccion: " + txtCodSec.Text + ", fue eliminada correctamente.", "Operación Exitosa!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Limpiar();
                        int cantidad = adaptador.DeleteCommand.ExecuteNonQuery();
                    }

                    SqlDataAdapter da = new SqlDataAdapter("select * from seccionesVehiculo", conexion);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvSeccionesVehiculo.DataSource = dt;
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

        private void BtnVerTod_Click(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from seccionesVehiculo", conexion);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvSeccionesVehiculo.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron cargar los datos en el DataGridView: " + ex.ToString());
            }

        }


        private void TxtDescSec_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarLetraNumero.SoloLetras(e);
        }

        private void TxtCodSec_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarAutoincrementable.Autoincrementable(e);
        }

        private void TxtVerSec_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarLetraNumero.SoloNumeros(e);
        }

        private void DgvSeccionesVehiculo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                posicion = dgvSeccionesVehiculo.CurrentRow.Index;

                txtCodSec.Text = dgvSeccionesVehiculo[0, posicion].Value.ToString();
                cbCodProyecto.Text = dgvSeccionesVehiculo[1, posicion].Value.ToString();
                txtDescSec.Text = dgvSeccionesVehiculo[2, posicion].Value.ToString();
                txtVerSec.Text = dgvSeccionesVehiculo[3, posicion].Value.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
        }

      /*  private void Button1_Click(object sender, EventArgs e)
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
        */
        private void SeccionesVehiculo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void button2_Click(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {

            this.WindowState = FormWindowState.Minimized;

        }

        private void btn_Salir_Click_1(object sender, EventArgs e)
        {
            this.Dispose();

        }

        //private void TxtVerSec_Validated(object sender, EventArgs e)
        //{
        //    if (txtVerSec.Text.Trim() == "")
        //    {
        //        errorProviderVerSec.SetError(txtVerSec, "Debe Ingresar una version de sección");
        //        txtVerSec.Focus();
        //    }
        //    else
        //        errorProviderCodSeccion.Clear();
        //}



        //private void TxtCodSec_Validated(object sender, EventArgs e)
        //{
        //    if (txtCodSec.Text.Trim() == "" && txtCodSec.Text.Trim() == " ")
        //    {
        //        errorProviderCodSeccion.SetError(txtCodSec, "Debe Ingresar ..");
        //        txtCodSec.Focus();
        //    }
        //    else
        //        errorProviderCodSeccion.Clear();
        //}


        ////private AutoCompleteStringCollection AutoCompletar()
        ////{
        ////    AutoCompleteStringCollection datosAutoCompletar = new AutoCompleteStringCollection();

        ////    datosAutoCompletar.Add("CS SCOCCA");

        ////    return datosAutoCompletar;
        ////}


        //public void AutoCompletar()
        //{
        //    conexion.Open();
        //    AutoCompleteStringCollection namesCollection = new AutoCompleteStringCollection();
        //    string consulta = @"Select distinct [descSeccion] from [seccionesVehiculo]";

        //    SqlCommand comando = new SqlCommand(consulta, conexion);
        //    SqlDataReader leer = comando.ExecuteReader();

        //    if (leer.HasRows == true) 
        //    {
        //        while (leer.Read())
        //            namesCollection.Add(leer["descSeccion"].ToString());

        //    }

        //    leer.Close();
        //    conexion.Close();

        //    txtDescSec.AutoCompleteMode = AutoCompleteMode.Append;
        //    txtDescSec.AutoCompleteSource = AutoCompleteSource.CustomSource;
        //    txtDescSec.AutoCompleteCustomSource = namesCollection;
        //}



        //public void AutoCompletar(TextBox tb)
        //{
        //    try
        //    {
        //        conexion.Open();

        //        comando = new SqlCommand("SELECT descSeccion FROM seccionesVehiculo", conexion);
        //        leer = comando.ExecuteReader();

        //        while (leer.Read())
        //        {
        //            tb.AutoCompleteCustomSource.Add(leer["descSeccion"].ToString());
        //        }
        //        leer.Close();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("No se logró autocompletar el campo. Digitelo manualmente."+ex.ToString());

        //    }
        //    finally
        //    {
        //        conexion.Close();
        //    }
        //}

        //private void TxtDescSec_KeyUp(object sender, KeyEventArgs e)
        //{
        //    AutoCompletar();
        //}

    }
}