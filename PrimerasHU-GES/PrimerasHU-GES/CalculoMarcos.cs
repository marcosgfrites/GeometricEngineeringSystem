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
using System.Runtime.InteropServices;
using System.Collections;
using System.Globalization;

namespace PrimerasHU_GES
{
    public partial class CalculoMarcos : Form
    {
        public CalculoMarcos()
        {
            InitializeComponent();
        }

        private SqlConnection Conexion;
        private SqlDataAdapter adaptador;
        private SqlDataAdapter ad_muestras;
        private SqlDataAdapter ad_listadoPuntos;
        private SqlDataAdapter ad_datosPunto;

        ArrayList Puntos = new ArrayList();
        ArrayList Cp = new ArrayList();
        ArrayList Cpk = new ArrayList();

        ArrayList Puntos2 = new ArrayList();
        ArrayList Cp2 = new ArrayList();
        ArrayList Cpk2 = new ArrayList();


        string muestraSeleccionada = "";

        int cant_cpV = 0, cant_cpA = 0, cant_cpR = 0, cant_cpkV = 0, cant_cpkA = 0, cant_cpkR = 0; // cuenta la cantidad de CP o CPK en VERDE(V), AMARILLO(A), ROJO(R)
        decimal suma_cpV = 0, suma_cpA = 0, suma_cpR = 0, suma_cpkV = 0, suma_cpkA = 0, suma_cpkR = 0; // acumula la suma de los valores CP o CPK en VERDE, AMARILLO y ROJO

        int cant_cpV2 = 0, cant_cpA2 = 0, cant_cpR2 = 0, cant_cpkV2 = 0, cant_cpkA2 = 0, cant_cpkR2 = 0; // cuenta la cantidad de CP o CPK en VERDE(V), AMARILLO(A), ROJO(R)
        decimal suma_cpV2 = 0, suma_cpA2 = 0, suma_cpR2 = 0, suma_cpkV2 = 0, suma_cpkA2 = 0, suma_cpkR2 = 0; // acumula la suma de los valores CP o CPK en VERDE, AMARILLO y ROJO

        private void CalculoMarcos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'ges_v01DataSetCalculos.calculos' Puede moverla o quitarla según sea necesario.
            this.calculosTableAdapter.Fill(this.ges_v01DataSetCalculos.calculos);
            btn_registrar.Enabled = false;
            panel_calculos.Visible = false;
            dgv_datosPunto.Hide();
            dgv_nombrePuntos.Hide();

            Conexion = new SqlConnection("Data source=.\\SQLEXPRESS; Initial Catalog = ges_v01; Integrated Security = True");
            adaptador = new SqlDataAdapter();

            conocerMuestras();
            dgv_muestras.ClearSelection(); // >> esta linea deselecciona una fila del dgv_muestras, obliga al usuario a seleccionar si o si.
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void conocerMuestras()
        {
            if (dgv_muestras.Rows.Count != 0)
            {
                dgv_muestras.DataSource = null;
                dgv_muestras.Rows.Clear();
                dgv_muestras.Refresh();
            }
            SqlCommand muestrasNoGraf = new SqlCommand("SELECT m.codMuestra AS 'Código',m.fechaMuestra AS 'Fecha',tm.descTiposMuestra AS 'Tipo de Muestra',m.cantidadDmo AS 'Cant. DMO' FROM muestras AS m JOIN tiposMuestra AS tm ON tm.codTiposMuestra=m.codTiposMuestra", Conexion);
            ad_muestras = new SqlDataAdapter(muestrasNoGraf);
            DataTable dt_muestrasNoGraf = new DataTable();
            ad_muestras.Fill(dt_muestrasNoGraf);
            dgv_muestras.DataSource = dt_muestrasNoGraf;

            ad_muestras.SelectCommand.Parameters.Clear();
        }

        private void limpiarCalculosF()
        {
            if (dgv_nombrePuntos.Rows.Count != 0)
            {
                dgv_nombrePuntos.Rows.Clear();
                dgv_nombrePuntos.Refresh();
            }
            if (dgv_calculos.Rows.Count != 0)
            {
                dgv_calculos.Rows.Clear();
                dgv_calculos.Refresh();
            }
            if (dgv_puntosF.Rows.Count !=0)
            {
                dgv_puntosF.Rows.Clear();
                dgv_puntosF.Refresh();
            }
            panel_calculos.Visible = false;
            dgv_puntosF.Visible = false;
            txt_cpVerde.Visible = false;
            txt_cpAmarillo.Visible = false;
            txt_cpRojo.Visible = false;
            txt_cpkVerde.Visible = false;
            txt_cpkAmarillo.Visible = false;
            txt_cpkRojo.Visible = false;

            txt_cpvPorc.Visible = false;
            txt_cpaPorc.Visible = false;
            txt_cprPorc.Visible = false;
            txt_cpkvPorc.Visible = false;
            txt_cpkaPorc.Visible = false;
            txt_cpkrPorc.Visible = false;

            txt_cantidadF.Text = "";
            txt_muestraF.Text = "";
            txt_cpAmarillo.Text = "";
            txt_cpkAmarillo.Text = "";
            txt_cpkRojo.Text = "";
            txt_cpkVerde.Text = "";
            txt_cpVerde.Text = "";
            txt_cpRojo.Text = "";

            txt_cpvPorc.Text = "";
            txt_cpaPorc.Text = "";
            txt_cprPorc.Text = "";
            txt_cpkvPorc.Text = "";
            txt_cpkaPorc.Text = "";
            txt_cpkrPorc.Text = "";

            btn_registrar.Enabled = false;
        }

        private void Dgv_muestras_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            limpiarCalculosF();
            int posi_muestras = dgv_muestras.CurrentRow.Index;
            string aux_codMuestra = dgv_muestras[0, posi_muestras].Value.ToString();
            string aux_tipoMuestra = dgv_muestras[2, posi_muestras].Value.ToString();
            muestraSeleccionada = aux_codMuestra;
            rellenarListaPuntos(aux_codMuestra);
            lbl_muestra.Text = aux_codMuestra;
            lbl_tipoMuestra.Text = aux_tipoMuestra;
            obtenerNombrePuntos();
            conocerPuntosF();
        }

