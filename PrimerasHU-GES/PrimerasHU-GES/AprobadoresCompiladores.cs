using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimerasHU_GES
{
    public partial class AprobadoresCompiladores : Form
    {
        #region DLLs para poder mover el form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        #endregion

        public AprobadoresCompiladores()
        {
            InitializeComponent();
        }

        private SqlConnection Conexion;
        private SqlDataAdapter Adaptador;
        private DataSet Datos;

        int busqueda = 0;
        int posicion = 0;

        private void AprobadoresCompiladores_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'ges_v01DataSet18Operarios.operariosMaquina' Puede moverla o quitarla según sea necesario.
            this.operariosMaquinaTableAdapter.Fill(this.ges_v01DataSet18Operarios.operariosMaquina);
            // TODO: esta línea de código carga datos en la tabla 'ges_v01DataSet10.aprobadores' Puede moverla o quitarla según sea necesario.
            this.aprobadoresTableAdapter.Fill(this.ges_v01DataSet10.aprobadores);
            // TODO: esta línea de código carga datos en la tabla 'ges_v01DataSet9.compiladores' Puede moverla o quitarla según sea necesario.
            this.compiladoresTableAdapter.Fill(this.ges_v01DataSet9.compiladores);

            Conexion = new SqlConnection("Data source=.\\SQLEXPRESS; Initial Catalog = ges_v01; Integrated Security = True");
            Adaptador = new SqlDataAdapter();
            Datos = new DataSet();
        }
        private void LimpiarCompilador()
        {
            txtCodigoAprobador.Text = "";
            txtNombreAprobador.Text = "";
            this.compiladoresTableAdapter.Fill(this.ges_v01DataSet9.compiladores);
            busqueda = 0;
        }
        private void LimpiarAprobador()
        {
            txtCodigoAprobador.Text = "";
            txtNombreAprobador.Text = "";
            this.aprobadoresTableAdapter.Fill(this.ges_v01DataSet10.aprobadores);
            busqueda = 0;
        }
        private void LimpiarDGCompiladores()
        {
            txtCodigoCompilador.Text = "";
            txtNombreCompilador.Text = "";
            dgvCompiladores.DataSource = "";
        }
        private void LimpiarDGAprobadores()
        {
            txtCodigoAprobador.Text = "";
            txtNombreAprobador.Text = "";
            dgvAprobadores.DataSource = "";
        }
        private void LimpiarOperario()
        {
            txtCodigoOperario.Text = "";
            txtNombreOperario.Text = "";
            //this.operariosMaquinaTableAdapter.Fill(this.ges_v01DataSet8.operariosMaquina);
            this.operariosMaquinaTableAdapter.Fill(this.ges_v01DataSet18Operarios.operariosMaquina);
            busqueda = 0;
        }

        private void LimpiarDGVOperarios()
        {
            txtCodigoOperario.Text = "";
            txtNombreOperario.Text = "";
            dgvOperarios.DataSource = "";
        }

        
        private void BtnRegCompilador_Click(object sender, EventArgs e)
        {
            SqlCommand alta = new SqlCommand("INSERT INTO compiladores (nomCompilador) VALUES (@nomCompilador)", Conexion);

            Adaptador.InsertCommand = alta;
            Adaptador.InsertCommand.Parameters.Add(new SqlParameter("@codCompilador", SqlDbType.VarChar));
            Adaptador.InsertCommand.Parameters.Add(new SqlParameter("@nomCompilador", SqlDbType.VarChar));

            Adaptador.InsertCommand.Parameters["@codCompilador"].Value = txtCodigoCompilador.Text;
            Adaptador.InsertCommand.Parameters["@nomCompilador"].Value = txtNombreCompilador.Text;

            if (string.IsNullOrEmpty(txtNombreCompilador.Text))

            {
                MessageBox.Show("Es obligatorio completar el Nombre del Compilador.", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    Conexion.Open();
                    SqlDataAdapter compCodCompilador = new SqlDataAdapter("SELECT codCompilador FROM compiladores WHERE codCompilador=@codCompilador", Conexion);
                    DataTable codComp = new DataTable();
                    compCodCompilador.SelectCommand.Parameters.Add(new SqlParameter("@codCompilador", SqlDbType.VarChar));
                    compCodCompilador.SelectCommand.Parameters["@codCompilador"].Value = txtCodigoCompilador.Text;
                    compCodCompilador.Fill(codComp);

                    if (codComp.Rows.Count > 0)
                    {
                        MessageBox.Show("El 'código' ingresado ya existe.", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    if (MessageBox.Show("¿Está seguro que desea registrar este nuevo Compilador?", "Atención!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        Adaptador.InsertCommand.ExecuteNonQuery();
                        MessageBox.Show("Se ha registrado correctamente el nuevo Compilador.", "Operación Exitosa!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarCompilador();
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

        private void BtnConsultarCompilador_Click(object sender, EventArgs e)
        {
            /*SqlCommand consultar = new SqlCommand("SELECT * FROM compiladores WHERE codCompilador=@codCompilador", Conexion);
            Adaptador.SelectCommand = consultar;
            Adaptador.SelectCommand.Parameters.Add(new SqlParameter("@codCompilador", SqlDbType.VarChar));

            Adaptador.SelectCommand.Parameters["@codCompilador"].Value = txtCodigoCompilador.Text;

            if (string.IsNullOrEmpty(txtCodigoCompilador.Text))
            {
                MessageBox.Show("Es obligatorio completar el campo 'Código de Compilador' para Consultar.", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {

                    Conexion.Open();
                    Adaptador.Fill(Datos, "compiladores");
                    int registro = int.Parse(Datos.Tables["compiladores"].Rows.Count.ToString());
                    if (registro >= 0)
                    {
                        foreach (DataRow fila in Datos.Tables["compiladores"].Rows)
                        {
                            txtCodigoCompilador.Text = fila["codCompilador"].ToString();
                            txtNombreCompilador.Text = fila["nomCompilador"].ToString();
                        }
                        busqueda = 1;
                    }
                    else
                    {
                        MessageBox.Show("El 'Código de Compilador' ingresado no existe en la base de datos.", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    SqlDataAdapter da = new SqlDataAdapter("select * from compiladores", Conexion);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvCompiladores.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR:" + ex.ToString());
                }

                finally
                {
                    Conexion.Close();
                }
            }*/
        }

        private void BtnModCompilador_Click(object sender, EventArgs e)
        {
            SqlCommand modificar = new SqlCommand("UPDATE compiladores SET nomCompilador=@nomCompilador WHERE codCompilador=@codCompilador", Conexion);
            Adaptador.UpdateCommand = modificar;

            Adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@codCompilador", SqlDbType.VarChar));
            Adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@nomCompilador", SqlDbType.VarChar));

            Adaptador.UpdateCommand.Parameters["@codCompilador"].Value = txtCodigoCompilador.Text;
            Adaptador.UpdateCommand.Parameters["@nomCompilador"].Value = txtNombreCompilador.Text;

            if (string.IsNullOrEmpty(txtCodigoCompilador.Text) || string.IsNullOrEmpty(txtNombreCompilador.Text) && busqueda == 0)
            {
                MessageBox.Show("Por seguridad de los datos, primero debe seleccionar el Compilador a modificar, recuerde que para ésto debe hacer 'Clic' sobre alguna celda del panel que represente al Compilador. Por cualquier duda o consulta comuniquese con un Administrador", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    Conexion.Open();
                    /*Adaptador.UpdateCommand.ExecuteNonQuery();
                    MessageBox.Show("Se ha modificado correctamente el nombre del Compilador", "Operación Exitosa!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCompilador();
                    */
                    if (MessageBox.Show("¿Está seguro que desea modificar el Compilador seleccionado: " + txtCodigoCompilador.Text + "?", "Atención!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        MessageBox.Show("El Compilador: " + txtCodigoCompilador.Text + " - " + txtNombreCompilador.Text + ", fue modificado correctamente.", "Operación Exitosa!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarCompilador();
                        Adaptador.UpdateCommand.ExecuteNonQuery();
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
                SqlDataAdapter da = new SqlDataAdapter("select * from compiladores", Conexion);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvCompiladores.DataSource = dt;
            }
        }

        private void BtnLimpiarCompilador_Click(object sender, EventArgs e)
        {
            LimpiarCompilador();
            LimpiarDGCompiladores();
        }

        private void BtnEliminarCompilador_Click(object sender, EventArgs e)
        {
            SqlCommand baja = new SqlCommand("DELETE FROM compiladores WHERE codCompilador=@codCompilador", Conexion);
            Adaptador.DeleteCommand = baja;
            Adaptador.DeleteCommand.Parameters.Add(new SqlParameter("@codCompilador", SqlDbType.VarChar));

            Adaptador.DeleteCommand.Parameters["@codCompilador"].Value = txtCodigoCompilador.Text;

            if (string.IsNullOrEmpty(txtCodigoCompilador.Text) || string.IsNullOrEmpty(txtNombreCompilador.Text) && busqueda == 0)
            {
                MessageBox.Show("Primero debe seleccionar el Compilador a eliminar, recuerde que debe posicionarse y hacer 'Clic' sobre una celda del panel para seleccionar el Compilador a eliminar", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {

                    Conexion.Open();
                    
                    /*int cantidad = Adaptador.DeleteCommand.ExecuteNonQuery();
                    if (cantidad == 0)
                    {
                        MessageBox.Show("El 'Código' ingresado no existe en la base de datos.", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else*/
                        if(MessageBox.Show("¿Está seguro que desea eliminar al Compilador seleccionado: " + txtNombreCompilador.Text + "?", "Atención!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        MessageBox.Show("El compilador: " + txtCodigoCompilador.Text + ", fue eliminado correctamente.", "Operación Exitosa!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarCompilador();
                        int cantidad = Adaptador.DeleteCommand.ExecuteNonQuery();
                    }
                    
                    SqlDataAdapter da = new SqlDataAdapter("select * from compiladores", Conexion);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvCompiladores.DataSource = dt;
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

        private void BotonVerCompiladores_Click(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from compiladores", Conexion);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvCompiladores.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron cargar los datos en el Panel: " + ex.ToString());
            }
        }

        private void BtnRegAprobador_Click(object sender, EventArgs e)
        {
            SqlCommand alta = new SqlCommand("INSERT INTO aprobadores (nomAprobador) VALUES (@nomAprobador)", Conexion);

            Adaptador.InsertCommand = alta;
            Adaptador.InsertCommand.Parameters.Add(new SqlParameter("@codAprobador", SqlDbType.VarChar));
            Adaptador.InsertCommand.Parameters.Add(new SqlParameter("@nomAprobador", SqlDbType.VarChar));

            Adaptador.InsertCommand.Parameters["@codAprobador"].Value = txtCodigoAprobador.Text;
            Adaptador.InsertCommand.Parameters["@nomAprobador"].Value = txtNombreAprobador.Text;


            if (string.IsNullOrEmpty(txtNombreAprobador.Text))
            {
                MessageBox.Show("Es obligatorio completar el Nombre del Aprobador.", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    Conexion.Open();
                    SqlDataAdapter compCodAprobador = new SqlDataAdapter("SELECT codAprobador FROM aprobadores WHERE codAprobador=@codAprobador", Conexion);
                    DataTable codApro = new DataTable();
                    compCodAprobador.SelectCommand.Parameters.Add(new SqlParameter("@codAprobador", SqlDbType.VarChar));
                    compCodAprobador.SelectCommand.Parameters["@codAprobador"].Value = txtCodigoAprobador.Text;
                    compCodAprobador.Fill(codApro);

                    if (codApro.Rows.Count > 0)
                    {
                        MessageBox.Show("El 'código' ingresado ya existe.", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    if (MessageBox.Show("¿Está seguro que desea registrar este nuevo Aprobador?.", "Atención!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        Adaptador.InsertCommand.ExecuteNonQuery();
                        MessageBox.Show("Se ha registrado correctamente el nuevo Aprobador.", "Operación Exitosa!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarAprobador();
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

        private void BtnConsultarAprobador_Click(object sender, EventArgs e)
        {
            /*SqlCommand consultar = new SqlCommand("SELECT * FROM aprobadores WHERE codAprobador=@codAprobador", Conexion);
            Adaptador.SelectCommand = consultar;
            Adaptador.SelectCommand.Parameters.Add(new SqlParameter("@codAprobador", SqlDbType.VarChar));

            Adaptador.SelectCommand.Parameters["@codAprobador"].Value = txtCodigoAprobador.Text;

            if (string.IsNullOrEmpty(txtCodigoAprobador.Text))
            {
                MessageBox.Show("Es obligatorio completar el campo 'Código de Aprobador' para buscar el Aprobador.", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {

                    Conexion.Open();
                    Adaptador.Fill(Datos, "aprobadores");
                    int registro = int.Parse(Datos.Tables["aprobadores"].Rows.Count.ToString());
                    if (registro >= 0)
                    {
                        foreach (DataRow fila in Datos.Tables["aprobadores"].Rows)
                        {
                            txtCodigoAprobador.Text = fila["codAprobador"].ToString();
                            txtNombreAprobador.Text = fila["nomAprobador"].ToString();
                        }
                        busqueda = 1;
                    }
                    else
                    {
                        MessageBox.Show("El 'Código de Aprobador' ingresado no existe en la base de datos.", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    SqlDataAdapter da = new SqlDataAdapter("select * from aprobadores", Conexion);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvAprobadores.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR:" + ex.ToString());
                }

                finally
                {
                    Conexion.Close();
                }
            }*/
        }

        private void BtnModAprobador_Click(object sender, EventArgs e)
        {
            SqlCommand modificar = new SqlCommand("UPDATE aprobadores SET nomAprobador=@nomAprobador WHERE codAprobador=@codAprobador", Conexion);
            Adaptador.UpdateCommand = modificar;

            Adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@codAprobador", SqlDbType.VarChar));
            Adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@nomAprobador", SqlDbType.VarChar));

            Adaptador.UpdateCommand.Parameters["@codAprobador"].Value = txtCodigoAprobador.Text;
            Adaptador.UpdateCommand.Parameters["@nomAprobador"].Value = txtNombreAprobador.Text;

            if (string.IsNullOrEmpty(txtCodigoAprobador.Text) || string.IsNullOrEmpty(txtNombreAprobador.Text) && busqueda == 0)
            {
                MessageBox.Show("Por seguridad de los datos, primero debe seleccionar el Aprobador a modificar, recuerde que para ésto debe hacer 'Clic' sobre alguna celda del panel que represente al Aprobador. Por cualquier duda o consulta comuniquese con un Administrador", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    Conexion.Open();
                    /*Adaptador.UpdateCommand.ExecuteNonQuery();
                    MessageBox.Show("Se ha modificado correctamente el nombre del Aprobador", "Operación Exitosa!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarAprobador();*/

                    if (MessageBox.Show("¿Está seguro que desea modificar el Aprobador seleccionado: " + txtCodigoAprobador.Text + "?", "Atención!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        MessageBox.Show("El Aprobador: " + txtCodigoAprobador.Text + " - " + txtNombreAprobador.Text + ", fue modificado correctamente.", "Operación Exitosa!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarAprobador();
                        Adaptador.UpdateCommand.ExecuteNonQuery();
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
                SqlDataAdapter da = new SqlDataAdapter("select * from aprobadores", Conexion);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvAprobadores.DataSource = dt;
            }
        }

        private void BtnLimpiarAprobador_Click(object sender, EventArgs e)
        {
            LimpiarAprobador();
            LimpiarDGAprobadores();
        }

        private void BtnEliminarAprobador_Click(object sender, EventArgs e)
        {
            SqlCommand baja = new SqlCommand("DELETE FROM aprobadores WHERE codAprobador=@codAprobador", Conexion);
            Adaptador.DeleteCommand = baja;
            Adaptador.DeleteCommand.Parameters.Add(new SqlParameter("@codAprobador", SqlDbType.VarChar));

            Adaptador.DeleteCommand.Parameters["@codAprobador"].Value = txtCodigoAprobador.Text;

            if (string.IsNullOrEmpty(txtCodigoAprobador.Text) || string.IsNullOrEmpty(txtNombreAprobador.Text) && busqueda == 0)
            {
                MessageBox.Show("Primero debe seleccionar el Aprobador a eliminar, recuerde que debe posicionarse y hacer 'Clic' sobre una celda del panel para seleccionar el Aprobador a eliminar", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {

                    Conexion.Open();
                    if (MessageBox.Show("¿Está seguro que desea eliminar al Aprobador seleccionado: " + txtNombreAprobador.Text + "?", "Atención!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        MessageBox.Show("El Aprobador: " + txtCodigoAprobador.Text + ", fue eliminado correctamente.", "Operación Exitosa!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarAprobador();
                        int cantidad = Adaptador.DeleteCommand.ExecuteNonQuery();
                    }
                    /*int cantidad = Adaptador.DeleteCommand.ExecuteNonQuery();
                    if (cantidad == 0)
                    {
                        MessageBox.Show("El 'Código' ingresado no existe en la base de datos.", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        MessageBox.Show("El Aprobador: " + txtCodigoAprobador.Text + ", fue eliminado correctamente.", "Operación Exitosa!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarAprobador();
                    }
                    */
                    SqlDataAdapter da = new SqlDataAdapter("select * from aprobadores", Conexion);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvAprobadores.DataSource = dt;
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

        private void BotonVerAprobadores_Click(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from aprobadores", Conexion);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvAprobadores.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron cargar los datos en el Panel: " + ex.ToString());
            }
        }

        private void DgvCompiladores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            posicion = dgvCompiladores.CurrentRow.Index;

            txtCodigoCompilador.Text = dgvCompiladores[0, posicion].Value.ToString();
            txtNombreCompilador.Text = dgvCompiladores[1, posicion].Value.ToString();
        }

        private void DgvAprobadores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            posicion = dgvAprobadores.CurrentRow.Index;

            txtCodigoAprobador.Text = dgvAprobadores[0, posicion].Value.ToString();
            txtNombreAprobador.Text = dgvAprobadores[1, posicion].Value.ToString();
        }

        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
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

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void AprobadoresCompiladores_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void cbEleccion_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cbEleccion.Text == "Aprobadores") 
            {
                panel5.Visible = true;
                panel2.Hide();
                panel6.Hide();
            }
            if (cbEleccion.Text == "Compiladores")
            {
                panel2.Visible = true;
                panel5.Hide();
                panel6.Hide();
            }
            if (cbEleccion.Text == "Operarios")
            {
                panel6.Visible = true;
                panel2.Hide();
                panel5.Hide();
            }
        }

        private void panel6_Click(object sender, EventArgs e)
        {

        }

        private void dgvOperarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            posicion = dgvOperarios.CurrentRow.Index;

            txtCodigoOperario.Text = dgvOperarios[0, posicion].Value.ToString();
            txtNombreOperario.Text = dgvOperarios[1, posicion].Value.ToString();
        }

        private void btnRegOperario_Click_1(object sender, EventArgs e)
        {
            SqlCommand alta = new SqlCommand("INSERT INTO operariosMaquina (nomOper) VALUES (@nomOper)", Conexion);

            Adaptador.InsertCommand = alta;
            Adaptador.InsertCommand.Parameters.Add(new SqlParameter("@codOper", SqlDbType.VarChar));
            Adaptador.InsertCommand.Parameters.Add(new SqlParameter("@nomOper", SqlDbType.VarChar));

            Adaptador.InsertCommand.Parameters["@codOper"].Value = txtCodigoOperario.Text;
            Adaptador.InsertCommand.Parameters["@nomOper"].Value = txtNombreOperario.Text;

            if (string.IsNullOrEmpty(txtNombreOperario.Text))

            {
                MessageBox.Show("Es obligatorio completar el Nombre del operario.", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    Conexion.Open();
                    SqlDataAdapter compCodOperario = new SqlDataAdapter("SELECT codOper FROM operariosMaquina WHERE codOper=@codOper", Conexion);
                    DataTable codOperario = new DataTable();
                    compCodOperario.SelectCommand.Parameters.Add(new SqlParameter("@codOper", SqlDbType.VarChar));
                    compCodOperario.SelectCommand.Parameters["@codOper"].Value = txtCodigoOperario.Text;
                    compCodOperario.Fill(codOperario);

                    if (codOperario.Rows.Count > 0)
                    {
                        MessageBox.Show("El 'código' ingresado ya existe.", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    if (MessageBox.Show("¿Está seguro que desea registrar este nuevo Operario?.", "Atención!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        Adaptador.InsertCommand.ExecuteNonQuery();
                        MessageBox.Show("Se ha registrado correctamente el nuevo Operario de Maquina.", "Operación Exitosa!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarOperario();
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

        private void btnModOperario_Click_1(object sender, EventArgs e)
        {
            SqlCommand modificar = new SqlCommand("UPDATE operariosMaquina SET nomOper=@nomOper WHERE codOper=@codOper", Conexion);
            Adaptador.UpdateCommand = modificar;

            Adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@codOper", SqlDbType.Int));
            Adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@nomOper", SqlDbType.VarChar));

            Adaptador.UpdateCommand.Parameters["@codOper"].Value = txtCodigoOperario.Text;
            Adaptador.UpdateCommand.Parameters["@nomOper"].Value = txtNombreOperario.Text;

            if (string.IsNullOrEmpty(txtCodigoOperario.Text) || string.IsNullOrEmpty(txtNombreOperario.Text) && busqueda == 0)
            {
                MessageBox.Show("Por seguridad de los datos, primero debe seleccionar el Operario a modificar, recuerde que para ésto debe hacer 'Clic' sobre alguna celda del panel que represente al Operario. Por cualquier duda o consulta comuniquese con un Administrador", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    Conexion.Open();
                    // adaptador.UpdateCommand.ExecuteNonQuery();
                    // MessageBox.Show("Se ha modificado correctamente el nombre del Operario", "Operación Exitosa!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // LimpiarOperario();
                    if (MessageBox.Show("¿Está seguro que desea modificar el Operario seleccionado: " + txtCodigoOperario.Text + "?", "Atención!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        MessageBox.Show("El Operario de Maquina: " + txtCodigoOperario.Text + " - " + txtNombreOperario.Text + ", fue modificado correctamente.", "Operación Exitosa!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarOperario();
                        Adaptador.UpdateCommand.ExecuteNonQuery();
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
                SqlDataAdapter da = new SqlDataAdapter("select * from operariosMaquina", Conexion);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvOperarios.DataSource = dt;
            }
        }

        private void btnLimpiarOperario_Click_1(object sender, EventArgs e)
        {
            LimpiarOperario();
            LimpiarDGVOperarios();
        }

        private void botonVerOperarios_Click_1(object sender, EventArgs e)
        {

            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from operariosMaquina", Conexion);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvOperarios.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron cargar los datos en el Panel: " + ex.ToString());
            }
        }

        private void btnEliminarOperario_Click_1(object sender, EventArgs e)
        {
            SqlCommand baja = new SqlCommand("DELETE FROM operariosMaquina WHERE codOper=@codOper", Conexion);
            Adaptador.DeleteCommand = baja;
            Adaptador.DeleteCommand.Parameters.Add(new SqlParameter("@codOper", SqlDbType.VarChar));

            Adaptador.DeleteCommand.Parameters["@codOper"].Value = txtCodigoOperario.Text;

            if (string.IsNullOrEmpty(txtCodigoOperario.Text) || string.IsNullOrEmpty(txtNombreOperario.Text) && busqueda == 0)
            {
                MessageBox.Show("Primero debe seleccionar el Operario a eliminar, recuerde que debe posicionarse y hacer 'Clic' sobre una celda del panel para seleccionar el Operario a eliminar", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {

                    Conexion.Open();
                    /*int cantidad = adaptador.DeleteCommand.ExecuteNonQuery();
                    if (cantidad == 0)
                    {
                        MessageBox.Show("El 'Código' ingresado no existe en la base de datos.", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        MessageBox.Show("El Operario: " + txtCodigoOperario.Text + ", fue eliminado correctamente.", "Operación Exitosa!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarOperario();
                    }*/

                    if (MessageBox.Show("¿Está seguro que desea eliminar al Operario seleccionado: " + txtNombreOperario.Text + "?", "Atención!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        MessageBox.Show("El Operario: " + txtCodigoOperario.Text + ", fue eliminado correctamente.", "Operación Exitosa!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarOperario();
                        int cantidad = Adaptador.DeleteCommand.ExecuteNonQuery();
                    }
                    SqlDataAdapter da = new SqlDataAdapter("select * from operariosMaquina", Conexion);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvOperarios.DataSource = dt;
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
