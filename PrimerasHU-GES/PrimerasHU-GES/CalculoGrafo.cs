using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace PrimerasHU_GES
{
    public partial class CalculoGrafo : Form
    {
        public CalculoGrafo(ArrayList ValoresCp, ArrayList ValoresCpk, ArrayList NombresPuntos, string ventana, string calculo)
        {
            InitializeComponent();
            lbl_ventana1.Text = ventana;
            lbl_calculo1.Text = calculo;
            chart_grafo1Calculo.Series[0].Points.DataBindXY(NombresPuntos,ValoresCp);
            chart_grafo1Calculo.Series[0].ToolTip = "#VAL";
            int cant1 = chart_grafo1Calculo.Series[0].Points.Count;
            for (int i = 0; i<cant1; i++)
            {
                if(double.Parse(chart_grafo1Calculo.Series[0].Points[i].YValues[0].ToString()) >= (double) 1.33)
                {
                    chart_grafo1Calculo.Series[0].Points[i].Color = Color.DarkGreen;
                }
                else
                {
                    if (double.Parse(chart_grafo1Calculo.Series[0].Points[i].YValues[0].ToString()) >= (double) 1.00 && double.Parse(chart_grafo1Calculo.Series[0].Points[i].YValues[0].ToString()) < (double)1.33)
                    {
                        chart_grafo1Calculo.Series[0].Points[i].Color = Color.Yellow;
                    }
                    else
                    {
                        chart_grafo1Calculo.Series[0].Points[i].Color = Color.Red;
                    }
                }
            }

            chart_grafo2Calculo.Series[0].Points.DataBindXY(NombresPuntos,ValoresCpk);
            chart_grafo2Calculo.Series[0].ToolTip = "#VAL";
            int cant2 = chart_grafo2Calculo.Series[0].Points.Count;
            for (int i = 0; i < cant1; i++)
            {
                if (double.Parse(chart_grafo2Calculo.Series[0].Points[i].YValues[0].ToString()) >= (double)1.33)
                {
                    chart_grafo2Calculo.Series[0].Points[i].Color = Color.DarkGreen;
                }
                else
                {
                    if (double.Parse(chart_grafo2Calculo.Series[0].Points[i].YValues[0].ToString()) >= (double)1.00 && double.Parse(chart_grafo2Calculo.Series[0].Points[i].YValues[0].ToString()) < (double)1.33)
                    {
                        chart_grafo2Calculo.Series[0].Points[i].Color = Color.Yellow;
                    }
                    else
                    {
                        chart_grafo2Calculo.Series[0].Points[i].Color = Color.Red;
                    }
                }
            }
        }



        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void CalculoGrafo_Load(object sender, EventArgs e)
        {
            if(lbl_ventana1.Text == "Registrado")
            {
                btn_registrarGraficoCp.Enabled = true;
                btn_registrarGraficoCp.Visible = true;
                btn_registrarGraficoCpk.Enabled = true;
                btn_registrarGraficoCpk.Visible = true;
            }
        }

        private void btn_registrarGraficoCp_Click(object sender, EventArgs e)
        {
            Bitmap bm;
            using (MemoryStream ms = new MemoryStream())
            {
                chart_grafo1Calculo.SaveImage(ms, ChartImageFormat.Bmp);
                bm = new Bitmap(ms);
                Clipboard.SetImage(bm);
            }

            string auxMuestra = lbl_calculo1.Text;
            int cantidad = chart_grafo1Calculo.Series[0].Points.Count;
            /*
            string[] puntos = new string[cantidad];
            for (int i = 0; i < cantidad; i++)
            {
                puntos[i] = chart_grafo1Calculo.Series[0].Points[i].LegendText.ToString();
            }
            */
            string[] puntos = new string[1];
            puntos[0] = "Gráfico de CP (Capacidad de Proceso) de puntos F (Semáforo)";

            string numero = "Número de Cálculo:";

            RegistroGrafico rg = new RegistroGrafico(bm, auxMuestra, puntos, numero);
            rg.ShowDialog();
        }

        private void btn_registrarGraficoCpk_Click(object sender, EventArgs e)
        {
            Bitmap bm;
            using (MemoryStream ms = new MemoryStream())
            {
                chart_grafo2Calculo.SaveImage(ms, ChartImageFormat.Bmp);
                bm = new Bitmap(ms);
                Clipboard.SetImage(bm);
            }

            string auxMuestra = lbl_calculo1.Text;
            int cantidad = chart_grafo2Calculo.Series[0].Points.Count;
            /*
            string[] puntos = new string[cantidad];
            for (int i = 0; i < cantidad; i++)
            {
                puntos[i] = chart_grafo1Calculo.Series[0].Points[i].LegendText.ToString();
            }
            */
            string[] puntos = new string[1];
            puntos[0] = "Gráfico de CPK (Capacidad de Centrado) de puntos F (Semáforo)";

            string numero = "Número de Cálculo:";

            RegistroGrafico rg = new RegistroGrafico(bm, auxMuestra, puntos, numero);
            rg.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