        private void calculosF()
        {
            cant_cpV = 0;
            cant_cpA = 0;
            cant_cpR = 0;
            cant_cpkV = 0;
            cant_cpkA = 0;
            cant_cpkR = 0; // cuenta la cantidad de CP o CPK en VERDE(V), AMARILLO(A), ROJO(R)
            suma_cpV = 0;
            suma_cpA = 0;
            suma_cpR = 0;
            suma_cpkV = 0;
            suma_cpkA = 0;
            suma_cpkR = 0; // acumula la suma de los valores CP o CPK en VERDE, AMARILLO y ROJO

            CultureInfo culture = new CultureInfo("en-US"); //
            decimal verde = decimal.Parse("1.33",culture);
            decimal amarillo = decimal.Parse("1.00",culture);
            decimal rojo = decimal.Parse("0.00", culture);
            decimal auxCp, auxCpk;
            foreach (DataGridViewRow fila in dgv_calculos.Rows)
            {
                int i = 0;
                for (i = 0; i < dgv_puntosF.Rows.Count; i++)
                {
                    if (fila.Cells[0].Value.ToString() == dgv_puntosF.Rows[i].Cells[0].Value.ToString())
                    {
                        Puntos.Add(fila.Cells[0].Value.ToString());
                        i = dgv_puntosF.Rows.Count;
                        fila.DefaultCellStyle.BackColor = Color.LightGray;
                        //trabajo con CP y almaceno
                        auxCp = decimal.Parse(fila.Cells[4].Value.ToString(), System.Globalization.NumberStyles.AllowParentheses |
                 System.Globalization.NumberStyles.AllowLeadingWhite |
                 System.Globalization.NumberStyles.AllowTrailingWhite |
                 System.Globalization.NumberStyles.AllowThousands |
                 System.Globalization.NumberStyles.AllowDecimalPoint |
                 System.Globalization.NumberStyles.AllowLeadingSign);
                        Cp.Add(decimal.Parse(fila.Cells[4].Value.ToString(), System.Globalization.NumberStyles.AllowParentheses |
                 System.Globalization.NumberStyles.AllowLeadingWhite |
                 System.Globalization.NumberStyles.AllowTrailingWhite |
                 System.Globalization.NumberStyles.AllowThousands |
                 System.Globalization.NumberStyles.AllowDecimalPoint |
                 System.Globalization.NumberStyles.AllowLeadingSign));
                        if (auxCp >= verde)
                        {
                            fila.Cells[4].Style.ForeColor = Color.Green;
                            cant_cpV++;
                            suma_cpV += auxCp;
                        }
                        else
                        {
                            if(auxCp < verde && auxCp >= amarillo)
                            {
                                fila.Cells[4].Style.ForeColor = Color.Yellow;
                                cant_cpA++;
                                suma_cpA += auxCp;
                            }
                            else
                            {
                                fila.Cells[4].Style.ForeColor = Color.Red;
                                cant_cpR++;
                                suma_cpR += auxCp;
                            }
                        }

                        //trabajo con CPK y almaceno
                        auxCpk = decimal.Parse(fila.Cells[7].Value.ToString(), System.Globalization.NumberStyles.AllowParentheses |
                 System.Globalization.NumberStyles.AllowLeadingWhite |
                 System.Globalization.NumberStyles.AllowTrailingWhite |
                 System.Globalization.NumberStyles.AllowThousands |
                 System.Globalization.NumberStyles.AllowDecimalPoint |
                 System.Globalization.NumberStyles.AllowLeadingSign);
                        Cpk.Add(decimal.Parse(fila.Cells[7].Value.ToString(), System.Globalization.NumberStyles.AllowParentheses |
                 System.Globalization.NumberStyles.AllowLeadingWhite |
                 System.Globalization.NumberStyles.AllowTrailingWhite |
                 System.Globalization.NumberStyles.AllowThousands |
                 System.Globalization.NumberStyles.AllowDecimalPoint |
                 System.Globalization.NumberStyles.AllowLeadingSign));
                        if (auxCpk >= verde)
                        {
                            fila.Cells[7].Style.ForeColor = Color.Green;
                            cant_cpkV++;
                            suma_cpkV += auxCpk;
                        }
                        else
                        {
                            if (auxCpk < verde && auxCpk >= amarillo)
                            {
                                fila.Cells[7].Style.ForeColor = Color.Yellow;
                                cant_cpkA++;
                                suma_cpkA += auxCpk;
                            }
                            else
                            {
                                fila.Cells[7].Style.ForeColor = Color.Red;
                                cant_cpkR++;
                                suma_cpkR += auxCpk;
                            }
                        }

                        //PORCENTAJES
                        if (cant_cpV != 0)
                        {
                            double cpvPorc = (double)(cant_cpV * 100) / double.Parse(txt_cantidadF.Text);
                            txt_cpvPorc.Text = cpvPorc.ToString("0.00");
                        }
                        else
                        {
                            txt_cpvPorc.Text = "0,00";
                        }

                        if (cant_cpA != 0)
                        {
                            double cpaPorc = (double)(cant_cpA * 100) / double.Parse(txt_cantidadF.Text);
                            txt_cpaPorc.Text = cpaPorc.ToString("0.00");
                        }
                        else
                        {
                            txt_cpaPorc.Text = "0,00";
                        }

                        if (cant_cpR != 0)
                        {
                            double cprPorc = (double)(cant_cpR * 100) / double.Parse(txt_cantidadF.Text);
                            txt_cprPorc.Text = cprPorc.ToString("0.00");
                        }
                        else
                        {
                            txt_cprPorc.Text = "0,00";
                        }

                        if (cant_cpkV != 0)
                        {
                            double cpkvPorc = (double)(cant_cpkV * 100) / double.Parse(txt_cantidadF.Text);
                            txt_cpkvPorc.Text = cpkvPorc.ToString("0.00");
                        }
                        else
                        {
                            txt_cpkvPorc.Text = "0,00";
                        }

                        if (cant_cpkA != 0)
                        {
                            double cpkaPorc = (double)(cant_cpkA * 100) / double.Parse(txt_cantidadF.Text);
                            txt_cpkaPorc.Text = cpkaPorc.ToString("0.00");
                        }
                        else
                        {
                            txt_cpkaPorc.Text = "0,00";
                        }

                        if (cant_cpkR != 0)
                        {
                            double cpkrPorc = (double)(cant_cpkR * 100) / double.Parse(txt_cantidadF.Text);
                            txt_cpkrPorc.Text = cpkrPorc.ToString("0.00");
                        }
                        else
                        {
                            txt_cpkrPorc.Text = "0,00";
                        }
                    }
                }
            }

            // ACA VA TODA LA PRESENTACION DE CALCULOS
            txt_cpVerde.Text = cant_cpV.ToString();
            txt_cpAmarillo.Text = cant_cpA.ToString();
            txt_cpRojo.Text = cant_cpR.ToString();
            txt_cpkVerde.Text = cant_cpkV.ToString();
            txt_cpkAmarillo.Text = cant_cpkA.ToString();
            txt_cpkRojo.Text = cant_cpkR.ToString();
            btn_registrar.Enabled = true;
            btn_calcular.Enabled = true;
        }

