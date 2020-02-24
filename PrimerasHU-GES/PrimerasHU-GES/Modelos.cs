using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.InteropServices;

namespace PrimerasHU_GES
{
    public partial class Modelos : Form
    {
        public Modelos()
        {
            InitializeComponent();
        }

        private SqlConnection Conexion;
        private SqlDataAdapter adaptador;
        private DataSet datos1;
        private DataSet datos2;
        private DataSet datos3;


        int busqueda = 0;

        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Modelos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'ges_v01modelosVehiculo2.modelosVehiculo' Puede moverla o quitarla según sea necesario.
            this.modelosVehiculoTableAdapter1.Fill(this.ges_v01modelosVehiculo2.modelosVehiculo);
            // TODO: esta línea de código carga datos en la tabla 'ges_v01modelosVehiculo.modelosVehiculo' Puede moverla o quitarla según sea necesario.
            this.modelosVehiculoTableAdapter.Fill(this.ges_v01modelosVehiculo.modelosVehiculo);
            // TODO: esta línea de código carga datos en la tabla 'ges_v01VersionesModelo.versionesModelo' Puede moverla o quitarla según sea necesario.
            this.versionesModeloTableAdapter.Fill(this.ges_v01VersionesModelo.versionesModelo);
            // TODO: esta línea de código carga datos en la tabla 'ges_v01DS_tiposVehiculo.tiposVehiculo' Puede moverla o quitarla según sea necesario.
            this.tiposVehiculoTableAdapter.Fill(this.ges_v01DS_tiposVehiculo.tiposVehiculo);

            Conexion = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=ges_v01;Integrated Security=True");
            adaptador = new SqlDataAdapter();
            datos1 = new DataSet();
            datos2 = new DataSet();
            datos3 = new DataSet();
        }

