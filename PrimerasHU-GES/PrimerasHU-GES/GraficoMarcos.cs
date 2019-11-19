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
using System.Collections;
using System.Windows.Forms.DataVisualization.Charting;
using System.Runtime.InteropServices;
using System.IO;

namespace PrimerasHU_GES
{
    public partial class GraficoMarcos : Form
    {
        public GraficoMarcos()
        {
            InitializeComponent();
        }

        private SqlConnection Conexion;
        private SqlDataAdapter adaptador;
        private SqlDataAdapter ad_muestrasNoGraf;
        private SqlDataAdapter ad_detalleMuestraSeleccionada;
        private SqlDataAdapter ad_listadoPuntos;
        private SqlDataAdapter ad_datosPunto;

        string muestraSeleccionada = "";
        //string dmoSeleccionado = "";
        string puntoSeleccionado = "";

        string[] dmo;
        string[] puntos;

        string dmosSeleccionados = "";

        int series = 3;
        int grafico = 0;

        int series2 = 1;
        int grafico2 = 0;

        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void GraficoMarcos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'ges_v01DataSet18TiposGraficos.tiposGrafico' Puede moverla o quitarla según sea necesario.
            this.tiposGraficoTableAdapter.Fill(this.ges_v01DataSet18TiposGraficos.tiposGrafico);
            // TODO: esta línea de código carga datos en la tabla 'ges_v01DataSet18ClasifPto.clasificacionesPunto' Puede moverla o quitarla según sea necesario.
            this.clasificacionesPuntoTableAdapter.Fill(this.ges_v01DataSet18ClasifPto.clasificacionesPunto);
            // TODO: esta línea de código carga datos en la tabla 'ges_v01DataSetMuestrasGrafico.muestras' Puede moverla o quitarla según sea necesario.
            //this.muestrasTableAdapter.Fill(this.ges_v01DataSetMuestrasGrafico.muestras);

            Conexion = new SqlConnection("Data source=.\\SQLEXPRESS; Initial Catalog = ges_v01; Integrated Security = True");
            adaptador = new SqlDataAdapter();
            conocerMuestrasNoGraficadas();
            dgv_muestras.ClearSelection(); // >> esta linea deselecciona una fila del dgv_muestras, obliga al usuario a seleccionar si o si.
            check_agregar.Enabled = false;
            check_nominal.Enabled = false;
            check_tolInf.Enabled = false;
            check_tolSup.Enabled = false;
            btn_agregar.Enabled = false;
            btn_deshacer.Enabled = false;

            cb_dmoNombre.Enabled = false;
            cb_dmoNombre.Checked = false;
            txt_nombreDmo.Text = "";
            txt_nombreDmo.Enabled = false;
            cb_dmoSeccion.Enabled = false;
            cb_dmoSeccion.Checked = false;
            txt_seccionDmo.Text = "";
            txt_seccionDmo.Enabled = false;

            cb_muestraNombrePunto.Enabled = false;
            txt_puntoNombre.Text = "";
            cb_muestraNombrePunto.Checked = false;
            txt_puntoNombre.Enabled = false;
            cb_muestraTipoPunto.Enabled = false;
            cb_muestraTipoPunto.Checked = false;
            txt_tipoPunto.Enabled = false;
            txt_tipoPunto.Text = "";
        }


