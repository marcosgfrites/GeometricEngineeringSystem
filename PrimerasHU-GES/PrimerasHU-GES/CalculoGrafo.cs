using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace PrimerasHU_GES
{
    public partial class CalculoGrafo : Form
    {
        public CalculoGrafo(ArrayList ValoresCp, ArrayList ValoresCpk, ArrayList NombresPuntos)
        {
            InitializeComponent();
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
    }
}