        private void Btn_altaTipoV_Click(object sender, EventArgs e)
        {
            SqlCommand alta = new SqlCommand("INSERT INTO tiposVehiculo VALUES (@codTipoV,@descTipoV)", Conexion);
            adaptador.InsertCommand = alta;
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@codTipoV",SqlDbType.VarChar));
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@descTipoV", SqlDbType.VarChar));

            adaptador.InsertCommand.Parameters["@codTipoV"].Value = txt_codTipoV.Text;
            adaptador.InsertCommand.Parameters["@descTipoV"].Value = txt_descTipoV.Text;


            if (/**string.IsNullOrEmpty(txt_codTipoV.Text) ||**/ string.IsNullOrEmpty(txt_descTipoV.Text))
            {
                MessageBox.Show("Es obligatorio completar los campos Código y Descripción", "Atención!", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
            else
            {
                DialogResult confirmacion = MessageBox.Show("¿Está seguro que desea registrar el 'Tipo de Vehículo'?","Atención",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning);
                if (confirmacion == DialogResult.OK)
                {
                    try
                    {
                        Conexion.Open();

                        // en las proximas lineas realiza una consulta para ver si el código utilizado ya existe
                        SqlDataAdapter auxTipoV = new SqlDataAdapter("SELECT codTipoV,descTipoV FROM tiposVehiculo WHERE codTipoV=@codTipoV", Conexion);
                        DataTable tipoV = new DataTable();
                        auxTipoV.SelectCommand.Parameters.Add(new SqlParameter("@codTipoV", SqlDbType.VarChar));
                        auxTipoV.SelectCommand.Parameters["@codTipoV"].Value = txt_codTipoV.Text;
                        auxTipoV.Fill(tipoV);

                        if (tipoV.Rows.Count > 0) //si la condicion se cumple, el código ingresado ya se encuentra registrado
                        {
                            string cod = tipoV.Rows[0][0].ToString();
                            string desc = tipoV.Rows[0][1].ToString();
                            DialogResult codigo = MessageBox.Show("El 'código' ingresado ya existe." +"\n" + "Contiene la información: Código = " + cod + " - Descripción = " + desc + ". \n" + "Si la información a registrar es diferente, seleccione ACEPTAR y se le habilitará la modificación manual del código, caso contrario presione CANCELAR y comience nuevamente.", "Atención!", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                            if (codigo == DialogResult.OK)
                            {
                                txt_codTipoV.Enabled = true;
                                return;
                            }
                            else
                            {
                                limpiarTiposV();
                            }
                        }
                        else
                        {
                            adaptador.InsertCommand.ExecuteNonQuery();
                            MessageBox.Show("Se ha registrado correctamente el 'Tipo de Vehículo'.", "Operación Exitosa!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            limpiarTiposV();
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
                else
                {
                    return;
                }
            }
        }

        private void Btn_limpiarTiposV_Click(object sender, EventArgs e)
        {
            limpiarTiposV();
        }

        private void limpiarTiposV()
        {
            txt_codTipoV.Enabled = false;
            this.tiposVehiculoTableAdapter.Fill(this.ges_v01DS_tiposVehiculo.tiposVehiculo); //recargo el DGV para actualizarlo a cada manejo de datos
            txt_codTipoV.Text = "";
            txt_descTipoV.Text = "";
            txt_codTipoVModif.Text = "";
            busqueda = 0; //establezco busqueda a 0, para poder conocer previamente si antes de "Modificar" se realizo una búsqueda
        }

        private void limpiarVersionMod()
        {
            txt_codVersion.Enabled = false;
            this.versionesModeloTableAdapter.Fill(this.ges_v01VersionesModelo.versionesModelo); //recargo el DGV para actualizarlo a cada manejo de datos
            txt_codVersion.Text = "";
            txt_descVersion.Text = "";
            txt_codVersionModif.Text = "";
            busqueda = 0; //establezco busqueda a 0, para poder conocer previamente si antes de "Modificar" se realizo una búsqueda
        }

        private void limpiarModelosV()
        {
            this.modelosVehiculoTableAdapter1.Fill(this.ges_v01modelosVehiculo2.modelosVehiculo); //recargo el DGV para actualizarlo a cada manejo de datos
            txt_codProyecto.Text = "";
            txt_nombreModV.Text = "";
            busqueda = 0; //establezco busqueda a 0, para poder conocer previamente si antes de "Modificar" se realizo una búsqueda
            limpiarTiposV();
            limpiarVersionMod();
        }

        private void Btn_modifTiposV_Click(object sender, EventArgs e)
        {
            SqlCommand modifica = new SqlCommand("UPDATE tiposVehiculo SET descTipoV=@descTipoV WHERE codTipoV=@codTipoV", Conexion);
            adaptador.UpdateCommand = modifica;
            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@codTipoV",SqlDbType.VarChar));
            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@descTipoV",SqlDbType.VarChar));

            adaptador.UpdateCommand.Parameters["@codTipoV"].Value = txt_codTipoVModif.Text;
            adaptador.UpdateCommand.Parameters["@descTipoV"].Value = txt_descTipoV.Text;

            if ((string.IsNullOrEmpty(txt_codTipoVModif.Text) || string.IsNullOrEmpty(txt_descTipoV.Text)) && busqueda == 0)
            {
                MessageBox.Show("Por seguridad de los datos, primero debe seleccionar del listado el 'Tipo de Vehículo' a modificar.", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                DialogResult modificar = MessageBox.Show("¿Está seguro que desea modificar el elemento con código: '" + txt_codTipoVModif.Text + "' (Nueva descripción: "+ txt_descTipoV.Text +")?", "Atención!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (modificar == DialogResult.OK)
                {
                    try
                    {
                        Conexion.Open();
                        adaptador.UpdateCommand.ExecuteNonQuery();
                        MessageBox.Show("Se ha modificado correctamente el 'Tipo de Vehículo'.", "Operación Exitosa!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("ERROR:" + ex.ToString());
                    }
                    finally
                    {
                        Conexion.Close();
                        limpiarTiposV();
                    }
                }
                else
                {
                    return;
                }
            }
        }

        private void Btn_bajaTiposV_Click(object sender, EventArgs e)
        {
            SqlCommand baja = new SqlCommand("DELETE FROM tiposVehiculo WHERE codTipoV=@codTipoV", Conexion);
            adaptador.DeleteCommand = baja;
            adaptador.DeleteCommand.Parameters.Add(new SqlParameter("@codTipoV",SqlDbType.VarChar));

            adaptador.DeleteCommand.Parameters["@codTipoV"].Value = txt_codTipoVModif.Text;

            if (string.IsNullOrEmpty(txt_codTipoVModif.Text))
            {
                MessageBox.Show("Es necesario seleccionar del listado el 'Tipo de Vehículo' a eliminar.", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                DialogResult eliminar = MessageBox.Show("¿Está seguro que desea eliminar el elemento con código: '"+ txt_codTipoVModif.Text + "'?","Atención!",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning);
                if (eliminar == DialogResult.OK)
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
                            MessageBox.Show("El 'Código': " + txt_codTipoVModif.Text + ", fue eliminado correctamente.", "Operación Exitosa!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("ERROR:" + ex.ToString());
                    }
                    finally
                    {
                        Conexion.Close();
                        limpiarTiposV();
                    }
                }
                else
                {
                    return;
                }
            }
        }

        private void Btn_altaVersion_Click(object sender, EventArgs e)
        {
            SqlCommand alta = new SqlCommand("INSERT INTO versionesModelo VALUES (@codVersion,@descVersion)", Conexion);
            adaptador.InsertCommand = alta;
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@codVersion", SqlDbType.VarChar));
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@descVersion", SqlDbType.VarChar));

            adaptador.InsertCommand.Parameters["@codVersion"].Value = txt_codVersion.Text;
            adaptador.InsertCommand.Parameters["@descVersion"].Value = txt_descVersion.Text;

            if (/**string.IsNullOrEmpty(txt_codVersion.Text) ||**/ string.IsNullOrEmpty(txt_descVersion.Text))
            {
                MessageBox.Show("Es obligatorio completar los campos Código y Descripción", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                DialogResult confirmacion = MessageBox.Show("¿Está seguro que desea registrar la 'Versión de Modelo'?", "Atención", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (confirmacion == DialogResult.OK)
                {
                    try
                    {
                        Conexion.Open();

                        // en las proximas lineas realiza una consulta para ver si el código utilizado ya existe
                        SqlDataAdapter auxVerMod = new SqlDataAdapter("SELECT codVersion,descVersion FROM versionesModelo WHERE codVersion=@codVersion", Conexion);
                        DataTable versionM = new DataTable();
                        auxVerMod.SelectCommand.Parameters.Add(new SqlParameter("@codVersion", SqlDbType.Char));
                        auxVerMod.SelectCommand.Parameters["@codVersion"].Value = txt_codVersion.Text;
                        auxVerMod.Fill(versionM);
                        if (versionM.Rows.Count > 0) //si la condicion se cumple, el código ingresado ya se encuentra registrado
                        {
                            string cod = versionM.Rows[0][0].ToString();
                            string desc = versionM.Rows[0][1].ToString();
                            DialogResult codigo = MessageBox.Show("El 'código' ingresado ya existe." + "\n" + "Contiene la información: Código = " + cod + " - Descripción = " + desc + ". \n" + "Si la información a registrar es diferente, seleccione ACEPTAR y se le habilitará la modificación manual del código, caso contrario presione CANCELAR y comience nuevamente.", "Atención!", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                            if (codigo == DialogResult.OK)
                            {
                                txt_codVersion.Enabled = true;
                                return;
                            }
                            else
                            {
                                limpiarVersionMod();
                            }
                        }
                        else
                        {
                            adaptador.InsertCommand.ExecuteNonQuery();
                            MessageBox.Show("Se ha registrado correctamente la 'Versión de Modelo'", "Operación Exitosa!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            limpiarVersionMod();
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
                else
                {
                    return;
                }
            }

        }

        private void Btn_limpiarVersion_Click(object sender, EventArgs e)
        {
            limpiarVersionMod();
        }

        private void Btn_bajaVersion_Click(object sender, EventArgs e)
        {
            SqlCommand baja = new SqlCommand("DELETE FROM versionesModelo WHERE codVersion=@codVersion", Conexion);
            adaptador.DeleteCommand = baja;
            adaptador.DeleteCommand.Parameters.Add(new SqlParameter("@codVersion", SqlDbType.Char));

            adaptador.DeleteCommand.Parameters["@codVersion"].Value = txt_codVersionModif.Text;

            if (string.IsNullOrEmpty(txt_codVersionModif.Text))
            {
                MessageBox.Show("Es necesario seleccionar del listado la 'Versión de Modelo' a eliminar.", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                DialogResult eliminar = MessageBox.Show("¿Está seguro que desea eliminar el elemento con código: '" + txt_codVersionModif.Text + "'?", "Atención!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (eliminar == DialogResult.OK)
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
                            MessageBox.Show("El 'Código': " + txt_codVersionModif.Text + ", fue eliminado correctamente.", "Operación Exitosa!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("ERROR:" + ex.ToString());
                    }
                    finally
                    {
                        Conexion.Close();
                        limpiarVersionMod();
                    }
                }
                else
                {
                    return;
                }
            }
        }

        private void Btn_modifVersion_Click(object sender, EventArgs e)
        {
            SqlCommand modifica = new SqlCommand("UPDATE versionesModelo SET descVersion=@descVersion WHERE codVersion=@codVersion", Conexion);
            adaptador.UpdateCommand = modifica;
            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@codVersion", SqlDbType.Char));
            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@descVersion", SqlDbType.VarChar));

            adaptador.UpdateCommand.Parameters["@codVersion"].Value = txt_codVersionModif.Text;
            adaptador.UpdateCommand.Parameters["@descVersion"].Value = txt_descVersion.Text;

            if ((string.IsNullOrEmpty(txt_codVersionModif.Text) || string.IsNullOrEmpty(txt_descVersion.Text)) && busqueda == 0)
            {
                MessageBox.Show("Por seguridad de los datos, primero debe seleccionar del listado la 'Versión de Modelo' a modificar.", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                DialogResult modificar = MessageBox.Show("¿Está seguro que desea modificar el elemento con código: '" + txt_codVersionModif.Text + "' (Nueva descripción: " + txt_descVersion.Text + ")?", "Atención!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (modificar == DialogResult.OK)
                {
                    try
                    {
                        Conexion.Open();
                        adaptador.UpdateCommand.ExecuteNonQuery();
                        MessageBox.Show("Se ha modificado correctamente la 'Versión de Modelo'.", "Operación Exitosa!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("ERROR:" + ex.ToString());
                    }
                    finally
                    {
                        Conexion.Close();
                        limpiarVersionMod();
                    }
                }
                else
                {
                    return;
                }
            }
        }

        private void Bnt_altaModV_Click(object sender, EventArgs e)
        {
            SqlCommand alta = new SqlCommand("INSERT INTO modelosVehiculo VALUES (@codProyecto,@codVersion,@codTipoV,@nomModelo,@fecModifModelo)", Conexion);
            adaptador.InsertCommand = alta;
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@codProyecto", SqlDbType.Int));
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@codVersion", SqlDbType.Char));
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@codTipoV", SqlDbType.VarChar));
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@nomModelo", SqlDbType.VarChar));
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@fecModifModelo", SqlDbType.DateTime));

            if (string.IsNullOrEmpty(txt_codProyecto.Text) || string.IsNullOrEmpty(txt_nombreModV.Text))
            {
                MessageBox.Show("Es obligatorio completar los campos Código y Nombre", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    adaptador.InsertCommand.Parameters["@codProyecto"].Value = Convert.ToInt32(txt_codProyecto.Text);
                    adaptador.InsertCommand.Parameters["@codVersion"].Value = cb_versionesModelo.SelectedValue;
                    adaptador.InsertCommand.Parameters["@codTipoV"].Value = cb_tiposVehiculo.SelectedValue;
                    adaptador.InsertCommand.Parameters["@nomModelo"].Value = txt_nombreModV.Text;
                    adaptador.InsertCommand.Parameters["@fecModifModelo"].Value = dtp_fechaModV.Value;

                    Conexion.Open();

                    // en las proximas lineas realiza una consulta para ver si el código utilizado ya existe
                    SqlDataAdapter auxModV = new SqlDataAdapter("SELECT codProyecto FROM modelosVehiculo WHERE codProyecto=@codProyecto", Conexion);
                    DataTable modelosV = new DataTable();
                    auxModV.SelectCommand.Parameters.Add(new SqlParameter("@codProyecto", SqlDbType.Int));
                    auxModV.SelectCommand.Parameters["@codProyecto"].Value = txt_codProyecto.Text;
                    auxModV.Fill(modelosV);
                    if (modelosV.Rows.Count > 0) //si la condicion se cumple, el código ingresado ya se encuentra registrado
                    {
                        MessageBox.Show("El 'código' ingresado ya existe.", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        adaptador.InsertCommand.ExecuteNonQuery();
                        MessageBox.Show("Se ha registrado correctamente el 'Modelo de Vehículo'. Proyecto nuevo creado: "+txt_nombreModV.Text, "Operación Exitosa!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR:" + ex.ToString());
                }
                finally
                {
                    Conexion.Close();
                    limpiarModelosV();
                }
            }
        }

        private void Txt_codProyecto_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back);
        }

        private void Btn_limpiarModV_Click(object sender, EventArgs e)
        {
            limpiarModelosV();
        }

        private void Btn_buscarModV_Click(object sender, EventArgs e)
        {
            SqlCommand consulta = new SqlCommand("SELECT * FROM modelosVehiculo WHERE codProyecto=@codProyecto", Conexion);
            adaptador.SelectCommand = consulta;
            adaptador.SelectCommand.Parameters.Add(new SqlParameter("@codProyecto", SqlDbType.Int));
            adaptador.SelectCommand.Parameters["@codProyecto"].Value = int.Parse(txt_codProyecto.Text);

            if (string.IsNullOrEmpty(txt_codProyecto.Text))
            {
                MessageBox.Show("Es obligatorio completar el campo 'Código' para buscar el elemento a modificar/eliminar", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    Conexion.Open();
                    datos3 = new DataSet();
                    adaptador.Fill(datos3, "modelosVehiculo");
                    int registro = int.Parse(datos3.Tables["modelosVehiculo"].Rows.Count.ToString());
                    if (registro == 1)
                    {
                        foreach (DataRow fila in datos3.Tables["modelosVehiculo"].Rows)
                        {
                            txt_codProyecto.Text = fila["codProyecto"].ToString();
                            cb_versionesModelo.SelectedValue = fila["codVersion"];
                            cb_tiposVehiculo.SelectedValue = fila["codTipoV"];
                            txt_nombreModV.Text = fila["nomModelo"].ToString();
                            dtp_fechaModV.Value = DateTime.Parse(fila["fecModifModelo"].ToString());
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

        private void Txt_codProyecto_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btn_bajaModV_Click(object sender, EventArgs e)
        {
            SqlCommand baja = new SqlCommand("DELETE FROM modelosVehiculo WHERE codProyecto=@codProyecto", Conexion);
            adaptador.DeleteCommand = baja;
            adaptador.DeleteCommand.Parameters.Add(new SqlParameter("@codProyecto", SqlDbType.Int));

            adaptador.DeleteCommand.Parameters["@codProyecto"].Value = int.Parse(txt_codProyecto.Text);

            if (string.IsNullOrEmpty(txt_codProyecto.Text))
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
                        MessageBox.Show("El 'Código':" + txt_codProyecto.Text + ", fue eliminado correctamente.", "Operación Exitosa!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR:" + ex.ToString());
                }
                finally
                {
                    Conexion.Close();
                        limpiarModelosV();
                }
            }
        }

        
        private void Btn_modifModV_Click(object sender, EventArgs e)
        {
            SqlCommand modifica = new SqlCommand("UPDATE modelosVehiculo SET codVersion=@codVersion,codTipoV=@codTipoV,nomModelo=@nomModelo,fecModifModelo=@fecModifModelo WHERE codProyecto=@codProyecto", Conexion);
            adaptador.UpdateCommand = modifica;
            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@codProyecto",SqlDbType.Int));
            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@codVersion", SqlDbType.Char));
            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@codTipoV", SqlDbType.VarChar));
            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@nomModelo", SqlDbType.VarChar));
            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@fecModifModelo", SqlDbType.DateTime));

            adaptador.UpdateCommand.Parameters["@codVersion"].Value = cb_versionesModelo.SelectedValue;
            adaptador.UpdateCommand.Parameters["@codTipoV"].Value = cb_tiposVehiculo.SelectedValue;
            adaptador.UpdateCommand.Parameters["@nomModelo"].Value = txt_descVersion.Text;
            adaptador.UpdateCommand.Parameters["@fecModifModelo"].Value = dtp_fechaModV.Value;

            if ((string.IsNullOrEmpty(txt_codProyecto.Text) || string.IsNullOrEmpty(txt_nombreModV.Text)) && busqueda == 0)
            {
                MessageBox.Show("Por seguridad de los datos, primero debe realizar la búsqueda de la 'Modelo de Vehícullo' a modificar", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    Conexion.Open();
                    adaptador.UpdateCommand.ExecuteNonQuery();
                    MessageBox.Show("Se ha modificado correctamente el 'Modelo de Vehículo'", "Operación Exitosa!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpiarVersionMod();
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

        private void btn_Salir_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void dgv_tiposVehiculo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            busqueda = 1;
            txt_codTipoV.Text = "";
            int posi = dgv_tiposVehiculo.CurrentRow.Index;

            txt_codTipoVModif.Text = dgv_tiposVehiculo[0, posi].Value.ToString();
            txt_descTipoV.Text = dgv_tiposVehiculo[1, posi].Value.ToString();
        }

        private void txt_descTipoV_TextChanged(object sender, EventArgs e)
        {
            if (busqueda == 0)
            {
                int posi = 0;
                char[] tipeo = txt_descTipoV.Text.ToCharArray();
                string codTipoV = "";
                int espacio = 0;
                int primeraLetra = 0;
                int segundaLetra = 0;
                int salida = 0;
                do
                {
                    if (posi == 0)
                    {
                        if (string.IsNullOrEmpty(txt_descTipoV.Text))
                        {
                            posi = -1;
                        }

                        if (posi != -1)
                        {
                            codTipoV += tipeo[posi];
                            primeraLetra++;
                        }
                    }

                    if (posi != -1)
                    {

                        if (espacio != 0 && segundaLetra == 0)
                        {
                            codTipoV += tipeo[posi];
                            segundaLetra++;
                        }

                        if (tipeo[posi] == ' ')
                        {
                            espacio++;
                        }
                    }

                    if (posi == tipeo.Length - 1)
                    {
                        salida++;
                    }
                    posi++;
                } while (salida == 0);

                txt_codTipoV.Text = codTipoV;
            }
        }

        private void dgv_versionesModelo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            busqueda = 1;
            txt_codVersion.Text = "";
            int posi = dgv_versionesModelo.CurrentRow.Index;

            txt_codVersionModif.Text = dgv_versionesModelo[0, posi].Value.ToString();
            txt_descVersion.Text = dgv_versionesModelo[1, posi].Value.ToString();
        }

        private void txt_descVersion_TextChanged(object sender, EventArgs e)
        {
            if (busqueda == 0)
            {
                int posi = 0;
                char[] tipeo = txt_descVersion.Text.ToCharArray();
                string codVersion = "";
                int espacio = 0;
                int primeraLetra = 0;
                int segundaLetra = 0;
                int salida = 0;
                do
                {
                    if (posi == 0)
                    {
                        if (string.IsNullOrEmpty(txt_descVersion.Text))
                        {
                            posi = -1;
                        }

                        if (posi != -1)
                        {
                            codVersion += tipeo[posi];
                            primeraLetra++;
                        }
                    }

                    if (posi != -1)
                    {

                        if (espacio != 0 && segundaLetra == 0)
                        {
                            codVersion += tipeo[posi];
                            segundaLetra++;
                        }

                        if (tipeo[posi] == ' ')
                        {
                            espacio++;
                        }
                    }

                    if (posi == tipeo.Length - 1)
                    {
                        salida++;
                    }
                    posi++;
                } while (salida == 0);

                txt_codVersion.Text = codVersion;
            }
        }

        private void Modelos_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
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

        private void button1_Click(object sender, EventArgs e)
        {

            this.WindowState = FormWindowState.Minimized;

        }

        private void btn_Salir_Click_2(object sender, EventArgs e)
        {
            this.Dispose();

        }
    }
}