        private void rellenarDetalleMuestra(string muestra)
        {
            int aux_muestra = int.Parse(muestra);
            SqlCommand detalleMuestraSeleccionada = new SqlCommand("SELECT codDmo AS 'Documento DMO' FROM detalleMuestras WHERE codMuestra='" + aux_muestra + "'", Conexion);
            ad_detalleMuestraSeleccionada = new SqlDataAdapter(detalleMuestraSeleccionada);

            DataTable dt_detalleMuestraSeleccionada = new DataTable();
            ad_detalleMuestraSeleccionada.Fill(dt_detalleMuestraSeleccionada);
            dgv_detalleMuestra.DataSource = dt_detalleMuestraSeleccionada;

            ad_detalleMuestraSeleccionada.SelectCommand.Parameters.Clear();
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

        private void buscarPuntos(string punto, string muestra,string tipo)
        {
            string aux_tipo = tipo;
            string aux_punto = punto;
            int aux_muestra = int.Parse(muestra);
            //SqlCommand listadoPuntos = new SqlCommand("SELECT DISTINCT idPtoMed AS 'Puntos de Medición' FROM detallesDocumentoDmo WHERE codDmo IN (SELECT codDmo FROM detalleMuestras WHERE codMuestra ='" + aux_muestra + "') AND idPtoMed IN(SELECT idPtoMed FROM detallesDocumentoDmo WHERE idPtoMed IN(SELECT idPtoMed FROM detallesControlPlan WHERE clasiTipoPto = 'F'))", Conexion);
            SqlCommand listadoPuntos = new SqlCommand("SELECT DISTINCT ddd.idPtoMed AS 'Puntos de Medición',dcp.clasiTipoPto AS 'Tipo de Punto' FROM detallesDocumentoDmo AS ddd INNER JOIN detallesControlPlan AS dcp ON dcp.idPtoMed = ddd.idPtoMed WHERE ddd.codDmo IN (SELECT codDmo FROM detalleMuestras WHERE codMuestra ='" + aux_muestra + "') AND ddd.idPtoMed IN(SELECT idPtoMed FROM detallesDocumentoDmo WHERE idPtoMed IN(SELECT idPtoMed FROM detallesControlPlan WHERE clasiTipoPto LIKE '%"+aux_tipo+"%')) AND ddd.idPtoMed LIKE '%" + punto +"%'", Conexion);
            ad_listadoPuntos = new SqlDataAdapter(listadoPuntos);

            DataTable dt_listadoPuntos = new DataTable();
            ad_listadoPuntos.Fill(dt_listadoPuntos);
            dgv_listaPuntos.DataSource = dt_listadoPuntos;

            ad_listadoPuntos.SelectCommand.Parameters.Clear();
        }

        private void rellenarDatosPuntoSeleccionado(string punto, string muestra)
        {
            char[] nombre = punto.ToCharArray();
            if (nombre[nombre.Length - 1] == 'D')
            {
                //SqlCommand datosPunto = new SqlCommand("SELECT pmd.codDmo AS 'Documento DMO',dd.fechaDmo AS 'Fecha DMO',pmd.nominalD AS 'Nominal',pmd.upTolD AS 'Tolerancia Sup.',pmd.medidoD AS 'Medido',pmd.loTolD AS 'Tolerancia Inf.' FROM puntosMedidosD AS pmd INNER JOIN documentosDmo AS dd ON dd.codDmo = pmd.codDmo WHERE pmd.codMediD IN (SELECT DISTINCT idPtoMed FROM detallesDocumentoDmo WHERE codDmo IN(SELECT codDmo FROM detalleMuestras WHERE codMuestra = '" + muestra + "') AND idPtoMed IN(SELECT idPtoMed FROM detallesDocumentoDmo WHERE idPtoMed IN(SELECT idPtoMed FROM detallesControlPlan WHERE clasiTipoPto = 'F')) AND idPtoMed = '" + punto + "') AND pmd.codDmo IN(SELECT codDmo FROM detalleMuestras WHERE codMuestra = '" + muestra + "')", Conexion);
                SqlCommand datosPunto = new SqlCommand("SELECT pmd.codDmo AS 'Documento DMO',dd.fechaDmo AS 'Fecha DMO',pmd.nominalD AS 'Nominal',pmd.upTolD AS 'Tolerancia Sup.',pmd.medidoD AS 'Medido',pmd.loTolD AS 'Tolerancia Inf.',pmd.desvD AS 'Desviación' FROM puntosMedidosD AS pmd INNER JOIN documentosDmo AS dd ON dd.codDmo = pmd.codDmo WHERE pmd.codMediD IN (SELECT DISTINCT idPtoMed FROM detallesDocumentoDmo WHERE codDmo IN(SELECT codDmo FROM detalleMuestras WHERE codMuestra = '" + muestra + "') AND idPtoMed IN(SELECT idPtoMed FROM detallesDocumentoDmo WHERE idPtoMed IN(SELECT idPtoMed FROM detallesControlPlan)) AND idPtoMed = '" + punto + "') AND pmd.codDmo IN(SELECT codDmo FROM detalleMuestras WHERE codMuestra = '" + muestra + "')", Conexion);
                ad_datosPunto = new SqlDataAdapter(datosPunto);

                DataTable dt_datosPunto = new DataTable();
                ad_datosPunto.Fill(dt_datosPunto);
                dgv_datosGrafico.DataSource = dt_datosPunto;

                ad_datosPunto.SelectCommand.Parameters.Clear();
            }
            else
            {
                if (nombre[nombre.Length - 1] == 'X')
                {
                    //SqlCommand datosPunto = new SqlCommand("SELECT pmx.codDmo AS 'Documento DMO',dd.fechaDmo AS 'Fecha DMO',pmx.nominalX AS 'Nominal',pmx.upTolX AS 'Tolerancia Sup.',pmx.medidoX AS 'Medido',pmx.loTolX AS 'Tolerancia Inf.' FROM puntosMedidosX AS pmx INNER JOIN documentosDmo AS dd ON dd.codDmo = pmx.codDmo WHERE pmx.codMediX IN (SELECT DISTINCT idPtoMed FROM detallesDocumentoDmo WHERE codDmo IN(SELECT codDmo FROM detalleMuestras WHERE codMuestra = '" + muestra + "') AND idPtoMed IN(SELECT idPtoMed FROM detallesDocumentoDmo WHERE idPtoMed IN(SELECT idPtoMed FROM detallesControlPlan WHERE clasiTipoPto = 'F')) AND idPtoMed = '" + punto + "') AND pmx.codDmo IN(SELECT codDmo FROM detalleMuestras WHERE codMuestra = '" + muestra + "')", Conexion);
                    SqlCommand datosPunto = new SqlCommand("SELECT pmx.codDmo AS 'Documento DMO',dd.fechaDmo AS 'Fecha DMO',pmx.nominalX AS 'Nominal',pmx.upTolX AS 'Tolerancia Sup.',pmx.medidoX AS 'Medido',pmx.loTolX AS 'Tolerancia Inf.',pmx.desvX AS 'Desviación' FROM puntosMedidosX AS pmx INNER JOIN documentosDmo AS dd ON dd.codDmo = pmx.codDmo WHERE pmx.codMediX IN (SELECT DISTINCT idPtoMed FROM detallesDocumentoDmo WHERE codDmo IN(SELECT codDmo FROM detalleMuestras WHERE codMuestra = '" + muestra + "') AND idPtoMed IN(SELECT idPtoMed FROM detallesDocumentoDmo WHERE idPtoMed IN(SELECT idPtoMed FROM detallesControlPlan)) AND idPtoMed = '" + punto + "') AND pmx.codDmo IN(SELECT codDmo FROM detalleMuestras WHERE codMuestra = '" + muestra + "')", Conexion);
                    ad_datosPunto = new SqlDataAdapter(datosPunto);

                    DataTable dt_datosPunto = new DataTable();
                    ad_datosPunto.Fill(dt_datosPunto);
                    dgv_datosGrafico.DataSource = dt_datosPunto;

                    ad_datosPunto.SelectCommand.Parameters.Clear();
                }
                else
                {
                    if (nombre[nombre.Length - 1] == 'Y')
                    {
                        //SqlCommand datosPunto = new SqlCommand("SELECT pmy.codDmo AS 'Documento DMO',dd.fechaDmo AS 'Fecha DMO',pmy.nominalY AS 'Nominal',pmy.upTolY AS 'Tolerancia Sup.',pmy.medidoY AS 'Medido',pmy.loTolY AS 'Tolerancia Inf.' FROM puntosMedidosY AS pmy INNER JOIN documentosDmo AS dd ON dd.codDmo = pmy.codDmo WHERE pmy.codMediY IN (SELECT DISTINCT idPtoMed FROM detallesDocumentoDmo WHERE codDmo IN(SELECT codDmo FROM detalleMuestras WHERE codMuestra = '" + muestra + "') AND idPtoMed IN(SELECT idPtoMed FROM detallesDocumentoDmo WHERE idPtoMed IN(SELECT idPtoMed FROM detallesControlPlan WHERE clasiTipoPto = 'F')) AND idPtoMed = '" + punto + "') AND pmy.codDmo IN(SELECT codDmo FROM detalleMuestras WHERE codMuestra = '" + muestra + "')", Conexion);
                        SqlCommand datosPunto = new SqlCommand("SELECT pmy.codDmo AS 'Documento DMO',dd.fechaDmo AS 'Fecha DMO',pmy.nominalY AS 'Nominal',pmy.upTolY AS 'Tolerancia Sup.',pmy.medidoY AS 'Medido',pmy.loTolY AS 'Tolerancia Inf.',pmy.desvY AS 'Desviación' FROM puntosMedidosY AS pmy INNER JOIN documentosDmo AS dd ON dd.codDmo = pmy.codDmo WHERE pmy.codMediY IN (SELECT DISTINCT idPtoMed FROM detallesDocumentoDmo WHERE codDmo IN(SELECT codDmo FROM detalleMuestras WHERE codMuestra = '" + muestra + "') AND idPtoMed IN(SELECT idPtoMed FROM detallesDocumentoDmo WHERE idPtoMed IN(SELECT idPtoMed FROM detallesControlPlan)) AND idPtoMed = '" + punto + "') AND pmy.codDmo IN(SELECT codDmo FROM detalleMuestras WHERE codMuestra = '" + muestra + "')", Conexion);
                        ad_datosPunto = new SqlDataAdapter(datosPunto);

                        DataTable dt_datosPunto = new DataTable();
                        ad_datosPunto.Fill(dt_datosPunto);
                        dgv_datosGrafico.DataSource = dt_datosPunto;

                        ad_datosPunto.SelectCommand.Parameters.Clear();
                    }
                    else
                    {
                        //SqlCommand datosPunto = new SqlCommand("SELECT pmz.codDmo AS 'Documento DMO',dd.fechaDmo AS 'Fecha DMO',pmz.nominalZ AS 'Nominal',pmz.upTolZ AS 'Tolerancia Sup.',pmz.medidoZ AS 'Medido',pmz.loTolZ AS 'Tolerancia Inf.' FROM puntosMedidosZ AS pmz INNER JOIN documentosDmo AS dd ON dd.codDmo = pmz.codDmo WHERE pmz.codMediZ IN (SELECT DISTINCT idPtoMed FROM detallesDocumentoDmo WHERE codDmo IN(SELECT codDmo FROM detalleMuestras WHERE codMuestra = '" + muestra + "') AND idPtoMed IN(SELECT idPtoMed FROM detallesDocumentoDmo WHERE idPtoMed IN(SELECT idPtoMed FROM detallesControlPlan WHERE clasiTipoPto = 'F')) AND idPtoMed = '" + punto + "') AND pmz.codDmo IN(SELECT codDmo FROM detalleMuestras WHERE codMuestra = '" + muestra + "')", Conexion);
                        SqlCommand datosPunto = new SqlCommand("SELECT pmz.codDmo AS 'Documento DMO',dd.fechaDmo AS 'Fecha DMO',pmz.nominalZ AS 'Nominal',pmz.upTolZ AS 'Tolerancia Sup.',pmz.medidoZ AS 'Medido',pmz.loTolZ AS 'Tolerancia Inf.',pmz.desvZ AS 'Desviación' FROM puntosMedidosZ AS pmz INNER JOIN documentosDmo AS dd ON dd.codDmo = pmz.codDmo WHERE pmz.codMediZ IN (SELECT DISTINCT idPtoMed FROM detallesDocumentoDmo WHERE codDmo IN(SELECT codDmo FROM detalleMuestras WHERE codMuestra = '" + muestra + "') AND idPtoMed IN(SELECT idPtoMed FROM detallesDocumentoDmo WHERE idPtoMed IN(SELECT idPtoMed FROM detallesControlPlan)) AND idPtoMed = '" + punto + "') AND pmz.codDmo IN(SELECT codDmo FROM detalleMuestras WHERE codMuestra = '" + muestra + "')", Conexion);
                        ad_datosPunto = new SqlDataAdapter(datosPunto);

                        DataTable dt_datosPunto = new DataTable();
                        ad_datosPunto.Fill(dt_datosPunto);
                        dgv_datosGrafico.DataSource = dt_datosPunto;

                        ad_datosPunto.SelectCommand.Parameters.Clear();
                    }
                }
            }
        }

        private void conocerMuestrasNoGraficadas()
        {
            //SqlCommand muestrasNoGraf = new SqlCommand("SELECT codMuestra AS 'Código',fechaMuestra AS 'Fecha',obserMuestra AS 'Observaciones',cantidadDmo AS 'Cant. DMO' FROM muestras WHERE NOT EXISTS (SELECT codMuestra FROM graficos)", Conexion);
            SqlCommand muestrasNoGraf = new SqlCommand("SELECT m.codMuestra AS 'Código',m.fechaMuestra AS 'Fecha',tm.descTiposMuestra AS 'Tipo de Muestra',m.cantidadDmo AS 'Cant. DMO' FROM muestras AS m JOIN tiposMuestra AS tm ON tm.codTiposMuestra=m.codTiposMuestra", Conexion);
            ad_muestrasNoGraf = new SqlDataAdapter(muestrasNoGraf);
            DataTable dt_muestrasNoGraf = new DataTable();
            ad_muestrasNoGraf.Fill(dt_muestrasNoGraf);
            dgv_muestras.DataSource = dt_muestrasNoGraf;

            ad_muestrasNoGraf.SelectCommand.Parameters.Clear();
        }

        private void Dgv_muestras_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            cb_muestraNombrePunto.Enabled = true;
            cb_muestraTipoPunto.Enabled = true;
            int posi_muestras = dgv_muestras.CurrentRow.Index;
            string aux_codMuestra = dgv_muestras[0, posi_muestras].Value.ToString();
            muestraSeleccionada = aux_codMuestra;
            rellenarDetalleMuestra(aux_codMuestra);
            rellenarListaPuntos(aux_codMuestra);
            lbl_muestra.Text = aux_codMuestra;
        }

