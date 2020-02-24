﻿using System;
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
    public partial class ReglasMedicion : Form
    {
        public ReglasMedicion()
        {
            InitializeComponent();
        }

        private SqlConnection Conexion;
        private SqlDataAdapter adaptador;
        private SqlDataAdapter ad_ultEstado;

        private void btn_min_Click(object sender, EventArgs e)
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

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void ReglasMedicion_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'ges_v01DataSetReglasMed.reglasMedicion' Puede moverla o quitarla según sea necesario.
            this.reglasMedicionTableAdapter.Fill(this.ges_v01DataSetReglasMed.reglasMedicion);

            Conexion = new SqlConnection("Data source=.\\SQLEXPRESS; Initial Catalog = ges_v01; Integrated Security = True");
            adaptador = new SqlDataAdapter();

            recuperarUltimoCodigo();
        }

        private void recuperarUltimoCodigo()
        {
            //HAY QUE TENER EN CUENTA QUE EL CÓDIGO DE MUESTRA ES AUTOINCREMENTABLE, NO LO VAMOS A ASIGNAR NOSOTROS
            //RECUPERO EL ÚLTIMO CÓDIGO DE MUESTRA UTILIZADO Y MUESTRO EL CODIGO NUEVO QUE INGRESARA. EN CASO DE LA TABLA ESTAR VACIA SE LE ASIGNA EL PRIMERO
            SqlCommand ultEstado = new SqlCommand("SELECT TOP 1 codRegla FROM reglasMedicion ORDER BY codRegla DESC", Conexion);
            ad_ultEstado = new SqlDataAdapter(ultEstado);
            DataTable dt_ultEstado = new DataTable();
            ad_ultEstado.Fill(dt_ultEstado);
            if (dt_ultEstado.Rows.Count == 0)
            {
                txt_codigo.Text = "1";
            }
            else
            {
                string aux_codNvo = dt_ultEstado.Rows[0][0].ToString();
                int codNvo = 0;
                codNvo = Convert.ToInt32(aux_codNvo);
                codNvo++;
                txt_codigo.Text = codNvo.ToString(); //PRUEBA DE PUSH/PULL EN GITHUB >> ALGO ESTÁ FALLANDO
            }
        }

        private void limpiar()
        {
            txt_descripcion.Text = "";
            recuperarUltimoCodigo();
            this.reglasMedicionTableAdapter.Fill(this.ges_v01DataSetReglasMed.reglasMedicion);
            btn_registrar.Enabled = true;
            btn_modificar.Enabled = false;
            btn_eliminar.Enabled = false;
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void dgv_reglasMed_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int posi = dgv_reglasMed.CurrentRow.Index;

            txt_codigo.Text = dgv_reglasMed[0, posi].Value.ToString();
            txt_descripcion.Text = dgv_reglasMed[1, posi].Value.ToString();
            txt_salida.Text = dgv_reglasMed[2, posi].Value.ToString();

            btn_registrar.Enabled = false;
            btn_modificar.Enabled = true;
            btn_eliminar.Enabled = true;
        }

        private void txt_descripcion_TextChanged(object sender, EventArgs e)
        {
            txt_salida.Text = txt_descripcion.Text;
        }

        private void btn_registrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_descripcion.Text))
            {
                MessageBox.Show("Debe escribir una descripción.", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                SqlCommand existeDesc = new SqlCommand("SELECT descRegla FROM reglasMedicion WHERE UPPER(descRegla) = UPPER('" + txt_descripcion.Text + "')", Conexion);
                adaptador = new SqlDataAdapter(existeDesc);

                DataTable dt_existeDesc = new DataTable();
                adaptador.Fill(dt_existeDesc);
                if (dt_existeDesc.Rows.Count != 0)
                {
                    MessageBox.Show("La regla de medición que intenta registrar, ya existe. Inténtelo nuevamente o póngase en contacto con el administrador.", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    SqlCommand alta = new SqlCommand("INSERT INTO reglasMedicion (descRegla,salidaRegla) VALUES (@descRegla,@salidaRegla)", Conexion);
                    adaptador = new SqlDataAdapter();
                    adaptador.InsertCommand = alta;
                    adaptador.InsertCommand.Parameters.Add(new SqlParameter("@descRegla", SqlDbType.VarChar));
                    adaptador.InsertCommand.Parameters.Add(new SqlParameter("@salidaRegla", SqlDbType.VarChar));
                    adaptador.InsertCommand.Parameters["@descRegla"].Value = txt_descripcion.Text;
                    adaptador.InsertCommand.Parameters["@salidaRegla"].Value = txt_salida.Text;
                    try
                    {
                        Conexion.Open();
                        adaptador.InsertCommand.ExecuteNonQuery();
                        MessageBox.Show("La regla de medición fue registrada con éxito.", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        limpiar();
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

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            SqlCommand baja = new SqlCommand("DELETE FROM reglasMedicion WHERE codRegla=@codRegla", Conexion);
            adaptador.DeleteCommand = baja;
            adaptador.DeleteCommand.Parameters.Add(new SqlParameter("@codRegla", SqlDbType.Int));

            adaptador.DeleteCommand.Parameters["@codRegla"].Value = Convert.ToInt32(txt_codigo.Text);

            if (string.IsNullOrEmpty(txt_descripcion.Text))
            {
                MessageBox.Show("Es necesario seleccionar del listado la 'Regla de Medición' a eliminar.", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                DialogResult eliminar = MessageBox.Show("¿Está seguro que desea eliminar el elemento con código: '" + txt_codigo.Text + "'?", "Atención!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
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
                            MessageBox.Show("El 'Código': " + txt_codigo.Text + ", fue eliminado correctamente.", "Operación Exitosa!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("ERROR:" + ex.ToString());
                    }
                    finally
                    {
                        Conexion.Close();
                        limpiar();
                    }
                }
                else
                {
                    return;
                }
            }
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            SqlCommand modifica = new SqlCommand("UPDATE reglasMedicion SET descRegla=@descRegla,salidaRegla=@salidaRegla WHERE codRegla=@codRegla", Conexion);
            adaptador.UpdateCommand = modifica;
            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@codRegla", SqlDbType.Int));
            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@descRegla", SqlDbType.VarChar));
            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@salidaRegla", SqlDbType.VarChar));

            adaptador.UpdateCommand.Parameters["@codRegla"].Value = txt_codigo.Text;
            adaptador.UpdateCommand.Parameters["@descRegla"].Value = txt_descripcion.Text;
            adaptador.UpdateCommand.Parameters["@salidaRegla"].Value = txt_salida.Text;

            if ((string.IsNullOrEmpty(txt_codigo.Text) || string.IsNullOrEmpty(txt_descripcion.Text)))
            {
                MessageBox.Show("Por seguridad de los datos, primero debe seleccionar del listado la 'Regla de Medición' a modificar.", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                DialogResult modificar = MessageBox.Show("¿Está seguro que desea modificar el elemento con código: '" + txt_codigo.Text + "' (Nueva descripción: " + txt_descripcion.Text + ")?", "Atención!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (modificar == DialogResult.OK)
                {
                    try
                    {
                        Conexion.Open();
                        adaptador.UpdateCommand.ExecuteNonQuery();
                        MessageBox.Show("Se ha modificado correctamente la 'Regla de Medición'.", "Operación Exitosa!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("ERROR:" + ex.ToString());
                    }
                    finally
                    {
                        Conexion.Close();
                        limpiar();
                    }
                }
                else
                {
                    return;
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
