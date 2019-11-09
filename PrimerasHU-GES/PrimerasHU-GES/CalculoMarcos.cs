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

        string muestraSeleccionada = "";

        int cant_cpV = 0, cant_cpA = 0, cant_cpR = 0, cant_cpkV = 0, cant_cpkA = 0, cant_cpkR = 0; // cuenta la cantidad de CP o CPK en VERDE(V), AMARILLO(A), ROJO(R)
        decimal suma_cpV = 0, suma_cpA = 0, suma_cpR = 0, suma_cpkV = 0, suma_cpkA = 0, suma_cpkR = 0; // acumula la suma de los valores CP o CPK en VERDE, AMARILLO y ROJO

        private void CalculoMarcos_Load(object sender, EventArgs e)
        {
            dgv_datosPunto.Hide();
            dgv_nombrePuntos.Hide();

            Conexion = new SqlConnection("Data source=.\\SQLEXPRESS; Initial Catalog = ges_v01; Integrated Security = True");
            adaptador = new SqlDataAdapter();

            conocerMuestras();
            dgv_muestras.ClearSelection(); // >> esta linea deselecciona una fila del dgv_muestras, obliga al usuario a seleccionar si o si.
        }

        private void conocerMuestras()
        {
            SqlCommand muestrasNoGraf = new SqlCommand("SELECT codMuestra AS 'Código',fechaMuestra AS 'Fecha',obserMuestra AS 'Observaciones',cantidadDmo AS 'Cant. DMO' FROM muestras WHERE NOT EXISTS (SELECT codMuestra FROM graficos)", Conexion);
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
            dgv_puntosF.Visible = false;
            txt_cantidadF.Text = "";
            txt_muestraF.Text = "";
            txt_cpAmarillo.Text = "";
            txt_cpkAmarillo.Text = "";
            txt_cpkRojo.Text = "";
            txt_cpkVerde.Text = "";
            txt_cpVerde.Text = "";
            txt_cpRojo.Text = "";
        }

        private void Dgv_muestras_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            limpiarCalculosF();
            int posi_muestras = dgv_muestras.CurrentRow.Index;
            string aux_codMuestra = dgv_muestras[0, posi_muestras].Value.ToString();
            muestraSeleccionada = aux_codMuestra;
            rellenarListaPuntos(aux_codMuestra);
            lbl_muestra.Text = aux_codMuestra;
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

            CultureInfo culture = new CultureInfo("en-US");
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
                        i = dgv_puntosF.Rows.Count;
                        fila.DefaultCellStyle.BackColor = Color.LightGray;
                        //trabajo con CP y almaceno
                        auxCp = decimal.Parse(fila.Cells[4].Value.ToString(), System.Globalization.NumberStyles.AllowParentheses |
                 System.Globalization.NumberStyles.AllowLeadingWhite |
                 System.Globalization.NumberStyles.AllowTrailingWhite |
                 System.Globalization.NumberStyles.AllowThousands |
                 System.Globalization.NumberStyles.AllowDecimalPoint |
                 System.Globalization.NumberStyles.AllowLeadingSign);
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
                dgv_puntosF.Visible = true;

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
            decimal tolInf = 0, tolSup = 0;
            foreach (DataGridViewRow fila in dgv_datosPunto.Rows) // recorro los datos del punto en la muestra
            {
                tolSup = (decimal)fila.Cells[3].Value;
                suma += (decimal)fila.Cells[6].Value; // voy sumando los medidos para la media
                tolInf = (decimal)fila.Cells[5].Value;
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