        private void Btn_graficar_Click(object sender, EventArgs e) //graficoDocDmo
        {
            check_nominal.Enabled = true;
            check_tolInf.Enabled = true;
            check_tolSup.Enabled = true;
            check_agregar.Enabled = true;
            if (string.IsNullOrEmpty(lbl_muestra.Text))
            {
                MessageBox.Show("No se ha seleccionado ninguna 'Muestra' para comenzar con la generación del Gráfico.", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (string.IsNullOrEmpty(lbl_PuntoSeleccionado.Text))
                {
                    MessageBox.Show("No se ha seleccionado ningún 'Punto' para comenzar con la generación del Gráfico.", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    ArrayList DocumentosDmo = new ArrayList();
                    ArrayList TolSup = new ArrayList();
                    ArrayList Valores = new ArrayList();
                    ArrayList TolInf = new ArrayList();
                    ArrayList Nominal = new ArrayList();

                    string aux_fecha = "";
                    string aux_dmo = "";
                    string aux_final = "";
                    decimal aux_nominal, aux_tolSup, aux_tolInf, aux_desviacion;
                    decimal mayor = 0, menor = 0;

                    /**
                    foreach(DataGridViewRow fila in dgv_datosGrafico.Rows) //recorro el datagridview que contiene los valores
                    {
                        aux_dmo = fila.Cells[0].Value.ToString();
                        aux_fecha =  fila.Cells[1].Value.ToString();
                        aux_final = aux_dmo + "\n" + aux_fecha;
                        DocumentosDmo.Add(aux_final); //inserto los datos de los dmo en el arraylist
                        Nominal.Add(fila.Cells[2].Value);
                        aux_nominal = (decimal) fila.Cells[2].Value;
                        aux_tolSup = aux_nominal + (decimal) fila.Cells[3].Value;
                        TolSup.Add(aux_tolSup);
                        Valores.Add(fila.Cells[4].Value); //inserto los datos de los valores en el arraylist
                        aux_tolInf = aux_nominal + (decimal) fila.Cells[5].Value;
                        TolInf.Add(aux_tolInf);
                        mayor = aux_tolSup;
                        menor = aux_tolInf;
                        if ((decimal)fila.Cells[4].Value > mayor)
                        {
                            mayor = (decimal) fila.Cells[4].Value;
                        }
                        else
                        {
                            if ((decimal)fila.Cells[4].Value < menor)
                            {
                                menor = (decimal) fila.Cells[4].Value;
                            }
                        }
                    }

                    decimal aux_mayor = mayor + (decimal) 3;
                    decimal aux_menor = menor - (decimal) 3;

                    chart_Puntos.ChartAreas[0].AxisY.Minimum = (double) aux_menor;
                    chart_Puntos.ChartAreas[0].AxisY.Maximum = (double) aux_mayor;

                    chart_Puntos.Series[0].Points.DataBindY(TolSup);
                    chart_Puntos.Series[1].Points.DataBindY(TolInf);
                    chart_Puntos.Series[2].Points.DataBindY(Nominal);
                    chart_Puntos.Series[3].Points.DataBindXY(DocumentosDmo, Valores); //asigno valor de punto en cada dmo en el grafico a través de los arraylist

                    //MessageBox.Show("ESTE MENSAJE ES DE PRUEBA SOLO PARA CONTROL: \n" + "Mayor: " + mayor + "\n" + "Menor: " + menor + "\n" + "Lím. Mayor: " + aux_mayor + "\n" + "Lím. Menor: " + aux_menor);
                    **/

                    foreach (DataGridViewRow fila in dgv_datosGrafico.Rows) //recorro el datagridview que contiene los valores
                    {
                        char [] array = fila.Cells[0].Value.ToString().ToCharArray();
                        aux_dmo = array[array.Length - 3].ToString() + array[array.Length - 2].ToString() + array[array.Length-1].ToString();
                        aux_fecha = fila.Cells[1].Value.ToString();
                        DateTime fecha = DateTime.Parse(aux_fecha);
                        aux_final = "DMO: " + aux_dmo + "\n" + "Fecha: " + fecha.ToString("d");
                        DocumentosDmo.Add(aux_final); //inserto los datos de los dmo en el arraylist
                        Nominal.Add((decimal)0);
                        TolSup.Add(fila.Cells[3].Value);
                        aux_desviacion = (decimal)0 + (decimal)fila.Cells[6].Value;
                        Valores.Add(aux_desviacion); //inserto los datos de los valores en el arraylist
                        TolInf.Add(fila.Cells[5].Value);
                    }
                    if (grafico != 0)
                    {
                        chart_Puntos.Series.RemoveAt(series);
                    }

                    chart_Puntos.Series[0].Points.DataBindY(TolSup);
                    chart_Puntos.Series[1].Points.DataBindY(TolInf);
                    chart_Puntos.Series[2].Points.DataBindXY(DocumentosDmo,Nominal);
                    chart_Puntos.Series.Add(lbl_PuntoSeleccionado.Text);
                    chart_Puntos.Series[series].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                    chart_Puntos.Series[series].BorderWidth = 2;
                    chart_Puntos.Series[series].Points.DataBindY(Valores); //asigno valor de punto en cada dmo en el grafico a través de los arraylist
                    
                    chart_Puntos.Series[series].ToolTip = "#VAL";
                    chart_Puntos.Series[series].MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
                    chart_Puntos.Series[series].MarkerSize = 5;

                    grafico = 1;
                }
            }
        }

        private void Dgv_listaPuntos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int posi_listaPuntos = dgv_listaPuntos.CurrentRow.Index;
            string aux_puntoSeleccionado = dgv_listaPuntos[0, posi_listaPuntos].Value.ToString();
            lbl_PuntoSeleccionado.Text = aux_puntoSeleccionado;
            puntoSeleccionado = aux_puntoSeleccionado;
            rellenarDatosPuntoSeleccionado(puntoSeleccionado, muestraSeleccionada);
        }

        private void Btn_calcular_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(lbl_muestra.Text))
            {
                MessageBox.Show("No se ha seleccionado ninguna 'Muestra' para comenzar con los cálculos.", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (string.IsNullOrEmpty(lbl_PuntoSeleccionado.Text))
                {
                    MessageBox.Show("No se ha seleccionado ningún 'Punto' para comenzar con los cálculos.", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    decimal suma = 0; // suma para sacar la media
                    int posi = dgv_muestras.CurrentRow.Index;
                    string aux_cantDmo = dgv_muestras[3, posi].Value.ToString();
                    decimal cantDmo = decimal.Parse(aux_cantDmo);

                    decimal[] rangos = new decimal[(int)cantDmo]; // recupero las desviaciones
                    decimal[] resultados = new decimal[rangos.Length - 1]; // recuperar los rangos (max - min)
                    int arrayRangos = 0; // puntero para recorrer []rangos
                    decimal tolInf = 0, tolSup = 0;
                    foreach (DataGridViewRow fila in dgv_datosGrafico.Rows) // recorro los datos del punto en la muestra
                    {
                        tolSup = (decimal)fila.Cells[3].Value;
                        suma += (decimal)fila.Cells[6].Value; // voy sumando las desviaciones para la media
                        tolInf = (decimal)fila.Cells[5].Value;
                        rangos[arrayRangos] = (decimal)fila.Cells[6].Value; // agrego desviacion al []rangos 
                        arrayRangos++; // aumento el puntero
                    }

                    decimal auxMax, auxMin, auxRango; // auxiliares decimal
                    int puntero1; // puntero
                    int puntero2 = 1; // puntero
                    int arrayResultados = 0; // puntero para recorrer []resultados
                    string mensajes = "Arreglo de Rangos para comprobar el calculo 2" + "\n";
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

                        //la siguiente linea es para controlar se debe comentar
                        //mensajes += puntero1 + 1 + " > Máximo: " + auxMax + "- Mínimo: " + auxMin + "- Diferencia:" + auxRango + "\n";

                        resultados[arrayResultados] = auxRango;
                        puntero2++;
                        arrayResultados++;
                    }
                    //HASTA ACA SOLO LLENO ARRAYS []rangos y []resultados

                    int cantArray = 0; // contador para conocer la cantidad de valores en []resultados
                    decimal sumaResultados = 0, mediaResultados = 0; // sumaResultados va acumulando los rangos; y mediaResultados va a contener el cálculo 2°
                    for (int i = 0; i < resultados.Length; i++) // recorro []resultados
                    {
                        cantArray++; //aumento contador
                        sumaResultados += resultados[i]; // acumulando en la variable sumaResultados, los valores de []resultados en la posición i
                    }

                    mediaResultados = sumaResultados / cantArray; // calculo la media (sumaResultados que ya tiene todo y cantArray que conto la cantidad de valores)
                    txt_rangoFlotante.Text = mediaResultados.ToString("0.0000"); // formato 4 decimales
                    mensajes += "Cantidad de Rangos: " + cantArray;

                    double resultado = (double)suma / (double)cantDmo; //calculo de la media
                    txt_media.Text = resultado.ToString("0.0000"); // formato 4 decimales

                    decimal constante = (decimal)1.128;
                    decimal sigma = mediaResultados / constante;
                    txt_sigma.Text = sigma.ToString("0.0000");

                    decimal cp = (tolSup - tolInf) / (6 * sigma);
                    txt_cp.Text = cp.ToString("0.0000");

                    decimal cpkinf = ((decimal)resultado - tolInf) / (3 * sigma);
                    txt_cpkinf.Text = cpkinf.ToString("0.0000");

                    decimal cpksup = (tolSup - (decimal)resultado) / (3 * sigma);
                    txt_cpksup.Text = cpksup.ToString("0.0000");

                    decimal cpk = 0;
                    if (cpksup < cpkinf)
                    {
                        cpk = cpksup;
                    }
                    else
                    {
                        cpk = cpkinf;
                    }
                    txt_cpk.Text = cpk.ToString("0.0000");

                    //MessageBox.Show(mensajes); // muestro el mensaje de control
                }
            }
        }