        private void conocerPuntosF()
        {
            foreach (DataGridViewRow fila in dgv_listaPuntos.Rows)
            {
                if (fila.Cells[1].Value.ToString() == "F")
                {
                    dgv_puntosF.Rows.Add(fila.Cells[0].Value.ToString());
                }
            }

        }

        private void btn_verGrafo_Click(object sender, EventArgs e)
        {
            string ventana = "No Registrado";
            string calculo2 = "";
            CalculoGrafo cg = new CalculoGrafo(Cp,Cpk,Puntos,ventana,calculo2);
            cg.ShowDialog();
        }

        private void btn_registrar_Click(object sender, EventArgs e)
        {
            if (lbl_tipoMuestra.Text == "De Test")
            {
                MessageBox.Show("Está intentando registrar una muestra de tipo 'De Test'. Sólo se permite el registro de muestras de tipo 'De Estadístico'.","Atención!",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                string mensaje = "Se ha registrado correctamente: " + "\n";
                if (dgv_calculos.Rows.Count != 0)
                {
                    SqlCommand registrarCalculo = new SqlCommand("INSERT INTO calculos (codMuestra,fechaCalculo) VALUES (@codMuestra,@fechaCalculo)", Conexion);
                    adaptador.InsertCommand = registrarCalculo;
                    adaptador.InsertCommand.Parameters.Add(new SqlParameter("@codMuestra", SqlDbType.Int));
                    adaptador.InsertCommand.Parameters.Add(new SqlParameter("@fechaCalculo", SqlDbType.Date));

                    adaptador.InsertCommand.Parameters["@codMuestra"].Value = Convert.ToInt32(lbl_muestra.Text);
                    adaptador.InsertCommand.Parameters["@fechaCalculo"].Value = dtp_fechaCalculo.Value.ToString("yyyy-MM-dd");

                    try
                    {
                        Conexion.Open();

                        SqlDataAdapter consulta1 = new SqlDataAdapter();
                        SqlCommand consultaRegistroCalculoMuestra = new SqlCommand("SELECT codMuestra FROM calculos WHERE codMuestra=@codMuestra", Conexion);
                        consulta1.SelectCommand = consultaRegistroCalculoMuestra;
                        consulta1.SelectCommand.Parameters.Add(new SqlParameter("@codMuestra", SqlDbType.Int));
                        consulta1.SelectCommand.Parameters["@codMuestra"].Value = Convert.ToInt32(lbl_muestra.Text);
                        consulta1.SelectCommand.ExecuteNonQuery();
                        DataTable dt_consultaRegistro = new DataTable();
                        consulta1.Fill(dt_consultaRegistro);
                        if (dt_consultaRegistro.Rows.Count == 0)
                        {
                            adaptador.InsertCommand.ExecuteNonQuery();
                            mensaje += "- Cálculos" + "\n";

                            //INSERCIÓN DE DETALLESCALCULO
                            try
                            {
                                SqlDataAdapter consulta2 = new SqlDataAdapter();
                                SqlCommand altaDetalleCalculo = new SqlCommand("INSERT INTO detallesCalculo (codCalculo,codTipoCalculo,idPtoMed,resultadoCalculo) VALUES (@codCalculo,@codTipoCalculo,@idPtoMed,@resultadoCalculo)", Conexion);
                                consulta2.InsertCommand = altaDetalleCalculo;

                                foreach (DataGridViewRow fila in dgv_calculos.Rows) //recorro el datagridview con los cálculos
                                {
                                    int i = 0;
                                    for (i = 0; i < dgv_puntosF.Rows.Count; i++) //recorro el listado de los nombres de puntos F
                                    {
                                        if (fila.Cells[0].Value.ToString() == dgv_puntosF.Rows[i].Cells[0].Value.ToString()) //compruebo si el punto del cálculo es punto F
                                        {
                                            for (int j = 1; j < 8; j++) //recorro la fila del punto para obtener todos los valores
                                            {
                                                consulta2.InsertCommand.Parameters.Clear();

                                                consulta2.InsertCommand.Parameters.Add(new SqlParameter("@codCalculo", SqlDbType.Int));
                                                consulta2.InsertCommand.Parameters.Add(new SqlParameter("@codTipoCalculo", SqlDbType.Int));
                                                consulta2.InsertCommand.Parameters.Add(new SqlParameter("@idPtoMed", SqlDbType.VarChar));
                                                consulta2.InsertCommand.Parameters.Add(new SqlParameter("@resultadoCalculo", SqlDbType.Decimal));

                                                SqlDataAdapter consulta3 = new SqlDataAdapter();
                                                SqlCommand consultaCalculoCodigo = new SqlCommand("SELECT TOP 1 codCalculo FROM calculos ORDER BY codCalculo DESC", Conexion);
                                                consulta3.SelectCommand = consultaCalculoCodigo;
                                                DataTable dt_codigoCalculo = new DataTable();
                                                consulta3.Fill(dt_codigoCalculo);
                                                string aux1 = "";
                                                if (dt_codigoCalculo.Rows.Count != 0)
                                                {
                                                    aux1 = dt_codigoCalculo.Rows[0][0].ToString();
                                                }
                                                consulta2.InsertCommand.Parameters["@codCalculo"].Value = Convert.ToInt32(aux1);

                                                int tipoCalculo = 0;
                                                if (j == 1)
                                                {
                                                    tipoCalculo = 1; //Rango Flotante
                                                }
                                                else
                                                {
                                                    if (j == 2)
                                                    {
                                                        tipoCalculo = 2; //Media
                                                    }
                                                    else
                                                    {
                                                        if (j == 3)
                                                        {
                                                            tipoCalculo = 3; //Sigma
                                                        }
                                                        else
                                                        {
                                                            if (j == 4)
                                                            {
                                                                tipoCalculo = 4; //Cp
                                                            }
                                                            else
                                                            {
                                                                if (j == 5)
                                                                {
                                                                    tipoCalculo = 5; //Cpk (Inferior)
                                                                }
                                                                else
                                                                {
                                                                    if (j == 6)
                                                                    {
                                                                        tipoCalculo = 6; //Cpk (Superior)
                                                                    }
                                                                    else
                                                                    {
                                                                        tipoCalculo = 7; //Cpk
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                }

                                                consulta2.InsertCommand.Parameters["@codTipoCalculo"].Value = tipoCalculo; //Rango Flotante
                                                consulta2.InsertCommand.Parameters["@idPtoMed"].Value = fila.Cells[0].Value.ToString();
                                                consulta2.InsertCommand.Parameters["@resultadoCalculo"].Value = Convert.ToDecimal(fila.Cells[j].Value.ToString());

                                                consulta2.InsertCommand.ExecuteNonQuery();
                                            }
                                        }
                                    }

                                }
                                mensaje += "- Detalles de Cálculos";
                                MessageBox.Show(mensaje, "Felicitaciones!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                conocerMuestras();
                                limpiarCalculosF();
                                if (dgv_listaPuntos.Rows.Count != 0)
                                {
                                    dgv_listaPuntos.DataSource = null;
                                    dgv_listaPuntos.Rows.Clear();
                                    dgv_listaPuntos.Refresh();
                                    lbl_muestra.Text = "";
                                }
                            }
                            catch (SqlException ex2)
                            {
                                MessageBox.Show(ex2.ToString());
                            }
                        }
                        else
                        {
                            MessageBox.Show("Los 'Cálculos' de la 'Muestra' que está intentando registrar, ya han sido registrados.", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                else
                {
                    MessageBox.Show("Usted está intentando registrar datos vacíos o no válidos. Recuerde que primero debe procesar los cálculos tras presionar el botón 'Calcular'.", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int posi_calculos = dataGridView1.CurrentRow.Index;
            string calculo = dataGridView1[0,posi_calculos].Value.ToString();

            SqlCommand consultaPuntos = new SqlCommand("SELECT DISTINCT dc.idPtoMed AS 'Punto de Medición' FROM detallesCalculo AS dc WHERE dc.codCalculo=" + calculo, Conexion);
            SqlDataAdapter ad_consultaPuntos = new SqlDataAdapter();
            ad_consultaPuntos.SelectCommand = consultaPuntos;
            DataTable dt_consultaPuntos = new DataTable();
            ad_consultaPuntos.Fill(dt_consultaPuntos);
            if (dgv_verCalculosPuntos.Rows.Count != 0)
            {
                dgv_verCalculosPuntos.DataSource = null;
                dgv_verCalculosPuntos.Rows.Clear();
                dgv_verCalculosPuntos.Refresh();
            }
            dgv_verCalculosPuntos.DataSource = dt_consultaPuntos;

            pBar_verCalculo.Visible = true;
            pBar_verCalculo.Maximum = dgv_verCalculosPuntos.Rows.Count;


            dgv_verCalculos.Visible = true;

            string punto = "";
            SqlCommand consultaCalculoPunto;
            SqlDataAdapter ad_consultaCalculoPunto;
            DataTable dt_consultaCalculoPunto;
            int x = dgv_verCalculosPuntos.Rows.Count;
            int contador = 0;
            if (dgv_verCalculos.Rows.Count != 0)
            {
                dgv_verCalculos.DataSource = null;
                dgv_verCalculos.Rows.Clear();
                dgv_verCalculos.Refresh();
            }
            foreach (DataGridViewRow fila in dgv_verCalculosPuntos.Rows)
            {
                dgv_verCalculos.Rows.Add(1);
                punto = fila.Cells[0].Value.ToString();
                dgv_verCalculos.Rows[contador].Cells[0].Value = punto;
                for (int i=1;i<=7;i++)
                {
                    consultaCalculoPunto = new SqlCommand("SELECT resultadoCalculo FROM detallesCalculo WHERE codCalculo=" + calculo +" AND idPtoMed='" + punto + "' AND codTipoCalculo="+i, Conexion);
                    ad_consultaCalculoPunto = new SqlDataAdapter();
                    ad_consultaCalculoPunto.SelectCommand = consultaCalculoPunto;
                    dt_consultaCalculoPunto = new DataTable();
                    ad_consultaCalculoPunto.Fill(dt_consultaCalculoPunto);
                    dgv_verCalculos.Rows[contador].Cells[i].Value = dt_consultaCalculoPunto.Rows[0][0].ToString();
                }
                contador++;
            }
            
            CultureInfo culture = new CultureInfo("en-US"); //
            decimal verde = decimal.Parse("1.33", culture);
            decimal amarillo = decimal.Parse("1.00", culture);
            decimal rojo = decimal.Parse("0.00", culture);
            decimal auxCp, auxCpk;

            foreach (DataGridViewRow fila in dgv_verCalculos.Rows)
            {
                auxCp = decimal.Parse(fila.Cells[4].Value.ToString(), System.Globalization.NumberStyles.AllowParentheses |
                 System.Globalization.NumberStyles.AllowLeadingWhite |
                 System.Globalization.NumberStyles.AllowTrailingWhite |
                 System.Globalization.NumberStyles.AllowThousands |
                 System.Globalization.NumberStyles.AllowDecimalPoint |
                 System.Globalization.NumberStyles.AllowLeadingSign);
                if (auxCp >= verde)
                {
                    fila.Cells[4].Style.ForeColor = Color.Green;
                }
                else
                {
                    if (auxCp < verde && auxCp >= amarillo)
                    {
                        fila.Cells[4].Style.ForeColor = Color.Yellow;
                    }
                    else
                    {
                        fila.Cells[4].Style.ForeColor = Color.Red;
                    }
                }

                 auxCpk = decimal.Parse(fila.Cells[7].Value.ToString(), System.Globalization.NumberStyles.AllowParentheses |
                  System.Globalization.NumberStyles.AllowLeadingWhite |
                  System.Globalization.NumberStyles.AllowTrailingWhite |
                  System.Globalization.NumberStyles.AllowThousands |
                  System.Globalization.NumberStyles.AllowDecimalPoint |
                  System.Globalization.NumberStyles.AllowLeadingSign);
                if (auxCpk >= verde)
                {
                    fila.Cells[7].Style.ForeColor = Color.Green;
                }
                else
                {
                    if (auxCpk < verde && auxCpk >= amarillo)
                    {
                        fila.Cells[7].Style.ForeColor = Color.Yellow;
                    }
                    else
                    {
                        fila.Cells[7].Style.ForeColor = Color.Red;
                    }
                }
            }

        }

        private void dgv_verCalculos_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            pBar_verCalculo.PerformStep();
            if (pBar_verCalculo.Value == pBar_verCalculo.Maximum)
            {
                pBar_verCalculo.Visible = false;
                pBar_verCalculo.Value = 0;
            }
        }

        private void btn_visorCalcGrafo_Click(object sender, EventArgs e)
        {
            Puntos2 = new ArrayList();
            Cp2 = new ArrayList();
            Cpk2 = new ArrayList();

            foreach (DataGridViewRow fila in dgv_verCalculos.Rows)
            {
                Puntos2.Add(fila.Cells[0].Value.ToString());
                Cp2.Add(decimal.Parse(fila.Cells[4].Value.ToString(), System.Globalization.NumberStyles.AllowParentheses |
                 System.Globalization.NumberStyles.AllowLeadingWhite |
                 System.Globalization.NumberStyles.AllowTrailingWhite |
                 System.Globalization.NumberStyles.AllowThousands |
                 System.Globalization.NumberStyles.AllowDecimalPoint |
                 System.Globalization.NumberStyles.AllowLeadingSign));
                Cpk2.Add(decimal.Parse(fila.Cells[7].Value.ToString(), System.Globalization.NumberStyles.AllowParentheses |
                 System.Globalization.NumberStyles.AllowLeadingWhite |
                 System.Globalization.NumberStyles.AllowTrailingWhite |
                 System.Globalization.NumberStyles.AllowThousands |
                 System.Globalization.NumberStyles.AllowDecimalPoint |
                 System.Globalization.NumberStyles.AllowLeadingSign));
            }

            string ventana = "Registrado";
            int posi_calculos = dataGridView1.CurrentRow.Index;
            string calculo2 = dataGridView1[0, posi_calculos].Value.ToString();

            CalculoGrafo cg = new CalculoGrafo(Cp2, Cpk2, Puntos2, ventana, calculo2);
            cg.ShowDialog();
        }

        private void rellenarListaPuntos(string muestra)
        {
            int aux_muestra = int.Parse(muestra);
            //SqlCommand listadoPuntos = new SqlCommand("SELECT DISTINCT idPtoMed AS 'Puntos de Medición' FROM detallesDocumentoDmo WHERE codDmo IN (SELECT codDmo FROM detalleMuestras WHERE codMuestra ='" + aux_muestra + "') AND idPtoMed IN(SELECT idPtoMed FROM detallesDocumentoDmo WHERE idPtoMed IN(SELECT idPtoMed FROM detallesControlPlan WHERE clasiTipoPto = 'F'))", Conexion);
            SqlCommand listadoPuntos = new SqlCommand("SELECT DISTINCT ddd.idPtoMed AS 'Puntos de Medición',dcp.clasiTipoPto AS 'Tipo de Punto' FROM detallesDocumentoDmo AS ddd INNER JOIN detallesControlPlan AS dcp ON dcp.idPtoMed = ddd.idPtoMed WHERE ddd.codDmo IN (SELECT codDmo FROM detalleMuestras WHERE codMuestra ='" + aux_muestra + "') AND ddd.idPtoMed IN(SELECT idPtoMed FROM detallesDocumentoDmo WHERE idPtoMed IN(SELECT idPtoMed FROM detallesControlPlan))", Conexion);
            ad_listadoPuntos = new SqlDataAdapter(listadoPuntos);

            DataTable dt_listadoPuntos = new DataTable();
            ad_listadoPuntos.Fill(dt_listadoPuntos);
            dgv_listaPuntos.DataSource = dt_listadoPuntos;

            ad_listadoPuntos.SelectCommand.Parameters.Clear();
        }

        private void obtenerNombrePuntos()
        {
            dgv_nombrePuntos.Columns.Add("nombrePuntos", "Nombre de Puntos");
            foreach (DataGridViewRow fila in dgv_listaPuntos.Rows)
            {
                dgv_nombrePuntos.Rows.Add(fila.Cells[0].Value.ToString());
            }
        }

        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Btn_calcular_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(lbl_muestra.Text))
            {
                MessageBox.Show("No se ha seleccionado ninguna 'Muestra' para comenzar con la realización de Cálculos.", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Puntos = new ArrayList();
                Cp = new ArrayList();
                Cpk = new ArrayList();

                btn_registrar.Enabled = false;
                btn_calcular.Enabled = false;
                cant_cpV = 0;
                cant_cpA = 0;
                cant_cpR = 0;
                cant_cpkV = 0;
                cant_cpkA = 0;
                cant_cpkR = 0; // cuenta la cantidad de CP o CPK en VERDE(V), AMARILLO(A), ROJO(R)
                suma_cpV = 0;
                suma_cpA = 0;
                suma_cpR = 0;
                suma_cpkV = 0;
                suma_cpkA = 0;
                suma_cpkR = 0; // acumula la suma de los valores CP o CPK en VERDE, AMARILLO y ROJO

                pBar_calcular.Visible = true;
                pBar_calcular.Maximum = dgv_nombrePuntos.Rows.Count;

                int posi = 0;
                string punto = "";
                string muestraCalcular = lbl_muestra.Text;
                if (dgv_calculos.Rows.Count != 0)
                {
                    dgv_calculos.Rows.Clear();
                }
                foreach (DataGridViewRow fila in dgv_nombrePuntos.Rows)
                {
                    punto = fila.Cells[0].Value.ToString();
                    rellenarDatosPuntoSeleccionado(punto, muestraCalcular);
                    dgv_calculos.Rows.Add(1);
                    calculosEstadisticos(posi, punto);
                    posi++;
                }
                panel_calculos.Visible = true;
                dgv_puntosF.Visible = true;

                txt_cpVerde.Visible = true;
                txt_cpAmarillo.Visible = true;
                txt_cpRojo.Visible = true;
                txt_cpkVerde.Visible = true;
                txt_cpkAmarillo.Visible = true;
                txt_cpkRojo.Visible = true;

                txt_cpvPorc.Visible = true;
                txt_cpaPorc.Visible = true;
                txt_cprPorc.Visible = true;
                txt_cpkvPorc.Visible = true;
                txt_cpkaPorc.Visible = true;
                txt_cpkrPorc.Visible = true;


                txt_muestraF.Text = lbl_muestra.Text;
                txt_cantidadF.Text = dgv_puntosF.Rows.Count.ToString();

                calculosF();
            }
        }

        private void rellenarDatosPuntoSeleccionado(string punto, string muestra)
        {
            char[] nombre = punto.ToCharArray();
            if (nombre[nombre.Length - 1] == 'D')
            {
                //SqlCommand datosPunto = new SqlCommand("SELECT pmd.codDmo AS 'Documento DMO',dd.fechaDmo AS 'Fecha DMO',pmd.nominalD AS 'Nominal',pmd.upTolD AS 'Tolerancia Sup.',pmd.medidoD AS 'Medido',pmd.loTolD AS 'Tolerancia Inf.' FROM puntosMedidosD AS pmd INNER JOIN documentosDmo AS dd ON dd.codDmo = pmd.codDmo WHERE pmd.codMediD IN (SELECT DISTINCT idPtoMed FROM detallesDocumentoDmo WHERE codDmo IN(SELECT codDmo FROM detalleMuestras WHERE codMuestra = '" + muestra + "') AND idPtoMed IN(SELECT idPtoMed FROM detallesDocumentoDmo WHERE idPtoMed IN(SELECT idPtoMed FROM detallesControlPlan WHERE clasiTipoPto = 'F')) AND idPtoMed = '" + punto + "') AND pmd.codDmo IN(SELECT codDmo FROM detalleMuestras WHERE codMuestra = '" + muestra + "')", Conexion);
                SqlCommand datosPunto = new SqlCommand("SELECT DISTINCT pmd.codDmo AS 'Documento DMO',dd.fechaDmo AS 'Fecha DMO',pmd.nominalD AS 'Nominal',pmd.upTolD AS 'Tolerancia Sup.',pmd.medidoD AS 'Medido',pmd.loTolD AS 'Tolerancia Inf.',pmd.desvD AS 'Desviación' FROM puntosMedidosD AS pmd INNER JOIN documentosDmo AS dd ON dd.codDmo = pmd.codDmo WHERE pmd.codMediD IN (SELECT DISTINCT idPtoMed FROM detallesDocumentoDmo WHERE codDmo IN(SELECT codDmo FROM detalleMuestras WHERE codMuestra = '" + muestra + "') AND idPtoMed IN(SELECT idPtoMed FROM detallesDocumentoDmo WHERE idPtoMed IN(SELECT idPtoMed FROM detallesControlPlan)) AND idPtoMed = '" + punto + "') AND pmd.codDmo IN(SELECT codDmo FROM detalleMuestras WHERE codMuestra = '" + muestra + "')", Conexion);
                ad_datosPunto = new SqlDataAdapter(datosPunto);

                DataTable dt_datosPunto = new DataTable();
                ad_datosPunto.Fill(dt_datosPunto);
                dgv_datosPunto.DataSource = dt_datosPunto;

                ad_datosPunto.SelectCommand.Parameters.Clear();
            }
            else
            {
                if (nombre[nombre.Length - 1] == 'X')
                {
                    //SqlCommand datosPunto = new SqlCommand("SELECT pmx.codDmo AS 'Documento DMO',dd.fechaDmo AS 'Fecha DMO',pmx.nominalX AS 'Nominal',pmx.upTolX AS 'Tolerancia Sup.',pmx.medidoX AS 'Medido',pmx.loTolX AS 'Tolerancia Inf.' FROM puntosMedidosX AS pmx INNER JOIN documentosDmo AS dd ON dd.codDmo = pmx.codDmo WHERE pmx.codMediX IN (SELECT DISTINCT idPtoMed FROM detallesDocumentoDmo WHERE codDmo IN(SELECT codDmo FROM detalleMuestras WHERE codMuestra = '" + muestra + "') AND idPtoMed IN(SELECT idPtoMed FROM detallesDocumentoDmo WHERE idPtoMed IN(SELECT idPtoMed FROM detallesControlPlan WHERE clasiTipoPto = 'F')) AND idPtoMed = '" + punto + "') AND pmx.codDmo IN(SELECT codDmo FROM detalleMuestras WHERE codMuestra = '" + muestra + "')", Conexion);
                    SqlCommand datosPunto = new SqlCommand("SELECT DISTINCT pmx.codDmo AS 'Documento DMO',dd.fechaDmo AS 'Fecha DMO',pmx.nominalX AS 'Nominal',pmx.upTolX AS 'Tolerancia Sup.',pmx.medidoX AS 'Medido',pmx.loTolX AS 'Tolerancia Inf.',pmx.desvX AS 'Desviación' FROM puntosMedidosX AS pmx INNER JOIN documentosDmo AS dd ON dd.codDmo = pmx.codDmo WHERE pmx.codMediX IN (SELECT DISTINCT idPtoMed FROM detallesDocumentoDmo WHERE codDmo IN(SELECT codDmo FROM detalleMuestras WHERE codMuestra = '" + muestra + "') AND idPtoMed IN(SELECT idPtoMed FROM detallesDocumentoDmo WHERE idPtoMed IN(SELECT idPtoMed FROM detallesControlPlan)) AND idPtoMed = '" + punto + "') AND pmx.codDmo IN(SELECT codDmo FROM detalleMuestras WHERE codMuestra = '" + muestra + "')", Conexion);
                    ad_datosPunto = new SqlDataAdapter(datosPunto);

                    DataTable dt_datosPunto = new DataTable();
                    ad_datosPunto.Fill(dt_datosPunto);
                    dgv_datosPunto.DataSource = dt_datosPunto;

                    ad_datosPunto.SelectCommand.Parameters.Clear();
                }
                else
                {
                    if (nombre[nombre.Length - 1] == 'Y')
                    {
                        //SqlCommand datosPunto = new SqlCommand("SELECT pmy.codDmo AS 'Documento DMO',dd.fechaDmo AS 'Fecha DMO',pmy.nominalY AS 'Nominal',pmy.upTolY AS 'Tolerancia Sup.',pmy.medidoY AS 'Medido',pmy.loTolY AS 'Tolerancia Inf.' FROM puntosMedidosY AS pmy INNER JOIN documentosDmo AS dd ON dd.codDmo = pmy.codDmo WHERE pmy.codMediY IN (SELECT DISTINCT idPtoMed FROM detallesDocumentoDmo WHERE codDmo IN(SELECT codDmo FROM detalleMuestras WHERE codMuestra = '" + muestra + "') AND idPtoMed IN(SELECT idPtoMed FROM detallesDocumentoDmo WHERE idPtoMed IN(SELECT idPtoMed FROM detallesControlPlan WHERE clasiTipoPto = 'F')) AND idPtoMed = '" + punto + "') AND pmy.codDmo IN(SELECT codDmo FROM detalleMuestras WHERE codMuestra = '" + muestra + "')", Conexion);
                        SqlCommand datosPunto = new SqlCommand("SELECT DISTINCT pmy.codDmo AS 'Documento DMO',dd.fechaDmo AS 'Fecha DMO',pmy.nominalY AS 'Nominal',pmy.upTolY AS 'Tolerancia Sup.',pmy.medidoY AS 'Medido',pmy.loTolY AS 'Tolerancia Inf.',pmy.desvY AS 'Desviación' FROM puntosMedidosY AS pmy INNER JOIN documentosDmo AS dd ON dd.codDmo = pmy.codDmo WHERE pmy.codMediY IN (SELECT DISTINCT idPtoMed FROM detallesDocumentoDmo WHERE codDmo IN(SELECT codDmo FROM detalleMuestras WHERE codMuestra = '" + muestra + "') AND idPtoMed IN(SELECT idPtoMed FROM detallesDocumentoDmo WHERE idPtoMed IN(SELECT idPtoMed FROM detallesControlPlan)) AND idPtoMed = '" + punto + "') AND pmy.codDmo IN(SELECT codDmo FROM detalleMuestras WHERE codMuestra = '" + muestra + "')", Conexion);
                        ad_datosPunto = new SqlDataAdapter(datosPunto);

                        DataTable dt_datosPunto = new DataTable();
                        ad_datosPunto.Fill(dt_datosPunto);
                        dgv_datosPunto.DataSource = dt_datosPunto;

                        ad_datosPunto.SelectCommand.Parameters.Clear();
                    }
                    else
                    {
                        //SqlCommand datosPunto = new SqlCommand("SELECT pmz.codDmo AS 'Documento DMO',dd.fechaDmo AS 'Fecha DMO',pmz.nominalZ AS 'Nominal',pmz.upTolZ AS 'Tolerancia Sup.',pmz.medidoZ AS 'Medido',pmz.loTolZ AS 'Tolerancia Inf.' FROM puntosMedidosZ AS pmz INNER JOIN documentosDmo AS dd ON dd.codDmo = pmz.codDmo WHERE pmz.codMediZ IN (SELECT DISTINCT idPtoMed FROM detallesDocumentoDmo WHERE codDmo IN(SELECT codDmo FROM detalleMuestras WHERE codMuestra = '" + muestra + "') AND idPtoMed IN(SELECT idPtoMed FROM detallesDocumentoDmo WHERE idPtoMed IN(SELECT idPtoMed FROM detallesControlPlan WHERE clasiTipoPto = 'F')) AND idPtoMed = '" + punto + "') AND pmz.codDmo IN(SELECT codDmo FROM detalleMuestras WHERE codMuestra = '" + muestra + "')", Conexion);
                        SqlCommand datosPunto = new SqlCommand("SELECT DISTINCT pmz.codDmo AS 'Documento DMO',dd.fechaDmo AS 'Fecha DMO',pmz.nominalZ AS 'Nominal',pmz.upTolZ AS 'Tolerancia Sup.',pmz.medidoZ AS 'Medido',pmz.loTolZ AS 'Tolerancia Inf.',pmz.desvZ AS 'Desviación' FROM puntosMedidosZ AS pmz INNER JOIN documentosDmo AS dd ON dd.codDmo = pmz.codDmo WHERE pmz.codMediZ IN (SELECT DISTINCT idPtoMed FROM detallesDocumentoDmo WHERE codDmo IN(SELECT codDmo FROM detalleMuestras WHERE codMuestra = '" + muestra + "') AND idPtoMed IN(SELECT idPtoMed FROM detallesDocumentoDmo WHERE idPtoMed IN(SELECT idPtoMed FROM detallesControlPlan)) AND idPtoMed = '" + punto + "') AND pmz.codDmo IN(SELECT codDmo FROM detalleMuestras WHERE codMuestra = '" + muestra + "')", Conexion);
                        ad_datosPunto = new SqlDataAdapter(datosPunto);

                        DataTable dt_datosPunto = new DataTable();
                        ad_datosPunto.Fill(dt_datosPunto);
                        dgv_datosPunto.DataSource = dt_datosPunto;

                        ad_datosPunto.SelectCommand.Parameters.Clear();
                    }
                }
            }
        }

        private void calculosEstadisticos(int punteroCalculos, string punto)
        {
            dgv_calculos.Rows[punteroCalculos].Cells[0].Value = punto;
            decimal suma = 0; // suma para sacar la media
            int posi = dgv_muestras.CurrentRow.Index;
            string aux_cantDmo = dgv_muestras[3, posi].Value.ToString();
            decimal cantDmo = decimal.Parse(aux_cantDmo);

            decimal[] rangos = new decimal[(int)cantDmo]; // recupero las desviaciones
            decimal[] resultados = new decimal[rangos.Length - 1]; // recuperar los rangos (max - min)
            int arrayRangos = 0; // puntero para recorrer []rangos

            SqlCommand tolerancias = new SqlCommand("SELECT TOP 1 codCPlan,tolinferior,tolSuperior FROM detallesControlPlan WHERE idPtoMed='"+punto+"' ORDER BY codCPlan DESC",Conexion);
            SqlDataAdapter ad_tolerancias = new SqlDataAdapter();
            ad_tolerancias.SelectCommand = tolerancias;
            DataTable dt_tolerancias = new DataTable();
            ad_tolerancias.Fill(dt_tolerancias);

            string aux_tolInf = dt_tolerancias.Rows[0][1].ToString();
            char[] aux1 = aux_tolInf.ToCharArray();
            aux1[aux1.Length-5] = '.';
            aux_tolInf = "";
            for(int i=0;i<aux1.Length;i++)
            {
                aux_tolInf += aux1[i];
            }

            string aux_tolSup = dt_tolerancias.Rows[0][2].ToString();
            char[] aux2 = aux_tolSup.ToCharArray();
            aux2[aux2.Length - 5] = '.';
            aux_tolSup = "";
            for (int i = 0; i < aux2.Length; i++)
            {
                aux_tolSup += aux2[i];
            }

            CultureInfo culture = new CultureInfo("en-US"); //

            decimal tolInf = 0, tolSup = 0;
            foreach (DataGridViewRow fila in dgv_datosPunto.Rows) // recorro los datos del punto en la muestra
            {
                tolSup = decimal.Parse(aux_tolSup,culture);
                suma += (decimal)fila.Cells[6].Value; // voy sumando los medidos para la media
                tolInf = decimal.Parse(aux_tolInf,culture);
                rangos[arrayRangos] = (decimal)fila.Cells[6].Value; // agrego desviacion al []rangos 
                arrayRangos++; // aumento el puntero
            }

            decimal auxMax, auxMin, auxRango; // auxiliares decimal
            int puntero1; // puntero
            int puntero2 = 1; // puntero
            int arrayResultados = 0; // puntero para recorrer []resultados
            for (puntero1 = 0; puntero1 <= rangos.Length - 2; puntero1++)
            {
                if (rangos[puntero1] > rangos[puntero2])
                {
                    auxMax = rangos[puntero1];
                    auxMin = rangos[puntero2];
                }
                else
                {
                    auxMax = rangos[puntero2];
                    auxMin = rangos[puntero1];
                }
                auxRango = auxMax - auxMin;
                resultados[arrayResultados] = auxRango;
                puntero2++;
                arrayResultados++;
            }

            int cantArray = 0; // contador para conocer la cantidad de valores en []resultados
            decimal sumaResultados = 0, mediaResultados = 0; // sumaResultados va acumulando los rangos; y mediaResultados va a contener el cálculo 2°
            for (int i = 0; i < resultados.Length; i++) // recorro []resultados
            {
                cantArray++; //aumento contador
                sumaResultados += resultados[i]; // acumulando en la variable sumaResultados, los valores de []resultados en la posición i
            }
            mediaResultados = sumaResultados / cantArray; // calculo la media (sumaResultados que ya tiene todo y cantArray que conto la cantidad de valores)
            dgv_calculos.Rows[punteroCalculos].Cells[1].Value = mediaResultados.ToString("0.0000"); // formato 4 decimales

            //decimal resultado = (suma / cantDmo); //calculo de la media
            double resultado = ((double)suma / (double)cantDmo); //calculo de la media
            dgv_calculos.Rows[punteroCalculos].Cells[2].Value = resultado.ToString("0.0000"); // formato 4 decimales

            decimal constante = (decimal)1.128;
            decimal sigma = mediaResultados / constante;
            dgv_calculos.Rows[punteroCalculos].Cells[3].Value = sigma.ToString("0.0000");

            decimal error = 0;
            string mensajeError = "Sigma = 0";
            if (sigma == error)
            {
                dgv_calculos.Rows[punteroCalculos].Cells[4].Value = mensajeError;
                dgv_calculos.Rows[punteroCalculos].Cells[5].Value = mensajeError;
                dgv_calculos.Rows[punteroCalculos].Cells[6].Value = mensajeError;
                dgv_calculos.Rows[punteroCalculos].Cells[7].Value = mensajeError;
            }
            else
            {
                decimal cp = (tolSup - tolInf) / (6 * sigma);
                dgv_calculos.Rows[punteroCalculos].Cells[4].Value = cp.ToString("0.0000");

                decimal cpkinf = ((decimal)resultado - tolInf) / (3 * sigma);
                dgv_calculos.Rows[punteroCalculos].Cells[5].Value = cpkinf.ToString("0.0000");

                decimal cpksup = (tolSup - (decimal)resultado) / (3 * sigma);
                dgv_calculos.Rows[punteroCalculos].Cells[6].Value = cpksup.ToString("0.0000");

                decimal cpk = 0;
                if (cpksup < cpkinf)
                {
                    cpk = cpksup;
                }
                else
                {
                    cpk = cpkinf;
                }
                dgv_calculos.Rows[punteroCalculos].Cells[7].Value = cpk.ToString("0.0000");
            }
        }
        //movimiento del panel (agregar el using interop)
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void Panel1_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void dgv_calculos_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            pBar_calcular.PerformStep();
            if (pBar_calcular.Value == pBar_calcular.Maximum)
            {
                pBar_calcular.Visible = false;
                pBar_calcular.Value = 0;
            }
        }
    }
}