        private void Check_tolInf_CheckedChanged(object sender, EventArgs e)
        {
            if (check_tolInf.Checked == true)
            {
                chart_Puntos.Series[1].Enabled = false;
            }
            else
            {
                chart_Puntos.Series[1].Enabled = true;
            }
        }

        private void Check_tolSup_CheckedChanged(object sender, EventArgs e)
        {
            if (check_tolSup.Checked == true)
            {
                chart_Puntos.Series[0].Enabled = false;
            }
            else
            {
                chart_Puntos.Series[0].Enabled = true;
            }
        }

        private void Check_nominal_CheckedChanged(object sender, EventArgs e)
        {
            if (check_nominal.Checked == true)
            {
                chart_Puntos.Series[2].Enabled = false;
            }
            else
            {
                chart_Puntos.Series[2].Enabled = true;
            }
        }

        private void Check_agregar_CheckedChanged(object sender, EventArgs e)
        {
            if (check_agregar.Checked == true)
            {
                txt_valorDmo.Visible = false;
                txt_valorFecha.Visible = false;
                btn_graficar.Enabled = false;
                btn_calcular.Enabled = false;
                check_nominal.Enabled = false;
                check_tolInf.Checked = true;
                check_tolInf.Enabled = false;
                check_tolSup.Checked = true;
                check_tolSup.Enabled = false;
                btn_agregar.Enabled = true;
            }
            else
            {
                btn_calcular.Enabled = true;
                btn_graficar.Enabled = true;
                btn_agregar.Enabled = false;
                btn_deshacer.Enabled = false;
            }
        }

        private void Btn_agregar_Click(object sender, EventArgs e)
        {
            ChartNamedElement existe = chart_Puntos.Series.FindByName(lbl_PuntoSeleccionado.Text);
            if (existe != null)
            {
                MessageBox.Show("No puede agregar un al gráfico un 'Punto' ya existente", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                series++;
                btn_deshacer.Enabled = true;
                ArrayList Nuevo = new ArrayList();

                foreach (DataGridViewRow fila in dgv_datosGrafico.Rows) //recorro el datagridview que contiene los valores
                {
                    Nuevo.Add((decimal)0 + (decimal)fila.Cells[6].Value);
                }

                chart_Puntos.Series.Add(lbl_PuntoSeleccionado.Text);
                chart_Puntos.Series[series].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                chart_Puntos.Series[series].BorderWidth = 2;
                chart_Puntos.Series[series].Points.DataBindY(Nuevo);

                chart_Puntos.Series[series].ToolTip = "#VAL";
                chart_Puntos.Series[series].MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
                chart_Puntos.Series[series].MarkerSize = 5;
            }
        }

        private void Btn_deshacer_Click(object sender, EventArgs e)
        {
            chart_Puntos.Series.RemoveAt(series);
            if (series > 3)
            {
                series--;
            }
            else
            {
                MessageBox.Show("No tiene más 'Puntos' graficados por quitar.","Atención!",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                series = 3;
                check_agregar.Checked = false;
                check_agregar.Enabled = false;
                check_nominal.Checked = false;
                check_nominal.Enabled = false;
                check_tolInf.Checked = false;
                check_tolInf.Enabled = false;
                check_tolSup.Checked = false;
                check_tolSup.Enabled = false;
                chart_Puntos.Series[0].Points.Clear();
                chart_Puntos.Series[1].Points.Clear();
                chart_Puntos.Series[2].Points.Clear();
                grafico = 0;
                txt_valorDmo.Visible = true;
                txt_valorFecha.Visible = true;
            }
        }

        private void txt_puntoNombre_TextChanged(object sender, EventArgs e)
        {
            string param_muestra = lbl_muestra.Text;
            string param_punto = txt_puntoNombre.Text;
            string param_tipo = txt_tipoPunto.Text;
            buscarPuntos(param_punto,param_muestra,param_tipo);
        }

        private void btn_verDmo_Click(object sender, EventArgs e)
        {
            cb_dmoNombre.Enabled = true;
            cb_dmoSeccion.Enabled = true;
            SqlCommand cmd = new SqlCommand ("SELECT sv.descSeccion AS 'Sección', dd.codDmo AS 'Código', dd.chasisDmo AS 'Chasis Nro.', dd.fechaDmo AS 'Fecha', dd.hora AS 'Hora' FROM documentosDmo AS dd INNER JOIN controlPlan AS cp ON cp.codCPlan = dd.codCPlan INNER JOIN seccionesVehiculo AS sv ON sv.codSeccion = cp.codSeccion",Conexion);
            adaptador.SelectCommand = cmd;
            DataTable dt_docDmo = new DataTable();
            adaptador.Fill(dt_docDmo);
            dgv_docDmo.DataSource = dt_docDmo;
        }

        private void lbl_PuntoSeleccionado_TextChanged(object sender, EventArgs e)
        {
            txt_rangoFlotante.Text = "";
            txt_sigma.Text = "";
            txt_media.Text = "";
            txt_cpksup.Text = "";
            txt_cpkinf.Text = "";
            txt_cpk.Text = "";
            txt_cp.Text = "";
        }

        private void chart_Puntos_GetToolTipText(object sender, ToolTipEventArgs e)
        {
            if (e.HitTestResult.ChartElementType == System.Windows.Forms.DataVisualization.Charting.ChartElementType.DataPoint)
            {
                txt_Valor.Text = e.Text;
                string dmo = "DMO: ";
                string fecha = "";
                string fechaMostrar = "Fecha: ";
                foreach (DataGridViewRow fila in dgv_datosGrafico.Rows)
                {
                    if (fila.Cells[6].Value.ToString().Equals(e.Text))
                    {
                        char[] aux = fila.Cells[0].Value.ToString().ToCharArray();
                        dmo += aux[aux.Length-3].ToString() + aux[aux.Length - 2].ToString() + aux[aux.Length - 1].ToString();
                        fecha = fila.Cells[1].Value.ToString();
                        DateTime auxfecha = DateTime.Parse(fecha);
                        fechaMostrar += auxfecha.ToString("d");
                    }
                }
                txt_valorDmo.Text = dmo;
                txt_valorFecha.Text = fechaMostrar;
            }
            else if (txt_Valor.Text != string.Empty)
            {
                txt_Valor.Text = string.Empty;
                txt_valorDmo.Text = string.Empty;
                txt_valorFecha.Text = string.Empty;
            }
        }

        private void txt_nombreDmo_TextChanged(object sender, EventArgs e)
        {
            string dmo = txt_nombreDmo.Text;
            string seccion = txt_seccionDmo.Text;
            buscarNombreDmo(dmo,seccion);
        }

        private void buscarNombreDmo(string dmo,string seccion)
        {
            SqlCommand cmd = new SqlCommand("SELECT sv.descSeccion AS 'Sección', dd.codDmo AS 'Código', dd.chasisDmo AS 'Chasis Nro.', dd.fechaDmo AS 'Fecha', dd.hora AS 'Hora' FROM documentosDmo AS dd INNER JOIN controlPlan AS cp ON cp.codCPlan = dd.codCPlan INNER JOIN seccionesVehiculo AS sv ON sv.codSeccion = cp.codSeccion WHERE dd.codDmo LIKE '%" + dmo + "%' AND sv.descSeccion LIKE '%" + seccion + "%'", Conexion);
            ad_listadoPuntos = new SqlDataAdapter(cmd);

            DataTable dt_listadoDmo = new DataTable();
            ad_listadoPuntos.Fill(dt_listadoDmo);
            dgv_docDmo.DataSource = dt_listadoDmo;

            ad_listadoPuntos.SelectCommand.Parameters.Clear();
        }

        private void txt_seccionDmo_TextChanged(object sender, EventArgs e)
        {
            string dmo = txt_nombreDmo.Text;
            string seccion = txt_seccionDmo.Text;
            buscarNombreDmo(dmo, seccion);
        }

        private void cb_dmoNombre_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_dmoNombre.Checked == false)
            {
                txt_nombreDmo.Text = "";
                txt_nombreDmo.Enabled = false;
            }
            else
            {
                txt_nombreDmo.Text = "";
                txt_nombreDmo.Enabled = true;
            }
        }

        private void cb_dmoSeccion_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_dmoSeccion.Checked == false)
            {
                txt_seccionDmo.Text = "";
                txt_seccionDmo.Enabled = false;
            }
            else
            {
                txt_seccionDmo.Text = "";
                txt_seccionDmo.Enabled = true;
            }
        }

        private void btn_conocerPuntos_Click(object sender, EventArgs e)
        {
            int contador = 0; //cuento las filas seleccionadas
            foreach(DataGridViewRow fila in dgv_docDmo.Rows) //recorro el dgv buscando las filas seleccionadas
            {
                if (fila.Selected == true) //si la fila es seleccionada
                {
                    contador++; //aumento el contador en uno
                }
            }

            dmo = new string[contador]; //creo un array string del tamaño de la cantidad de filas seleccionadas

            int recorrer = 0; //puntero para recorrer el array
            foreach (DataGridViewRow fila in dgv_docDmo.Rows) //recorro el dgv buscando las filas seleccionadas
            {
                if (fila.Selected == true) //si la fila es seleccionada
                {
                    dmo[recorrer] = fila.Cells[1].Value.ToString(); //recupero el nombre del dmo en el array en la posicion del contador
                    recorrer++; //aumento el contador en uno
                }
            }

            listarPuntosDmoSeleccionados(dmo);
        }

        private void listarPuntosDmoSeleccionados(string [] documentos)
        {
            dmosSeleccionados = "";
            for (int i = 0; i < documentos.Length; i++)
            {
                if (string.IsNullOrWhiteSpace(dmosSeleccionados))
                {
                    dmosSeleccionados += "'" + documentos[i] + "'";
                }
                else
                {
                    dmosSeleccionados += ",'" + documentos[i] + "'";
                }
            }

            SqlCommand listadoPuntos = new SqlCommand("SELECT DISTINCT ddd.idPtoMed AS 'Puntos de Medición',dcp.clasiTipoPto AS 'Tipo de Punto' FROM detallesDocumentoDmo AS ddd INNER JOIN detallesControlPlan AS dcp ON dcp.idPtoMed = ddd.idPtoMed WHERE ddd.codDmo IN ("+ dmosSeleccionados + ") AND ddd.idPtoMed IN(SELECT idPtoMed FROM detallesDocumentoDmo WHERE idPtoMed IN(SELECT idPtoMed FROM detallesControlPlan))", Conexion);
            ad_listadoPuntos = new SqlDataAdapter(listadoPuntos);

            DataTable dt_listadoPuntos = new DataTable();
            ad_listadoPuntos.Fill(dt_listadoPuntos);
            dgv_verPuntos.DataSource = dt_listadoPuntos;

            ad_listadoPuntos.SelectCommand.Parameters.Clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string param_punto = txt_verPunto.Text;
            filtrarPuntos(param_punto,dmo);
        }

        private void filtrarPuntos(string punto,string [] documentos)
        {
            string dmoFiltro = "";
            for (int i = 0; i < documentos.Length; i++)
            {
                if (string.IsNullOrWhiteSpace(dmoFiltro))
                {
                    dmoFiltro += "'" + documentos[i] + "'";
                }
                else
                {
                    dmoFiltro += ",'" + documentos[i] + "'";
                }
            }
            string aux_punto = punto;
            SqlCommand listadoPuntos = new SqlCommand("SELECT DISTINCT ddd.idPtoMed AS 'Puntos de Medición',dcp.clasiTipoPto AS 'Tipo de Punto' FROM detallesDocumentoDmo AS ddd INNER JOIN detallesControlPlan AS dcp ON dcp.idPtoMed = ddd.idPtoMed WHERE ddd.codDmo IN (" + dmoFiltro + ") AND ddd.idPtoMed IN(SELECT idPtoMed FROM detallesDocumentoDmo WHERE idPtoMed IN(SELECT idPtoMed FROM detallesControlPlan)) AND ddd.idPtoMed LIKE '%" + punto + "%'", Conexion);
            ad_listadoPuntos = new SqlDataAdapter(listadoPuntos);

            DataTable dt_listadoPuntos = new DataTable();
            ad_listadoPuntos.Fill(dt_listadoPuntos);
            dgv_verPuntos.DataSource = dt_listadoPuntos;

            ad_listadoPuntos.SelectCommand.Parameters.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int contador = 0; //cuento las filas seleccionadas
            foreach (DataGridViewRow fila in dgv_verPuntos.Rows) //recorro el dgv buscando las filas seleccionadas
            {
                if (fila.Selected == true) //si la fila es seleccionada
                {
                    contador++; //aumento el contador en uno
                }
            }

            puntos = new string[contador]; //creo un array string del tamaño de la cantidad de filas seleccionadas

            int recorrer = 0; //puntero para recorrer el array
            foreach (DataGridViewRow fila in dgv_verPuntos.Rows) //recorro el dgv buscando las filas seleccionadas
            {
                if (fila.Selected == true) //si la fila es seleccionada
                {
                    puntos[recorrer] = fila.Cells[0].Value.ToString(); //recupero el nombre del dmo en el array en la posicion del contador
                    recorrer++; //aumento el contador en uno
                }
            }

            recuperarArrayStrings(dmosSeleccionados, puntos);
        }

        private void recuperarArrayStrings(string documentos,string[] puntos)
        {
            string puntosD = "''";
            string puntosX = "''";
            string puntosY = "''";
            string puntosZ = "''";

            for (int i = 0; i < puntos.Length; i++)
            {
                char[] letra = puntos[i].ToCharArray();
                if (letra[letra.Length-1] == 'D')
                {
                    if (string.IsNullOrWhiteSpace(puntosD))
                    {
                        puntosD += "'" + puntos[i] + "'";
                    }
                    else
                    {
                        puntosD += ",'" + puntos[i] + "'";
                    }
                }
                else
                {
                    if (letra[letra.Length - 1] == 'X')
                    {
                        if (string.IsNullOrWhiteSpace(puntosX))
                        {
                            puntosX += "'" + puntos[i] + "'";
                        }
                        else
                        {
                            puntosX += ",'" + puntos[i] + "'";
                        }
                    }
                    else
                    {
                        if (letra[letra.Length - 1] == 'Y')
                        {
                            if (string.IsNullOrWhiteSpace(puntosY))
                            {
                                puntosY += "'" + puntos[i] + "'";
                            }
                            else
                            {
                                puntosY += ",'" + puntos[i] + "'";
                            }
                        }
                        else
                        {
                            if (string.IsNullOrWhiteSpace(puntosZ))
                            {
                                puntosZ += "'" + puntos[i] + "'";
                            }
                            else
                            {
                                puntosZ += ",'" + puntos[i] + "'";
                            }
                        }
                    }
                }
            }


            rellenarDatosPuntosSeleccionados(dmosSeleccionados, puntosD,puntosX,puntosY,puntosZ);
        }

        private void rellenarDatosPuntosSeleccionados(string dmos,string puntosD, string puntosX, string puntosY, string puntosZ)
        {
                SqlCommand verDatosPuntos = new SqlCommand("SELECT z.DocumentoDmo,z.Punto,z.Fecha,z.Nominal,z.[Tolerancia Sup.],z.Medido,z.[Tolerancia Inf.],z.[Desviaci�n] FROM (SELECT pmx.codDmo AS 'DocumentoDmo', pmx.codMediX AS 'Punto', dd.fechaDmo AS 'Fecha', pmx.nominalX AS 'Nominal', pmx.upTolX AS 'Tolerancia Sup.', pmx.medidoX AS 'Medido', pmx.loTolX AS 'Tolerancia Inf.', pmx.desvX AS 'Desviaci�n' FROM puntosMedidosX AS pmx INNER JOIN documentosDmo AS dd ON dd.codDmo = pmx.codDmo WHERE pmx.codMediX IN (SELECT DISTINCT idPtoMed FROM detallesDocumentoDmo WHERE codDmo IN(" + dmos + ") AND idPtoMed IN (SELECT idPtoMed FROM detallesDocumentoDmo WHERE idPtoMed IN (SELECT idPtoMed FROM detallesControlPlan)) AND idPtoMed IN (" + puntosX + ")) AND pmx.codDmo IN(" + dmos + ") UNION SELECT pmy.codDmo AS 'DocumentoDmo', pmy.codMediY AS 'Punto', dd.fechaDmo AS 'Fecha', pmy.nominalY AS 'Nominal', pmy.upTolY AS 'Tolerancia Sup.', pmy.medidoY AS 'Medido', pmy.loTolY AS 'Tolerancia Inf.', pmy.desvY AS 'Desviaci�n' FROM puntosMedidosY AS pmy INNER JOIN documentosDmo AS dd ON dd.codDmo = pmy.codDmo WHERE pmy.codMediY IN (SELECT DISTINCT idPtoMed FROM detallesDocumentoDmo WHERE codDmo IN (" + dmos + ") AND idPtoMed IN (SELECT idPtoMed FROM detallesDocumentoDmo WHERE idPtoMed IN (SELECT idPtoMed FROM detallesControlPlan)) AND idPtoMed IN (" + puntosY + ")) AND pmy.codDmo IN (" + dmos + ") UNION SELECT pmz.codDmo AS 'DocumentoDmo', pmz.codMediZ AS 'Punto', dd.fechaDmo AS 'Fecha', pmz.nominalZ AS 'Nominal', pmz.upTolZ AS 'Tolerancia Sup.', pmz.medidoZ AS 'Medido', pmz.loTolZ AS 'Tolerancia Inf.', pmz.desvZ AS 'Desviaci�n' FROM puntosMedidosZ AS pmz INNER JOIN documentosDmo AS dd ON dd.codDmo = pmz.codDmo WHERE pmz.codMediZ IN (SELECT DISTINCT idPtoMed FROM detallesDocumentoDmo WHERE codDmo IN (" + dmos + ") AND idPtoMed IN (SELECT idPtoMed FROM detallesDocumentoDmo WHERE idPtoMed IN (SELECT idPtoMed FROM detallesControlPlan)) AND idPtoMed IN (" + puntosZ + ")) AND pmz.codDmo IN (" + dmos + ") UNION SELECT pmd.codDmo AS 'DocumentoDmo', pmd.codMediD AS 'Punto', dd.fechaDmo AS 'Fecha', pmd.nominalD AS 'Nominal', pmd.upTolD AS 'Tolerancia Sup.', pmd.medidoD AS 'Medido', pmd.loTolD AS 'Tolerancia Inf.', pmd.desvD AS 'Desviaci�n' FROM puntosMedidosD AS pmd INNER JOIN documentosDmo AS dd ON dd.codDmo = pmd.codDmo WHERE pmd.codMediD IN (SELECT DISTINCT idPtoMed FROM detallesDocumentoDmo WHERE codDmo IN (" + dmos + ") AND idPtoMed IN (SELECT idPtoMed FROM detallesDocumentoDmo WHERE idPtoMed IN (SELECT idPtoMed FROM detallesControlPlan)) AND idPtoMed IN (" + puntosD + ")) AND pmd.codDmo IN (" + dmos + ")) AS z ORDER BY z.Punto, z.DocumentoDmo", Conexion);

                    ad_listadoPuntos = new SqlDataAdapter(verDatosPuntos);
                    DataTable dt_listadoPuntos = new DataTable();
                    ad_listadoPuntos.Fill(dt_listadoPuntos);
                    dgv_verDatosPuntos.DataSource = dt_listadoPuntos;

                    ad_listadoPuntos.SelectCommand.Parameters.Clear();
        }

        private void btn_verGrafico_Click(object sender, EventArgs e)
        {
            if (dgv_verDatosPuntos.Rows.Count == 0)
            {
                MessageBox.Show("No se ha presionado el botón 'Ver Datos' para obtener los valores a graficar de los DMO's y puntos seleccionados.", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ArrayList DocumentosDmo2 = new ArrayList();
                ArrayList Nominal2 = new ArrayList();
                ArrayList Valores2 = new ArrayList();

                string aux_fecha = "";
                string aux_dmo = "";
                string aux_final = "";
                decimal aux_desviacion;

                int contador = 0;
                foreach (DataGridViewRow fila in dgv_docDmo.Rows) //recorro el datagridview que contiene los valores
                {
                    if (fila.Selected == true)
                    {
                        char[] array = fila.Cells[1].Value.ToString().ToCharArray();
                        aux_dmo = array[array.Length - 3].ToString() + array[array.Length - 2].ToString() + array[array.Length - 1].ToString();
                        aux_fecha = fila.Cells[3].Value.ToString();
                        DateTime fecha = DateTime.Parse(aux_fecha);
                        aux_final = "DMO: " + aux_dmo + "\n" + "Fecha: " + fecha.ToString("d");
                        DocumentosDmo2.Add(aux_final); //inserto los datos de los dmo en el arraylist
                        Nominal2.Add((decimal)0);
                        contador++;
                    }
                }

                if (grafico2 != 0)
                {
                    //NECESITO BORRAR EL GRAFICO ANTES DE VOLVER A DIBUJAR
                    chart_verPuntos.Series.Clear();
                    chart_verPuntos.Series.Add("Nominal");
                    chart_verPuntos.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                    chart_verPuntos.Series[0].Color = Color.FromArgb(0,192,0);
                    chart_verPuntos.Series[0].BorderDashStyle = ChartDashStyle.Dot;
                    chart_verPuntos.Series[0].BorderWidth = 2;
                    series2 = 1;
                }

                chart_verPuntos.Series[0].Points.DataBindXY(DocumentosDmo2, Nominal2);


                foreach (DataGridViewRow fila in dgv_verPuntos.Rows)
                {
                    if (fila.Selected == true)
                    {
                        chart_verPuntos.Series.Add(fila.Cells[0].Value.ToString());
                        chart_verPuntos.Series[series2].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                        chart_verPuntos.Series[series2].BorderWidth = 2;
                        series2++;
                    }
                }

                series2 = 1;
                int auxCdor = 1;

                foreach (DataGridViewRow fila in dgv_verDatosPuntos.Rows)
                {
                    if (auxCdor <= contador)
                    {
                        aux_desviacion = (decimal)0 + (decimal)fila.Cells[7].Value;
                        Valores2.Add(aux_desviacion);
                        auxCdor++;
                    }
                    if (auxCdor > contador)
                    {
                        chart_verPuntos.Series[series2].Points.DataBindY(Valores2);
                        chart_verPuntos.Series[series2].ToolTip = "#VAL";
                        chart_verPuntos.Series[series2].MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
                        chart_verPuntos.Series[series2].MarkerSize = 5;
                        series2++;
                        auxCdor = 1;
                        Valores2.Clear();
                    }
                }
                    /**
                    chart_Puntos.Series.Add(lbl_PuntoSeleccionado.Text);
                    chart_Puntos.Series[series].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                    chart_Puntos.Series[series].BorderWidth = 2;

                    chart_Puntos.Series[series].ToolTip = "#VAL";
                    chart_Puntos.Series[series].MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
                    chart_Puntos.Series[series].MarkerSize = 5;
                    */

                grafico2 = 1;
                
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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

        private void btn_formGrafico_Click(object sender, EventArgs e)
        {
            Bitmap bm;
            using (MemoryStream ms = new MemoryStream())
            {
                chart_Puntos.SaveImage(ms, ChartImageFormat.Bmp);
                bm = new Bitmap(ms);
                Clipboard.SetImage(bm);
            }

            AmpliarGrafico ag = new AmpliarGrafico(bm);
            ag.Show();
        }

        private void btn_registrarGrafico_Click(object sender, EventArgs e)
        {
            Bitmap bm;
            using (MemoryStream ms = new MemoryStream())
            {
                chart_Puntos.SaveImage(ms, ChartImageFormat.Bmp);
                bm = new Bitmap(ms);
                Clipboard.SetImage(bm);
            }

            string auxMuestra = lbl_muestra.Text;
            int serie1 = 3;
            int cantidad = chart_Puntos.Series.Count - serie1;
            string[] puntos = new string[cantidad];
            for (int i=0;i<cantidad;i++)
            {
                puntos[i] = chart_Puntos.Series[serie1].Name;
                serie1++;
            }
            RegistroGrafico rg = new RegistroGrafico(bm,auxMuestra,puntos);
            rg.ShowDialog();
        }

        private void txt_tipoPunto_TextChanged(object sender, EventArgs e)
        {
            string param_muestra = lbl_muestra.Text;
            string param_punto = txt_puntoNombre.Text;
            string param_tipo = txt_tipoPunto.Text;
            buscarPuntos(param_punto, param_muestra, param_tipo);
        }

        private void cb_muestraNombrePunto_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_muestraNombrePunto.Checked == true)
            {
                txt_puntoNombre.Enabled = true;
            }
            else
            {
                txt_puntoNombre.Text = "";
                txt_puntoNombre.Enabled = false;
            }
        }

        private void cb_muestraTipoPunto_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_muestraTipoPunto.Checked == true)
            {
                txt_tipoPunto.Enabled = true;
            }
            else
            {
                txt_tipoPunto.Text = "";
                txt_tipoPunto.Enabled = false;
            }
        }

        private void cargarGraficosVisor(int codTipoGrafico)
        {
            string aux = "";
            string tipo = "";
            if (codTipoGrafico == 0)
            {
                aux = "g.codMuestra AS 'Muestra',";
                tipo = "Muestras";
            }
            else
            {
                if(codTipoGrafico == 1)
                {
                    aux = "g.codCalculo AS 'Cálculo',";
                    tipo = "Cálculos";
                }
                else
                {
                    aux = "";
                    tipo = "";
                }
            }
            SqlCommand cargaGrafico = new SqlCommand("SELECT g.codGrafico AS 'Código',"+aux+"tg.descTiposGraf AS 'Tipo de Gráfico',g.nomGrafico AS 'Nombre',g.descGrafico AS 'Leyenda' FROM graficos AS g JOIN tiposGrafico AS tg ON tg.codTiposGraf=g.codTiposGraf WHERE tg.descTiposGraf='"+tipo+"'",Conexion);
            adaptador.SelectCommand = cargaGrafico;
            DataTable dt_cargaGrafico = new DataTable();
            adaptador.Fill(dt_cargaGrafico);
            if (dgv_graficosVer.Rows.Count != 0)
            {
                dgv_graficosVer.DataSource = null;
                dgv_graficosVer.Rows.Clear();
                dgv_graficosVer.Refresh();
            }
            if (dt_cargaGrafico.Rows.Count != 0)
            {
                dgv_graficosVer.DataSource = dt_cargaGrafico;
            }
        }

        private void cb_tipoGrafVisor_SelectedIndexChanged(object sender, EventArgs e)
        {
            int x = cb_tipoGrafVisor.SelectedIndex;
            cargarGraficosVisor(x);
        }
    }
}
