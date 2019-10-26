using BlocNotasToDatagridview;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimerasHU_GES
{
    public partial class MarcosDmo : Form
    {
        //Instancia de la clase Leer
        Leer l = new Leer();
        //Alamcena la ruta del archivo .txt
        public string ARCHIVO = "";
        public string aux = "";

        public MarcosDmo()
        {
            InitializeComponent();
        }

        string mensaje = "Se llevaron a cabo con éxito los siguientes registros:"+"\n";
        private SqlConnection Conexion;
        private SqlDataAdapter adaptador;
        private SqlDataAdapter detalleDmo;
        private SqlDataAdapter medidoX;
        private SqlDataAdapter medidoY;
        private SqlDataAdapter medidoZ;
        private SqlDataAdapter medidoD;

        private void btn_Examinar_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = "C:\\";
            openFileDialog1.Filter = "Archivos Dmo (*.dmo)|*.dmo";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txt_Archivo.Text = openFileDialog1.FileName;
            }
            aux = leerNombreArchivo(txt_Archivo.Text);
        }

        private void MarcosDmo_Load(object sender, EventArgs e)
        {
            dgv_Dmo.Hide();
            dgv_nombresPuntos.Hide();
            dgv_DetDmo.Hide();
            Conexion = new SqlConnection("Data source=.\\SQLEXPRESS; Initial Catalog = ges_v01; Integrated Security = True");
            adaptador = new SqlDataAdapter();

            SqlCommand alta = new SqlCommand("INSERT INTO documentosDmo VALUES (@codDmo,@codCPlan,@codEstablecimiento,@codGrupo,@codOper,@codRegla,@chasisDmo,@fechaDmo,@hora)", Conexion);
            adaptador.InsertCommand = alta;
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@codDmo", SqlDbType.VarChar));
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@codCPlan", SqlDbType.Int));
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@codEstablecimiento", SqlDbType.VarChar));
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@codGrupo", SqlDbType.VarChar));
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@codOper", SqlDbType.Int));
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@codRegla", SqlDbType.Int));
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@chasisDmo", SqlDbType.VarChar));
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@fechaDmo", SqlDbType.DateTime));
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@hora", SqlDbType.DateTime));
        }

        private void btn_Mostrar_Click(object sender, EventArgs e)
        {

        }

        private string leerNombreArchivo(string aux)
        {
            string filename = aux;
            string result = Path.GetFileName(filename);
            return result;
        }

        private void recuperarDatos()
        {
            int puntos = 0; //recupero la cantidad de puntos en el dmo
            int posi = 0; //recorro el detalle del dmo
            int posiDatos = 0; //recorro el dgv datos
            try
            {
                string codigo = "";
                char[] cod = aux.ToArray();
                for (int i = 0; i < cod.Length - 4; i++)
                {
                    codigo += cod[i];
                }
                txt_CodigoDmo.Text = codigo;
                for (int fila = 0; fila < dgv_Dmo.Rows.Count - 1; fila++)
                {
                    //recupera STABILIMENTO del DMO
                    if (fila == 2)
                    {
                        string aux = dgv_Dmo.Rows[fila].Cells[0].Value.ToString();
                        char[] s = aux.ToCharArray();
                        string dato = "";
                        for (int i = 0; i < s.Length; i++)
                        {
                            if (i >= 31 && i <= s.Length - 1)
                            {
                                dato = dato + s[i];
                            }
                        }
                        txt_Establecimiento.Text = dato;
                    }

                    //recupera MODELLO del DMO
                    if (fila == 3)
                    {
                        string aux = dgv_Dmo.Rows[fila].Cells[0].Value.ToString();
                        char[] s = aux.ToCharArray();
                        string dato = "";
                        for (int i = 0; i < s.Length; i++)
                        {
                            if (i >= 31 && i <= s.Length - 1)
                            {
                                dato = dato + s[i];
                            }
                        }
                        txt_Modelo.Text = dato;
                    }

                    //recupera VERSIONE del DMO
                    if (fila == 4)
                    {
                        string aux = dgv_Dmo.Rows[fila].Cells[0].Value.ToString();
                        char[] s = aux.ToCharArray();
                        string dato = "";
                        for (int i = 0; i < s.Length; i++)
                        {
                            if (i >= 31 && i <= s.Length - 1)
                            {
                                dato = dato + s[i];
                            }
                        }
                        txt_Version.Text = dato;
                    }

                    //recupera GUIDA del DMO
                    if (fila == 5)
                    {
                        string aux = dgv_Dmo.Rows[fila].Cells[0].Value.ToString();
                        char[] s = aux.ToCharArray();
                        string dato = "";
                        for (int i = 0; i < s.Length; i++)
                        {
                            if (i >= 31 && i <= s.Length - 1)
                            {
                                dato = dato + s[i];
                            }
                        }
                        txt_Guia.Text = dato;
                    }

                    //recupera LOTTO del DMO
                    if (fila == 6)
                    {
                        string aux = dgv_Dmo.Rows[fila].Cells[0].Value.ToString();
                        char[] s = aux.ToCharArray();
                        string dato = "";
                        for (int i = 0; i < s.Length; i++)
                        {
                            if (i >= 31 && i <= s.Length - 1)
                            {
                                dato = dato + s[i];
                            }
                        }
                        txt_Lote.Text = dato;
                    }

                    //recupera SOTTOGRUPPO del DMO
                    if (fila == 7)
                    {
                        string aux = dgv_Dmo.Rows[fila].Cells[0].Value.ToString();
                        char[] s = aux.ToCharArray();
                        string dato = "";
                        for (int i = 0; i < s.Length; i++)
                        {
                            if (i >= 31 && i <= s.Length - 1)
                            {
                                dato = dato + s[i];
                            }
                        }
                        txt_Subgrupo.Text = dato;
                    }

                    //recupera NRO. DISEGNO del DMO
                    if (fila == 8)
                    {
                        string aux = dgv_Dmo.Rows[fila].Cells[0].Value.ToString();
                        char[] s = aux.ToCharArray();
                        string dato = "";
                        for (int i = 0; i < s.Length; i++)
                        {
                            if (i >= 31 && i <= s.Length - 1)
                            {
                                dato = dato + s[i];
                            }
                        }
                        txt_Disenio.Text = dato;
                    }

                    //recupera PROGRAMA del DMO
                    if (fila == 9)
                    {
                        string aux = dgv_Dmo.Rows[fila].Cells[0].Value.ToString();
                        char[] s = aux.ToCharArray();
                        string dato = "";
                        for (int i = 0; i < s.Length; i++)
                        {
                            if (i >= 31 && i <= s.Length - 1)
                            {
                                dato = dato + s[i];
                            }
                        }
                        txt_Programa.Text = dato;
                    }

                    //recupera REVISIONE del DMO
                    if (fila == 10)
                    {
                        string aux = dgv_Dmo.Rows[fila].Cells[0].Value.ToString();
                        char[] s = aux.ToCharArray();
                        string dato = "";
                        for (int i = 0; i < s.Length; i++)
                        {
                            if (i >= 31 && i <= s.Length - 1)
                            {
                                dato = dato + s[i];
                            }
                        }
                        txt_Revision.Text = dato;
                    }

                    //recupera DATA AGGIONAMIENTO del DMO
                    if (fila == 11)
                    {
                        string aux = dgv_Dmo.Rows[fila].Cells[0].Value.ToString();
                        char[] s = aux.ToCharArray();
                        string dato = "";
                        for (int i = 0; i < s.Length; i++)
                        {
                            if (i >= 31 && i <= s.Length - 1)
                            {
                                dato = dato + s[i];
                            }
                        }
                        txt_FechaActualiz.Text = dato;
                    }

                    //recupera MACHINA DI MISURA del DMO
                    if (fila == 12)
                    {
                        string aux = dgv_Dmo.Rows[fila].Cells[0].Value.ToString();
                        char[] s = aux.ToCharArray();
                        string dato = "";
                        for (int i = 0; i < s.Length; i++)
                        {
                            if (i >= 31 && i <= s.Length - 1)
                            {
                                dato = dato + s[i];
                            }
                        }
                        txt_Maquina.Text = dato;
                    }

                    //recupera PROGRAMMATORE del DMO
                    if (fila == 13)
                    {
                        string aux = dgv_Dmo.Rows[fila].Cells[0].Value.ToString();
                        char[] s = aux.ToCharArray();
                        string dato = "";
                        for (int i = 0; i < s.Length; i++)
                        {
                            if (i >= 31 && i <= s.Length - 1)
                            {
                                dato = dato + s[i];
                            }
                        }
                        txt_Programador.Text = dato;
                    }

                    //recupera APPROVAZIONE PROGRAMMA del DMO
                    if (fila == 14)
                    {
                        string aux = dgv_Dmo.Rows[fila].Cells[0].Value.ToString();
                        char[] s = aux.ToCharArray();
                        string dato = "";
                        for (int i = 0; i < s.Length; i++)
                        {
                            if (i >= 31 && i <= s.Length - 1)
                            {
                                dato = dato + s[i];
                            }
                        }
                        txt_ApProg.Text = dato;
                    }

                    //recupera SISTEMA DI RIF. del DMO
                    if (fila == 15)
                    {
                        string aux = dgv_Dmo.Rows[fila].Cells[0].Value.ToString();
                        char[] s = aux.ToCharArray();
                        string dato = "";
                        for (int i = 0; i < s.Length; i++)
                        {
                            if (i >= 31 && i <= s.Length - 1)
                            {
                                dato = dato + s[i];
                            }
                        }
                        txt_SistRef.Text = dato;
                    }

                    //recupera REGOLA OUTPUT del DMO
                    if (fila == 16)
                    {
                        string aux = dgv_Dmo.Rows[fila].Cells[0].Value.ToString();
                        char[] s = aux.ToCharArray();
                        string dato = "";
                        for (int i = 0; i < s.Length; i++)
                        {
                            if (i >= 31 && i <= s.Length - 1)
                            {
                                dato = dato + s[i];
                            }
                        }
                        txt_Regla.Text = dato;
                    }


                    //recupera la FECHA del DMO
                    if (fila == 18)
                    {
                        string aux = dgv_Dmo.Rows[fila].Cells[0].Value.ToString();
                        char[] s = aux.ToCharArray();
                        string dato = "";
                        for (int i = 0; i < s.Length; i++)
                        {
                            if (i >= 7 && i <= s.Length - 1)
                            {
                                dato = dato + s[i];
                            }
                        }
                        txt_FechaDmo.Text = dato;
                    }

                    //recupera la HORA del DMO
                    if (fila == 19)
                    {
                        string aux = dgv_Dmo.Rows[fila].Cells[0].Value.ToString();
                        char[] s = aux.ToCharArray();
                        string dato = "";
                        for (int i = 0; i < s.Length; i++)
                        {
                            if (i >= 9 && i <= s.Length - 1)
                            {
                                dato = dato + s[i];
                            }
                        }
                        txt_HoraDmo.Text = dato;
                    }

                    if (fila >= 22)
                    {
                        string aux = dgv_Dmo.Rows[fila].Cells[0].Value.ToString();
                        string celda = aux;
                        if (celda != "") //SI LA CADENA NO ESTÁ VACÍA
                        {
                            char[] s = celda.ToCharArray(); //CONVIERTO LA CADENA EN UN ARRAY DE CARACTERES
                            if (s[0].Equals('#') && s[2].Equals('(')) //SI LA PRIMERA POSICION DEL ARRAY ES IGUAL AL CARACTER '#'
                            {
                                dgv_DetDmo.Rows.Insert(posi, aux);
                                puntos++;

                                //ACÁ COMIENZO A RECUPERAR EL NOMBRE DEL PUNTO
                                string punto = dgv_DetDmo.Rows[posi].Cells[0].Value.ToString();
                                char[] p = punto.ToCharArray();
                                int leer = 3;
                                string final = "";

                                /*
                                 * 
                                 * 
                                //TUVE QUE AGREGAR UN CONTADOR DE PARENTESIS PORQUE EN EL CONTROL PLAN Y EL DETALLE DEL CONTROL PLAN LOS PUNTOS TIENE EN SU NOMBRE LA COORDENADA IMPORTANTE
                                int contador_Parentesis = 1;
                                while (contador_Parentesis < 3)
                                {
                                    if(p[leer] == '(')
                                    {
                                        contador_Parentesis++;
                                    }
                                    leer++;
                                }
                                //FIN CONTADOR DE PARENTESIS

                                string final = "";
                                while (p[leer] != ')')
                                {
                                    if (p[leer] != '_')
                                    {
                                        final += p[leer];
                                    }
                                    leer++;
                                }
                                dgv_nombresPuntos.Rows.Add(final);
                                *
                                *
                                */

                                //ACÁ CONTROLO CON LA PRIMERA LETRA DEL RENGLON QUE SIGUE AL PUNTO SI ES X, AGREGO 3 FILAS AL DGV SINO 1 SOLA PORQUE SERIA DISTRIBUCION
                                string agrega = dgv_Dmo.Rows[fila + 1].Cells[0].Value.ToString();
                                string cadena = agrega;
                                if (cadena != "")
                                {
                                    char[] primera = cadena.ToCharArray();
                                    if (primera[0].Equals('X'))
                                    {
                                        dgv_datos.Rows.Add(3);
                                        int contador_Parentesis = 1;
                                        while (contador_Parentesis < 3)
                                        {
                                            if (p[leer] == '(')
                                            {
                                                contador_Parentesis++;
                                            }
                                            leer++;
                                        }
                                        //FIN CONTADOR DE PARENTESIS

                                        while (p[leer] != ')')
                                        {
                                            if (p[leer] != '_')
                                            {
                                                final += p[leer];
                                            }
                                            leer++;
                                        }
                                        dgv_nombresPuntos.Rows.Add(final);
                                    }
                                    else
                                    {
                                        dgv_datos.Rows.Add(1);
                                        while (p[leer] != ')')
                                        {
                                            if (p[leer] != '_')
                                            {
                                                final += p[leer];
                                            }
                                            leer++;
                                        }
                                        final += 'D';
                                        dgv_nombresPuntos.Rows.Add(final);
                                    }
                                } //TEMRINO EL CONTROL DE AGREGADO DE FILAS
                                //dgv_datos.Rows[posi].Cells[0].Value = final;
                                //TERMINO DE RECUPERAR EL NOMBRE DEL PUNTO
                                
                                fila++;
                                //posiDatos = posi;
                                string aux2 = dgv_Dmo.Rows[fila].Cells[0].Value.ToString();
                                string celda2 = aux2;
                                if (celda2 != "")
                                {
                                    char[] s2 = celda2.ToCharArray(); //CONVIERTO LA CADENA EN UN ARRAY DE CARACTERES
                                    if (s2[0].Equals('X'))
                                    {
                                        int contDecimales = 0;
                                        int coma = 0;
                                        dgv_datos.Rows[posiDatos].Cells[0].Value = final;
                                        dgv_datos.Rows[posiDatos].Cells[1].Value = s2[0];

                                        char[] p2 = aux2.ToCharArray(); //aca traigo a "p2" todo el renglon

                                        /** acá voy leyendo MEASURED de X **/
                                        int leer2 = 5; //posiciono un puntero en el 5 array
                                        string final2 = "";
                                        while (contDecimales < 5)
                                        {
                                            if (p2[leer2] != ' ')
                                            {
                                                final2 += p2[leer2];
                                                if (p2[leer2] == '.')
                                                {
                                                    coma = 1;
                                                }

                                                if (p2[leer2] != ' ' && coma == 1 && p2[leer2 + 1] != ' ')
                                                {
                                                    contDecimales++;
                                                }

                                                if (p2[leer2 - 4] == '.')
                                                {
                                                    contDecimales = 5;
                                                }
                                            }
                                            leer2++;
                                        }
                                        dgv_datos.Rows[posiDatos].Cells[2].Value = final2;
                                        /** termino de leer MEASURED de X **/

                                        /** acá voy leyendo NOMINAL de X **/
                                        leer2++; //hago avanzar un lugar el puntero, para empezar a leer nominal
                                        int comaNomX = 0; //reinicializo a 0 el contador que indica la presencia de un "."
                                        int contDecimalesNomX = 0; //reinicializo a 0 el contador que indica que ya hay 4 decimales
                                        //string auxNomX = aux2.Remove(0,leer2);
                                        string auxNomX = aux2;
                                        //MessageBox.Show(auxNomX);
                                        char[] pNomX = auxNomX.ToCharArray();
                                        //int leerNomX = 0;
                                        string finalNomX = "";
                                        while (contDecimalesNomX < 5)
                                        {
                                            if (pNomX[leer2] != ' ')
                                            {
                                                finalNomX += pNomX[leer2];
                                                if (pNomX[leer2] == '.')
                                                {
                                                    comaNomX = 1;
                                                }

                                                if (pNomX[leer2] != ' ' && comaNomX == 1 && pNomX[leer2 + 1] != ' ')
                                                {
                                                    contDecimalesNomX++;
                                                }

                                                if (pNomX[leer2 - 4] == '.')
                                                {
                                                    contDecimalesNomX = 5;
                                                }
                                            }
                                            leer2++;
                                            //leerNomX++;
                                        }
                                        dgv_datos.Rows[posiDatos].Cells[3].Value = finalNomX;
                                        /** termino de leer NOMINAL de X **/

                                        /** acá voy leyendo DEVIATION de X **/
                                        leer2++; //hago avanzar un lugar el puntero, para empezar a leer nominal
                                        int comaDevX = 0; //reinicializo a 0 el contador que indica la presencia de un "."
                                        int contDecimalesDevX = 0; //reinicializo a 0 el contador que indica que ya hay 4 decimales
                                        //string auxNomX = aux2.Remove(0,leer2);
                                        string auxDevX = aux2;
                                        //MessageBox.Show(auxNomX);
                                        char[] pDevX = auxDevX.ToCharArray();
                                        //int leerNomX = 0;
                                        string finalDevX = "";
                                        while (contDecimalesDevX < 5)
                                        {
                                            if (pDevX[leer2] != ' ')
                                            {
                                                finalDevX += pDevX[leer2];
                                                if (pDevX[leer2] == '.')
                                                {
                                                    comaDevX = 1;
                                                }

                                                if (pDevX[leer2] != ' ' && comaDevX == 1 && pDevX[leer2 + 1] != ' ')
                                                {
                                                    contDecimalesDevX++;
                                                }

                                                if (pDevX[leer2 - 4] == '.')
                                                {
                                                    contDecimalesDevX = 5;
                                                }
                                            }
                                            leer2++;
                                            //leerNomX++;
                                        }
                                        dgv_datos.Rows[posiDatos].Cells[4].Value = finalDevX;
                                        /** termino de leer DEVIATION de X **/

                                        /** acá voy leyendo UP_TOL de X **/
                                        leer2++; //hago avanzar un lugar el puntero, para empezar a leer nominal
                                        int comaUpX = 0; //reinicializo a 0 el contador que indica la presencia de un "."
                                        int contDecimalesUpX = 0; //reinicializo a 0 el contador que indica que ya hay 4 decimales
                                        //string auxNomX = aux2.Remove(0,leer2);
                                        string auxUpX = aux2;
                                        //MessageBox.Show(auxNomX);
                                        char[] pUpX = auxUpX.ToCharArray();
                                        //int leerNomX = 0;
                                        string finalUpX = "";
                                        while (contDecimalesUpX < 5)
                                        {
                                            if (pUpX[leer2] != ' ')
                                            {
                                                finalUpX += pUpX[leer2];
                                                if (pUpX[leer2] == '.')
                                                {
                                                    comaUpX = 1;
                                                }

                                                if (pUpX[leer2] != ' ' && comaUpX == 1 && pUpX[leer2 + 1] != ' ')
                                                {
                                                    contDecimalesUpX++;
                                                }

                                                if (pUpX[leer2 - 4] == '.')
                                                {
                                                    contDecimalesUpX = 5;
                                                }
                                            }
                                            leer2++;
                                            //leerNomX++;
                                        }
                                        dgv_datos.Rows[posiDatos].Cells[5].Value = finalUpX;
                                        /** termino de leer UP_TOL de X **/

                                        /** acá voy leyendo LO_TOL de X **/
                                        leer2++; //hago avanzar un lugar el puntero, para empezar a leer nominal
                                        int comaLoX = 0; //reinicializo a 0 el contador que indica la presencia de un "."
                                        int contDecimalesLoX = 0; //reinicializo a 0 el contador que indica que ya hay 4 decimales
                                        //string auxNomX = aux2.Remove(0,leer2);
                                        string auxLoX = aux2;
                                        //MessageBox.Show(auxNomX);
                                        char[] pLoX = auxLoX.ToCharArray();
                                        //int leerNomX = 0;
                                        string finalLoX = "";
                                        while (contDecimalesLoX < 5)
                                        {
                                            if (pLoX[leer2] != ' ')
                                            {
                                                finalLoX += pLoX[leer2];
                                                if (pLoX[leer2] == '.')
                                                {
                                                    comaLoX = 1;
                                                }

                                                if (pLoX[leer2] != ' ' && comaLoX == 1 && pLoX[leer2 + 1] != ' ')
                                                {
                                                    contDecimalesLoX++;
                                                }

                                                if (pLoX[leer2 - 4] == '.')
                                                {
                                                    contDecimalesLoX = 5;
                                                }
                                            }
                                            leer2++;
                                            //leerNomX++;
                                        }
                                        dgv_datos.Rows[posiDatos].Cells[6].Value = finalLoX;
                                        /** termino de leer LO_TOL de X **/

                                        /** acá voy leyendo CRIT/OOT de X **/
                                        leer2++;
                                        string auxCritX = aux2;
                                        char[] pCritX = auxCritX.ToCharArray();
                                        string finalCritX = "";
                                        for (int i = leer2; i<pCritX.Length;i++)
                                        {
                                            if (pCritX[i] != ' ')
                                            {
                                                finalCritX += pCritX[i];
                                            }
                                        }
                                        dgv_datos.Rows[posiDatos].Cells[7].Value = finalCritX;
                                        /** termino de leer CRIT/OOT de X **/

                                        fila++; //aumento fila para avanzar a la linea siguiente en la lectura del dmo
                                        posiDatos++; //aumento posiDatos para avanzar a la proxima posicion libre para enviar datos a dgv_datos

                                        
                                        //EMPIEZO A LEER "Y" PERO NO SIN ANTES AUMENTAR LA FILA Y POSICIÓN
                                        string auxY = dgv_Dmo.Rows[fila].Cells[0].Value.ToString();
                                        string celdaY = auxY;
                                        if (celdaY != "")
                                        {
                                            char[] sY = celdaY.ToCharArray(); //CONVIERTO LA CADENA EN UN ARRAY DE CARACTERES
                                            if (sY[0].Equals('Y'))
                                            {
                                                dgv_datos.Rows[posiDatos].Cells[0].Value = final;
                                                int contDecimalesY = 0;
                                                int comaY = 0;
                                                dgv_datos.Rows[posiDatos].Cells[1].Value = sY[0];
                                                /** acá voy leyendo MEASURED de Y **/
                                                char[] pY = auxY.ToCharArray();
                                                int leerY = 5;
                                                string finalY = "";
                                                while (contDecimalesY < 5)
                                                {
                                                    if (pY[leerY] != ' ')
                                                    {
                                                        finalY += pY[leerY];
                                                        if (pY[leerY] == '.')
                                                        {
                                                            comaY = 1;
                                                        }

                                                        if (pY[leerY] != ' ' && comaY == 1 && pY[leerY + 1] != ' ')
                                                        {
                                                            contDecimalesY++;
                                                        }

                                                        if (pY[leerY - 4] == '.')
                                                        {
                                                            contDecimalesY = 5;
                                                        }
                                                    }
                                                    leerY++;
                                                }
                                                dgv_datos.Rows[posiDatos].Cells[2].Value = finalY;
                                                /** termino de leer el MEASURED de Y **/

                                                /** acá voy leyendo NOMINAL de Y **/
                                                leerY++; //hago avanzar un lugar el puntero, para empezar a leer nominal
                                                int comaNomY = 0; //reinicializo a 0 el contador que indica la presencia de un "."
                                                int contDecimalesNomY = 0; //reinicializo a 0 el contador que indica que ya hay 4 decimales
                                                                           //string auxNomX = aux2.Remove(0,leer2);
                                                string auxNomY = auxY;
                                                //MessageBox.Show(auxNomX);
                                                char[] pNomY = auxNomY.ToCharArray();
                                                //int leerNomX = 0;
                                                string finalNomY = "";
                                                while (contDecimalesNomY < 5)
                                                {
                                                    if (pNomY[leerY] != ' ')
                                                    {
                                                        finalNomY += pNomY[leerY];
                                                        if (pNomY[leerY] == '.')
                                                        {
                                                            comaNomY = 1;
                                                        }

                                                        if (pNomY[leerY] != ' ' && comaNomY == 1 && pNomY[leerY + 1] != ' ')
                                                        {
                                                            contDecimalesNomY++;
                                                        }

                                                        if (pNomY[leerY - 4] == '.')
                                                        {
                                                            contDecimalesNomY = 5;
                                                        }
                                                    }
                                                    leerY++;
                                                    //leerNomX++;
                                                }
                                                dgv_datos.Rows[posiDatos].Cells[3].Value = finalNomY;
                                                /** termino de leer NOMINAL de Y **/

                                                /** acá voy leyendo DEVIATION de Y **/
                                                leerY++; //hago avanzar un lugar el puntero, para empezar a leer nominal
                                                int comaDevY = 0; //reinicializo a 0 el contador que indica la presencia de un "."
                                                int contDecimalesDevY = 0; //reinicializo a 0 el contador que indica que ya hay 4 decimales
                                                                           //string auxNomX = aux2.Remove(0,leer2);
                                                string auxDevY = auxY;
                                                //MessageBox.Show(auxNomX);
                                                char[] pDevY = auxDevY.ToCharArray();
                                                //int leerNomX = 0;
                                                string finalDevY = "";
                                                while (contDecimalesDevY < 5)
                                                {
                                                    if (pDevY[leerY] != ' ')
                                                    {
                                                        finalDevY += pDevY[leerY];
                                                        if (pDevY[leerY] == '.')
                                                        {
                                                            comaDevY = 1;
                                                        }

                                                        if (pDevY[leerY] != ' ' && comaDevY == 1 && pDevY[leerY + 1] != ' ')
                                                        {
                                                            contDecimalesDevY++;
                                                        }

                                                        if (pDevY[leerY - 4] == '.')
                                                        {
                                                            contDecimalesDevY = 5;
                                                        }
                                                    }
                                                    leerY++;
                                                    //leerNomX++;
                                                }
                                                dgv_datos.Rows[posiDatos].Cells[4].Value = finalDevY;
                                                /** termino de leer DEVIATION de Y **/

                                                /** acá voy leyendo UP_TOL de Y **/
                                                leerY++; //hago avanzar un lugar el puntero, para empezar a leer nominal
                                                int comaUpY = 0; //reinicializo a 0 el contador que indica la presencia de un "."
                                                int contDecimalesUpY = 0; //reinicializo a 0 el contador que indica que ya hay 4 decimales
                                                                          //string auxNomX = aux2.Remove(0,leer2);
                                                string auxUpY = auxY;
                                                //MessageBox.Show(auxNomX);
                                                char[] pUpY = auxUpY.ToCharArray();
                                                //int leerNomX = 0;
                                                string finalUpY = "";
                                                while (contDecimalesUpY < 5)
                                                {
                                                    if (pUpY[leerY] != ' ')
                                                    {
                                                        finalUpY += pUpY[leerY];
                                                        if (pUpY[leerY] == '.')
                                                        {
                                                            comaUpY = 1;
                                                        }

                                                        if (pUpY[leerY] != ' ' && comaUpY == 1 && pUpY[leerY + 1] != ' ')
                                                        {
                                                            contDecimalesUpY++;
                                                        }

                                                        if (pUpY[leerY - 4] == '.')
                                                        {
                                                            contDecimalesUpY = 5;
                                                        }
                                                    }
                                                    leerY++;
                                                    //leerNomX++;
                                                }
                                                dgv_datos.Rows[posiDatos].Cells[5].Value = finalUpY;
                                                /** termino de leer UP_TOL de Y **/

                                                /** acá voy leyendo LO_TOL de Y **/
                                                leerY++; //hago avanzar un lugar el puntero, para empezar a leer nominal
                                                int comaLoY = 0; //reinicializo a 0 el contador que indica la presencia de un "."
                                                int contDecimalesLoY = 0; //reinicializo a 0 el contador que indica que ya hay 4 decimales
                                                                          //string auxNomX = aux2.Remove(0,leer2);
                                                string auxLoY = auxY;
                                                //MessageBox.Show(auxNomX);
                                                char[] pLoY = auxLoY.ToCharArray();
                                                //int leerNomX = 0;
                                                string finalLoY = "";
                                                while (contDecimalesLoY < 5)
                                                {
                                                    if (pLoY[leerY] != ' ')
                                                    {
                                                        finalLoY += pLoY[leerY];
                                                        if (pLoY[leerY] == '.')
                                                        {
                                                            comaLoY = 1;
                                                        }

                                                        if (pLoY[leerY] != ' ' && comaLoY == 1 && pLoY[leerY + 1] != ' ')
                                                        {
                                                            contDecimalesLoY++;
                                                        }

                                                        if (pLoY[leerY - 4] == '.')
                                                        {
                                                            contDecimalesLoY = 5;
                                                        }
                                                    }
                                                    leerY++;
                                                    //leerNomX++;
                                                }
                                                dgv_datos.Rows[posiDatos].Cells[6].Value = finalLoY;
                                                /** termino de leer LO_TOL de Y **/

                                                /** acá voy leyendo CRIT/OOT de Y **/
                                                leerY++;
                                                string auxCritY = auxY;
                                                char[] pCritY = auxCritY.ToCharArray();
                                                string finalCritY = "";
                                                for (int i = leerY; i < pCritY.Length; i++)
                                                {
                                                    if (pCritY[i] != ' ')
                                                    {
                                                        finalCritY += pCritY[i];
                                                    }
                                                }
                                                dgv_datos.Rows[posiDatos].Cells[7].Value = finalCritY;
                                                /** termino de leer CRIT/OOT de Y **/

                                                fila++; //avanzo a la fila siguiente en el dmo
                                                posiDatos++; //avanzo a la proxima posicion libre del dgv_datos

                                                //ACÁ COMIENZO A LEER Z
                                                string auxZ = dgv_Dmo.Rows[fila].Cells[0].Value.ToString();
                                                string celdaZ = auxZ;
                                                if (celdaZ != "")
                                                {
                                                    char[] sZ = celdaZ.ToCharArray(); //CONVIERTO LA CADENA EN UN ARRAY DE CARACTERES
                                                    if (sZ[0].Equals('Z'))
                                                    {
                                                        dgv_datos.Rows[posiDatos].Cells[0].Value = final;
                                                        int contDecimalesZ = 0;
                                                        int comaZ = 0;
                                                        dgv_datos.Rows[posiDatos].Cells[1].Value = sZ[0];
                                                        /** acá voy leyendo NOMINAL de Z **/
                                                        char[] pZ = auxZ.ToCharArray();
                                                        int leerZ = 5;
                                                        string finalZ = "";
                                                        while (contDecimalesZ < 5)
                                                        {
                                                            if (pZ[leerZ] != ' ')
                                                            {
                                                                finalZ += pZ[leerZ];
                                                                if (pZ[leerZ] == '.')
                                                                {
                                                                    comaZ = 1;
                                                                }

                                                                if (pZ[leerZ] != ' ' && comaZ == 1 && pZ[leerZ + 1] != ' ')
                                                                {
                                                                    contDecimalesZ++;
                                                                }

                                                                if (pZ[leerZ - 4] == '.')
                                                                {
                                                                    contDecimalesZ = 5;
                                                                }
                                                            }
                                                            leerZ++;
                                                        }
                                                        dgv_datos.Rows[posiDatos].Cells[2].Value = finalZ;
                                                        /** termino de leer el MEASURED de Z **/

                                                        /** acá voy leyendo NOMINAL de Z **/
                                                        leerZ++; //hago avanzar un lugar el puntero, para empezar a leer nominal
                                                        int comaNomZ = 0; //reinicializo a 0 el contador que indica la presencia de un "."
                                                        int contDecimalesNomZ = 0; //reinicializo a 0 el contador que indica que ya hay 4 decimales
                                                                                   //string auxNomX = aux2.Remove(0,leer2);
                                                        string auxNomZ = auxZ;
                                                        //MessageBox.Show(auxNomX);
                                                        char[] pNomZ = auxNomZ.ToCharArray();
                                                        //int leerNomX = 0;
                                                        string finalNomZ = "";
                                                        while (contDecimalesNomZ < 5)
                                                        {
                                                            if (pNomZ[leerZ] != ' ')
                                                            {
                                                                finalNomZ += pNomZ[leerZ];
                                                                if (pNomZ[leerZ] == '.')
                                                                {
                                                                    comaNomZ = 1;
                                                                }

                                                                if (pNomY[leerZ] != ' ' && comaNomZ == 1 && pNomZ[leerZ + 1] != ' ')
                                                                {
                                                                    contDecimalesNomZ++;
                                                                }

                                                                if (pNomZ[leerZ - 4] == '.')
                                                                {
                                                                    contDecimalesNomZ = 5;
                                                                }
                                                            }
                                                            leerZ++;
                                                            //leerNomX++;
                                                        }
                                                        dgv_datos.Rows[posiDatos].Cells[3].Value = finalNomZ;
                                                        /** termino de leer NOMINAL de Z **/

                                                        /** acá voy leyendo DEVIATION de Z **/
                                                        leerZ++; //hago avanzar un lugar el puntero, para empezar a leer nominal
                                                        int comaDevZ = 0; //reinicializo a 0 el contador que indica la presencia de un "."
                                                        int contDecimalesDevZ = 0; //reinicializo a 0 el contador que indica que ya hay 4 decimales
                                                                                   //string auxNomX = aux2.Remove(0,leer2);
                                                        string auxDevZ = auxZ;
                                                        //MessageBox.Show(auxNomX);
                                                        char[] pDevZ = auxDevZ.ToCharArray();
                                                        //int leerNomX = 0;
                                                        string finalDevZ = "";
                                                        while (contDecimalesDevZ < 5)
                                                        {
                                                            if (pDevZ[leerZ] != ' ')
                                                            {
                                                                finalDevZ += pDevZ[leerZ];
                                                                if (pDevZ[leerZ] == '.')
                                                                {
                                                                    comaDevZ = 1;
                                                                }

                                                                if (pDevZ[leerZ] != ' ' && comaDevZ == 1 && pDevZ[leerZ + 1] != ' ')
                                                                {
                                                                    contDecimalesDevZ++;
                                                                }

                                                                if (pDevZ[leerZ - 4] == '.')
                                                                {
                                                                    contDecimalesDevZ = 5;
                                                                }
                                                            }
                                                            leerZ++;
                                                            //leerNomX++;
                                                        }
                                                        dgv_datos.Rows[posiDatos].Cells[4].Value = finalDevZ;
                                                        /** termino de leer DEVIATION de Z **/

                                                        /** acá voy leyendo UP_TOL de Z **/
                                                        leerZ++; //hago avanzar un lugar el puntero, para empezar a leer nominal
                                                        int comaUpZ = 0; //reinicializo a 0 el contador que indica la presencia de un "."
                                                        int contDecimalesUpZ = 0; //reinicializo a 0 el contador que indica que ya hay 4 decimales
                                                                                  //string auxNomX = aux2.Remove(0,leer2);
                                                        string auxUpZ = auxZ;
                                                        //MessageBox.Show(auxNomX);
                                                        char[] pUpZ = auxUpZ.ToCharArray();
                                                        //int leerNomX = 0;
                                                        string finalUpZ = "";
                                                        while (contDecimalesUpZ < 5)
                                                        {
                                                            if (pUpZ[leerZ] != ' ')
                                                            {
                                                                finalUpZ += pUpZ[leerZ];
                                                                if (pUpZ[leerZ] == '.')
                                                                {
                                                                    comaUpZ = 1;
                                                                }

                                                                if (pUpZ[leerZ] != ' ' && comaUpZ == 1 && pUpZ[leerZ + 1] != ' ')
                                                                {
                                                                    contDecimalesUpZ++;
                                                                }

                                                                if (pUpZ[leerZ - 4] == '.')
                                                                {
                                                                    contDecimalesUpZ = 5;
                                                                }
                                                            }
                                                            leerZ++;
                                                            //leerNomX++;
                                                        }
                                                        dgv_datos.Rows[posiDatos].Cells[5].Value = finalUpZ;
                                                        /** termino de leer UP_TOL de Z **/

                                                        /** acá voy leyendo LO_TOL de Z **/
                                                        leerZ++; //hago avanzar un lugar el puntero, para empezar a leer nominal
                                                        int comaLoZ = 0; //reinicializo a 0 el contador que indica la presencia de un "."
                                                        int contDecimalesLoZ = 0; //reinicializo a 0 el contador que indica que ya hay 4 decimales
                                                                                  //string auxNomX = aux2.Remove(0,leer2);
                                                        string auxLoZ = auxZ;
                                                        //MessageBox.Show(auxNomX);
                                                        char[] pLoZ = auxLoZ.ToCharArray();
                                                        //int leerNomX = 0;
                                                        string finalLoZ = "";
                                                        while (contDecimalesLoZ < 5)
                                                        {
                                                            if (pLoZ[leerZ] != ' ')
                                                            {
                                                                finalLoZ += pLoZ[leerZ];
                                                                if (pLoZ[leerZ] == '.')
                                                                {
                                                                    comaLoZ = 1;
                                                                }

                                                                if (pLoZ[leerZ] != ' ' && comaLoZ == 1 && pLoZ[leerZ + 1] != ' ')
                                                                {
                                                                    contDecimalesLoZ++;
                                                                }

                                                                if (pLoZ[leerZ - 4] == '.')
                                                                {
                                                                    contDecimalesLoZ = 5;
                                                                }
                                                            }
                                                            leerZ++;
                                                            //leerNomX++;
                                                        }
                                                        dgv_datos.Rows[posiDatos].Cells[6].Value = finalLoZ;
                                                        /** termino de leer LO_TOL de Z **/

                                                        /** acá voy leyendo CRIT/OOT de Z **/
                                                        leerZ++;
                                                        string auxCritZ = auxZ;
                                                        char[] pCritZ = auxCritZ.ToCharArray();
                                                        string finalCritZ = "";
                                                        for (int i = leerZ; i < pCritZ.Length; i++)
                                                        {
                                                            if (pCritZ[i] != ' ')
                                                            {
                                                                finalCritZ += pCritZ[i];
                                                            }
                                                        }
                                                        dgv_datos.Rows[posiDatos].Cells[7].Value = finalCritZ;
                                                        /** termino de leer CRIT/OOT de Z **/

                                                        fila++; //avanzo a la proxima linea en el documento dmo
                                                        posiDatos++; //avanzo a la proxima linea libre del dgv_datos
                                                    }
                                                }
                                                //TERMINO DE LEER Z
                                            }
                                        }
                                        //TERMINO DE LEER Y  
                                    }
                                    else
                                    {
                                        //ACÁ LEO DISTRIB
                                            int contDecimalesD = 0;
                                            int comaD = 0;
                                            dgv_datos.Rows[posiDatos].Cells[0].Value = final;
                                            dgv_datos.Rows[posiDatos].Cells[1].Value = s2[0];
                                            /** acá voy leyendo NOMINAL de D **/
                                            char[] pD = aux2.ToCharArray();
                                            int leerD = 5;
                                            string finalD = "";
                                            while (contDecimalesD < 5)
                                            {
                                                if (pD[leerD] != ' ')
                                                {
                                                    finalD += pD[leerD];
                                                    if (pD[leerD] == '.')
                                                    {
                                                        comaD = 1;
                                                    }

                                                    if (pD[leerD] != ' ' && comaD == 1 && pD[leerD + 1] != ' ')
                                                    {
                                                        contDecimalesD++;
                                                    }

                                                    if (pD[leerD - 4] == '.')
                                                    {
                                                        contDecimalesD = 5;
                                                    }
                                                }
                                                leerD++;
                                            }
                                            dgv_datos.Rows[posiDatos].Cells[2].Value = finalD;
                                        /** termino de leer el MEASURED de D **/

                                        /** acá voy leyendo NOMINAL de D **/
                                        leerD++; //hago avanzar un lugar el puntero, para empezar a leer nominal
                                        int comaNomD = 0; //reinicializo a 0 el contador que indica la presencia de un "."
                                        int contDecimalesNomD = 0; //reinicializo a 0 el contador que indica que ya hay 4 decimales
                                        //string auxNomX = aux2.Remove(0,leer2);
                                        string auxNomD = aux2;
                                        //MessageBox.Show(auxNomX);
                                        char[] pNomD = auxNomD.ToCharArray();
                                        //int leerNomX = 0;
                                        string finalNomD = "";
                                        while (contDecimalesNomD < 5)
                                        {
                                            if (pNomD[leerD] != ' ')
                                            {
                                                finalNomD += pNomD[leerD];
                                                if (pNomD[leerD] == '.')
                                                {
                                                    comaNomD = 1;
                                                }

                                                if (pNomD[leerD] != ' ' && comaNomD == 1 && pNomD[leerD + 1] != ' ')
                                                {
                                                    contDecimalesNomD++;
                                                }

                                                if (pNomD[leerD - 4] == '.')
                                                {
                                                    contDecimalesNomD = 5;
                                                }
                                            }
                                            leerD++;
                                            //leerNomX++;
                                        }
                                        dgv_datos.Rows[posiDatos].Cells[3].Value = finalNomD;
                                        /** termino de leer NOMINAL de D **/

                                        /** acá voy leyendo DEVIATION de D **/
                                        leerD++; //hago avanzar un lugar el puntero, para empezar a leer nominal
                                        int comaDevD = 0; //reinicializo a 0 el contador que indica la presencia de un "."
                                        int contDecimalesDevD = 0; //reinicializo a 0 el contador que indica que ya hay 4 decimales
                                        //string auxNomX = aux2.Remove(0,leer2);
                                        string auxDevD = aux2;
                                        //MessageBox.Show(auxNomX);
                                        char[] pDevD = auxDevD.ToCharArray();
                                        //int leerNomX = 0;
                                        string finalDevD = "";
                                        while (contDecimalesDevD < 5)
                                        {
                                            if (pDevD[leerD] != ' ')
                                            {
                                                finalDevD += pDevD[leerD];
                                                if (pDevD[leerD] == '.')
                                                {
                                                    comaDevD = 1;
                                                }

                                                if (pDevD[leerD] != ' ' && comaDevD == 1 && pDevD[leerD + 1] != ' ')
                                                {
                                                    contDecimalesDevD++;
                                                }

                                                if (pDevD[leerD - 4] == '.')
                                                {
                                                    contDecimalesDevD = 5;
                                                }
                                            }
                                            leerD++;
                                            //leerNomX++;
                                        }
                                        dgv_datos.Rows[posiDatos].Cells[4].Value = finalDevD;
                                        /** termino de leer DEVIATION de D **/

                                        /** acá voy leyendo UP_TOL de D **/
                                        leerD++; //hago avanzar un lugar el puntero, para empezar a leer nominal
                                        int comaUpD = 0; //reinicializo a 0 el contador que indica la presencia de un "."
                                        int contDecimalesUpD = 0; //reinicializo a 0 el contador que indica que ya hay 4 decimales
                                        //string auxNomX = aux2.Remove(0,leer2);
                                        string auxUpD = aux2;
                                        //MessageBox.Show(auxNomX);
                                        char[] pUpD = auxUpD.ToCharArray();
                                        //int leerNomX = 0;
                                        string finalUpD = "";
                                        while (contDecimalesUpD < 5)
                                        {
                                            if (pUpD[leerD] != ' ')
                                            {
                                                finalUpD += pUpD[leerD];
                                                if (pUpD[leerD] == '.')
                                                {
                                                    comaUpD = 1;
                                                }

                                                if (pUpD[leerD] != ' ' && comaUpD == 1 && pUpD[leerD + 1] != ' ')
                                                {
                                                    contDecimalesUpD++;
                                                }

                                                if (pUpD[leerD - 4] == '.')
                                                {
                                                    contDecimalesUpD = 5;
                                                }
                                            }
                                            leerD++;
                                            //leerNomX++;
                                        }
                                        dgv_datos.Rows[posiDatos].Cells[5].Value = finalUpD;
                                        /** termino de leer UP_TOL de D **/

                                        /** acá voy leyendo LO_TOL de D **/
                                        leerD++; //hago avanzar un lugar el puntero, para empezar a leer nominal
                                        int comaLoD = 0; //reinicializo a 0 el contador que indica la presencia de un "."
                                        int contDecimalesLoD = 0; //reinicializo a 0 el contador que indica que ya hay 4 decimales
                                        //string auxNomX = aux2.Remove(0,leer2);
                                        string auxLoD = aux2;
                                        //MessageBox.Show(auxNomX);
                                        char[] pLoD = auxLoD.ToCharArray();
                                        //int leerNomX = 0;
                                        string finalLoD = "";
                                        while (contDecimalesLoD < 5)
                                        {
                                            if (pLoD[leerD] != ' ')
                                            {
                                                finalLoD += pLoD[leerD];
                                                if (pLoD[leerD] == '.')
                                                {
                                                    comaLoD = 1;
                                                }

                                                if (pLoD[leerD] != ' ' && comaLoD == 1 && pLoD[leerD + 1] != ' ')
                                                {
                                                    contDecimalesLoD++;
                                                }

                                                if (pLoD[leerD - 4] == '.')
                                                {
                                                    contDecimalesLoD = 5;
                                                }
                                            }
                                            leerD++;
                                            //leerNomX++;
                                        }
                                        dgv_datos.Rows[posiDatos].Cells[6].Value = finalLoD;
                                        /** termino de leer LO_TOL de D **/

                                        /** acá voy leyendo CRIT/OOT de D **/
                                        leerD++;
                                        string auxCritD = aux2;
                                        char[] pCritD = auxCritD.ToCharArray();
                                        string finalCritD = "";
                                        for (int i = leerD; i < pCritD.Length; i++)
                                        {
                                            if (pCritD[i] != ' ')
                                            {
                                                finalCritD += pCritD[i];
                                            }
                                        }
                                        dgv_datos.Rows[posiDatos].Cells[7].Value = finalCritD;
                                        /** termino de leer CRIT/OOT de D **/

                                        fila++; //avanzo a la linea siguiente en el documento dmo
                                        posiDatos++; //avanzo a la proxima posicion libre en el dgv_datos
                                        //TERMINO DE LEER DISTRIB
                                    }
                                }
                                posi++;
                            }
                        }
                    }
                }
                MessageBox.Show("La cantidad de puntos (medidos) en el Documento DMO es de: " + puntos);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_Datos_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(this.openFileDialog1.FileName))
                {
                    ARCHIVO = this.openFileDialog1.FileName;
                    l.lecturaArchivo(dgv_Dmo, ',', ARCHIVO);
                    recuperarDatos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString());
            }
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btn_Alta_Click(object sender, EventArgs e)
        {
            mensaje = "Se llevaron a cabo con éxito los siguientes registros:" + "\n";
            Conexion.Open();
            adaptador.InsertCommand.Parameters["@codDmo"].Value = txt_CodigoDmo.Text;

            //busco el código del Documento DMO para comprobar si ya existe
            SqlDataAdapter auxDmo = new SqlDataAdapter("SELECT codDmo FROM documentosDmo WHERE codDmo=@codDmo", Conexion);
            DataTable tDmo = new DataTable();
            auxDmo.SelectCommand.Parameters.Add(new SqlParameter("@codDmo", SqlDbType.VarChar));
            auxDmo.SelectCommand.Parameters["@codDmo"].Value = txt_CodigoDmo.Text;
            auxDmo.Fill(tDmo);
            if (tDmo.Rows.Count == 0) //CONSULTO SI LA TABLA QUE RECUPERA EL SELECT TIENE FILAS, SI ES ASI, EL DOCUMENTO DMO YA FUE REGISTRADO
            {
                //busco el código del Control Plan al que está asociado este Documento DMO
                SqlDataAdapter aux_codCPlan = new SqlDataAdapter("SELECT codCPlan FROM controlPlan WHERE codPrograma=@codPrograma", Conexion);
                aux_codCPlan.SelectCommand.Parameters.Add(new SqlParameter("@codPrograma", SqlDbType.VarChar));
                aux_codCPlan.SelectCommand.Parameters["@codPrograma"].Value = txt_Programa.Text;
                DataTable dt_codCPlan = new DataTable();
                aux_codCPlan.Fill(dt_codCPlan);
                string codCPlan = "";
                if (dt_codCPlan.Rows.Count == 0)
                {
                    MessageBox.Show("El Control Plan al que está asociado este DMO no existe en la base de datos. Posiblemente se trate de un Control Plan ACTUALIZADO. Avise inmediatamente al RESPONSABLE a cargo.","URGENTE!",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    limpiar();
                    Conexion.Close();
                }
                else
                {
                    codCPlan = dt_codCPlan.Rows[0][0].ToString();
                    //termino de buscar el código del Control Plan
                    adaptador.InsertCommand.Parameters["@codCPlan"].Value = Convert.ToInt32(codCPlan);

                    //busco el código del Establecimiento al que está asociado este Documento DMO
                    SqlDataAdapter aux_codEstablecimiento = new SqlDataAdapter("SELECT codEstablecimiento FROM establecimientos WHERE codEstablecimiento=@codEstablecimiento", Conexion);
                    aux_codEstablecimiento.SelectCommand.Parameters.Add(new SqlParameter("@codEstablecimiento", SqlDbType.VarChar));
                    aux_codEstablecimiento.SelectCommand.Parameters["@codEstablecimiento"].Value = txt_Establecimiento.Text;
                    DataTable dt_codEstablecimiento = new DataTable();
                    aux_codEstablecimiento.Fill(dt_codEstablecimiento);
                    if (dt_codEstablecimiento.Rows.Count == 0)
                    {
                        MessageBox.Show("El Establecimiento al que está asociado este DMO no existe en la base de datos. Avise inmediatamente al Administrador y/o al Responsable a cargo.", "URGENTE!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        limpiar();
                        Conexion.Close();
                    }
                    else
                    {
                        //termino de buscar el código del Establecimiento
                        adaptador.InsertCommand.Parameters["@codEstablecimiento"].Value = txt_Establecimiento.Text;

                        //busco el código del Grupo al que está asociado este Documento DMO
                        SqlDataAdapter aux_codGrupo = new SqlDataAdapter("SELECT codTipoV FROM tiposVehiculo WHERE codTipoV=@codTipoV", Conexion);
                        aux_codGrupo.SelectCommand.Parameters.Add(new SqlParameter("@codTipoV", SqlDbType.VarChar));
                        aux_codGrupo.SelectCommand.Parameters["@codTipoV"].Value = txt_Guia.Text;
                        DataTable dt_codGrupo = new DataTable();
                        aux_codGrupo.Fill(dt_codGrupo);
                        if (dt_codGrupo.Rows.Count == 0)
                        {
                            MessageBox.Show("El Grupo (Tipo de Vehículo) al que está asociado este DMO no existe en la base de datos. Avise inmediatamente al Administrador y/o al Responsable a cargo.", "URGENTE!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            limpiar();
                            Conexion.Close();
                        }
                        else
                        {
                            //termino de buscar el código del Grupo
                            adaptador.InsertCommand.Parameters["@codGrupo"].Value = txt_Guia.Text;

                            //busco el código del Operario al que está asociado este Documento DMO
                            SqlDataAdapter aux_codOper = new SqlDataAdapter("SELECT codOper FROM operariosMaquina WHERE nomOper=@nomOper", Conexion);
                            aux_codOper.SelectCommand.Parameters.Add(new SqlParameter("@nomOper", SqlDbType.VarChar));
                            aux_codOper.SelectCommand.Parameters["@nomOper"].Value = txt_Programador.Text;
                            DataTable dt_codOper = new DataTable();
                            aux_codOper.Fill(dt_codOper);
                            string codOper = "";
                            if (dt_codOper.Rows.Count == 0)
                            {
                                MessageBox.Show("El Operario de Máquina al que está asociado este DMO no existe en la base de datos. Avise inmediatamente al Administrador y/o al Responsable a cargo.", "URGENTE!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                limpiar();
                                Conexion.Close();
                            }
                            else
                            {
                                codOper = dt_codOper.Rows[0][0].ToString();
                                //termino de buscar el código del Operario
                                adaptador.InsertCommand.Parameters["@codOper"].Value = Convert.ToInt32(codOper);

                                //busco el código de la Regla de Salida al que está asociado este Documento DMO
                                SqlDataAdapter aux_codRegla = new SqlDataAdapter("SELECT codRegla FROM reglasMedicion WHERE descRegla=@descRegla", Conexion);
                                aux_codRegla.SelectCommand.Parameters.Add(new SqlParameter("@descRegla", SqlDbType.VarChar));
                                aux_codRegla.SelectCommand.Parameters["@descRegla"].Value = txt_Regla.Text;
                                DataTable dt_codRegla = new DataTable();
                                aux_codRegla.Fill(dt_codRegla);
                                string codRegla = "";
                                if (dt_codRegla.Rows.Count == 0)
                                {
                                    MessageBox.Show("La Regla de Salida (Regla de Medición) a la que está asociado este DMO no existe en la base de datos. Avise inmediatamente al Administrador y/o al Responsable a cargo.", "URGENTE!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    limpiar();
                                    Conexion.Close();
                                }
                                else
                                {
                                    codRegla = dt_codRegla.Rows[0][0].ToString();
                                    //termino de buscar el código de la Regla de Salida
                                    adaptador.InsertCommand.Parameters["@codRegla"].Value = Convert.ToInt32(codRegla);

                                    adaptador.InsertCommand.Parameters["@chasisDmo"].Value = txt_Lote.Text;
                                    adaptador.InsertCommand.Parameters["@fechaDmo"].Value = Convert.ToDateTime(txt_FechaDmo.Text);
                                    adaptador.InsertCommand.Parameters["@hora"].Value = Convert.ToDateTime(txt_HoraDmo.Text);
                                    
                                    try
                                    {
                                        adaptador.InsertCommand.ExecuteNonQuery();
                                        mensaje += "- Registro de Documento DMO." + "\n";

                                        ////////////////////////////////////////////
                                        try
                                        {
                                            //COMIENZO CON EL REGISTRO DEL DETALLE DEL DOCUMENTO DMO
                                            detalleDmo = new SqlDataAdapter();
                                            SqlCommand agrega_detalleDmo = new SqlCommand("INSERT INTO detallesDocumentoDmo (codDmo,codCPlan,idPtoMed) VALUES (@codDmo,@codCPlan,@idPtoMed)", Conexion);
                                            detalleDmo.InsertCommand = agrega_detalleDmo;
                                            int contadorPtosNoIncluidos = 0;
                                            foreach (DataGridViewRow fila_detalle in dgv_nombresPuntos.Rows)
                                            {

                                                SqlDataAdapter existePunto = new SqlDataAdapter("SELECT idPtoMed FROM detallesControlPlan WHERE idPtoMed=@idPtoMed", Conexion);
                                                existePunto.SelectCommand.Parameters.Clear();
                                                existePunto.SelectCommand.Parameters.Add(new SqlParameter("@idPtoMed", SqlDbType.VarChar));
                                                existePunto.SelectCommand.Parameters["@idPtoMed"].Value = Convert.ToString(fila_detalle.Cells["dataGridViewTextBoxColumn1"].Value);
                                                DataTable dt_existePunto = new DataTable();
                                                existePunto.Fill(dt_existePunto);
                                                if (dt_existePunto.Rows.Count == 0)
                                                {
                                                    contadorPtosNoIncluidos++;
                                                }
                                                else
                                                {
                                                    detalleDmo.InsertCommand.Parameters.Clear();

                                                    detalleDmo.InsertCommand.Parameters.Add(new SqlParameter("@codDmo", SqlDbType.VarChar));
                                                    detalleDmo.InsertCommand.Parameters.Add(new SqlParameter("@codCPlan", SqlDbType.Int));
                                                    detalleDmo.InsertCommand.Parameters.Add(new SqlParameter("@idPtoMed", SqlDbType.VarChar));

                                                    detalleDmo.InsertCommand.Parameters["@codDmo"].Value = txt_CodigoDmo.Text;
                                                    detalleDmo.InsertCommand.Parameters["@codCPlan"].Value = Convert.ToInt32(codCPlan);
                                                    detalleDmo.InsertCommand.Parameters["@idPtoMed"].Value = Convert.ToString(fila_detalle.Cells["dataGridViewTextBoxColumn1"].Value);

                                                    detalleDmo.InsertCommand.ExecuteNonQuery();
                                                }
                                            }
                                            MessageBox.Show("DURANTE EL REGISTRO DE DETALLE DE DOCUMENTO DMO NO SE ENCONTRARON UNO O VARIOS CÓDIGOS DE MEDICIÓN ASOCIADOS. Cantidad de errores: " + contadorPtosNoIncluidos, "URGENTE!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                            //FIN DEL REGISTRO DEL DETALLE DEL DOCUMENTO DMO
                                            mensaje += "- Registro de Detalle del Documento DMO." + "\n";

                                            //COMIENZO EL REGISTRO DE PUNTOS MEDIDOS EN X
                                            try
                                            {
                                                medidoX = new SqlDataAdapter();
                                                SqlCommand agrega_medidoX = new SqlCommand("INSERT INTO puntosMedidosX (codDmo,codMedicion,codMediX,medidoX,nominalX,desvX,upTolX,loTolX,critOotX) VALUES (@codDmo,@codMedicion,@codMediX,@medidoX,@nominalX,@desvX,@upTolX,@loTolX,@critOotX)", Conexion);
                                                medidoX.InsertCommand = agrega_medidoX;
                                                string decisionX = "";
                                                string critOotX = "";
                                                string codMedicionX = "";
                                                string aux_medidoX = "";
                                                string aux_nominalX = "";
                                                string aux_desvX = "";
                                                string aux_upTolX = "";
                                                string aux_loTolX = "";
                                                string aux_critOotX = "";
                                                CultureInfo culture = new CultureInfo("en-US");
                                                foreach (DataGridViewRow fila_medidoX in dgv_datos.Rows)
                                                {
                                                    decisionX = Convert.ToString(fila_medidoX.Cells["Coordenada"].Value); //leo la celda correspondiente para saber si debo registrar en puntosMedidosX o no
                                                    if (decisionX == "X")
                                                    {

                                                        medidoX.InsertCommand.Parameters.Clear();

                                                        medidoX.InsertCommand.Parameters.Add(new SqlParameter("@codDmo", SqlDbType.VarChar));
                                                        medidoX.InsertCommand.Parameters.Add(new SqlParameter("@codMedicion", SqlDbType.Int));
                                                        medidoX.InsertCommand.Parameters.Add(new SqlParameter("@codMediX", SqlDbType.VarChar));
                                                        medidoX.InsertCommand.Parameters.Add(new SqlParameter("@medidoX", SqlDbType.Decimal));
                                                        medidoX.InsertCommand.Parameters.Add(new SqlParameter("@nominalX", SqlDbType.Decimal));
                                                        medidoX.InsertCommand.Parameters.Add(new SqlParameter("@desvX", SqlDbType.Decimal));
                                                        medidoX.InsertCommand.Parameters.Add(new SqlParameter("@upTolX", SqlDbType.Decimal));
                                                        medidoX.InsertCommand.Parameters.Add(new SqlParameter("@loTolX", SqlDbType.Decimal));
                                                        medidoX.InsertCommand.Parameters.Add(new SqlParameter("@critOotX", SqlDbType.Decimal));

                                                        medidoX.InsertCommand.Parameters["@codDmo"].Value = txt_CodigoDmo.Text;

                                                        //busco el codMedicion


                                                        SqlDataAdapter aux_codMedicionX = new SqlDataAdapter("SELECT d.codMedicion FROM detallesDocumentoDmo AS d WHERE d.idPtoMed=@idPtoMed AND d.codDmo=@codDmo", Conexion);
                                                        aux_codMedicionX.SelectCommand.Parameters.Clear();

                                                        aux_codMedicionX.SelectCommand.Parameters.Add(new SqlParameter("@idPtoMed", SqlDbType.VarChar));
                                                        aux_codMedicionX.SelectCommand.Parameters.Add(new SqlParameter("@codDmo", SqlDbType.VarChar));
                                                        aux_codMedicionX.SelectCommand.Parameters["@idPtoMed"].Value = Convert.ToString(fila_medidoX.Cells["Punto"].Value);
                                                        aux_codMedicionX.SelectCommand.Parameters["@codDmo"].Value = txt_CodigoDmo.Text;
                                                        DataTable dt_codMedicionX = new DataTable();
                                                        aux_codMedicionX.Fill(dt_codMedicionX);
                                                        codMedicionX = "";
                                                        if (dt_codMedicionX.Rows.Count == 0)
                                                        {
                                                            //MessageBox.Show("ERROR DURANTE EL REGISTRO DE PUNTOS MEDIDOS EN X. NO SE ENCONTRO UN CODIGO DE MEDICION ASOCIADO.", "URGENTE!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                                            //limpiar();
                                                            //Conexion.Close();
                                                        }
                                                        else
                                                        {
                                                            codMedicionX = dt_codMedicionX.Rows[0][0].ToString();
                                                            //termino de buscar el código de la Medicion
                                                            medidoX.InsertCommand.Parameters["@codMedicion"].Value = Convert.ToInt32(codMedicionX);
                                                            medidoX.InsertCommand.Parameters["@codMediX"].Value = Convert.ToString(fila_medidoX.Cells["Punto"].Value);
                                                            aux_medidoX = Convert.ToString(fila_medidoX.Cells["dataGridViewTextBoxColumn2"].Value);
                                                            medidoX.InsertCommand.Parameters["@medidoX"].Value = decimal.Parse(aux_medidoX, culture);
                                                            aux_nominalX = Convert.ToString(fila_medidoX.Cells["Nominal"].Value);
                                                            medidoX.InsertCommand.Parameters["@nominalX"].Value = decimal.Parse(aux_nominalX, culture);
                                                            aux_desvX = Convert.ToString(fila_medidoX.Cells["Desviación"].Value);
                                                            medidoX.InsertCommand.Parameters["@desvX"].Value = decimal.Parse(aux_desvX, culture);
                                                            aux_upTolX = Convert.ToString(fila_medidoX.Cells["UpTol"].Value);
                                                            medidoX.InsertCommand.Parameters["@upTolX"].Value = decimal.Parse(aux_upTolX, culture);
                                                            aux_loTolX = Convert.ToString(fila_medidoX.Cells["LoTol"].Value);
                                                            medidoX.InsertCommand.Parameters["@loTolX"].Value = decimal.Parse(aux_loTolX, culture);

                                                            critOotX = Convert.ToString(fila_medidoX.Cells["CritOot"].Value);
                                                            if (string.IsNullOrWhiteSpace(critOotX))
                                                            {
                                                                medidoX.InsertCommand.Parameters["@critOotX"].Value = DBNull.Value;
                                                            }
                                                            else
                                                            {
                                                                aux_critOotX = Convert.ToString(fila_medidoX.Cells["CritOot"].Value);
                                                                medidoX.InsertCommand.Parameters["@critOotX"].Value = decimal.Parse(aux_critOotX, culture);
                                                            }

                                                            medidoX.InsertCommand.ExecuteNonQuery();
                                                        }
                                                        //fin de busqueda

                                                    }
                                                 }
                                                    mensaje += "- Registro de Puntos Medidos en X." + "\n";
                                                //FIN DEL REGISTRO DE PUNTOS MEDIDOS EN X

                                                //COMIENZO EL REGISTRO DE PUNTOS MEDIDOS EN Y
                                                try
                                                {
                                                    medidoY = new SqlDataAdapter();
                                                    SqlCommand agrega_medidoY = new SqlCommand("INSERT INTO puntosMedidosY (codDmo,codMedicion,codMediY,medidoY,nominalY,desvY,upTolY,loTolY,critOotY) VALUES (@codDmo,@codMedicion,@codMediY,@medidoY,@nominalY,@desvY,@upTolY,@loTolY,@critOotY)", Conexion);
                                                    medidoY.InsertCommand = agrega_medidoY;
                                                    string decisionY = "";
                                                    string critOotY = "";
                                                    string codMedicionY = "";
                                                    string aux_medidoY = "";
                                                    string aux_nominalY = "";
                                                    string aux_desvY = "";
                                                    string aux_upTolY = "";
                                                    string aux_loTolY = "";
                                                    string aux_critOotY = "";
                                                    //CultureInfo culture = new CultureInfo("en-US"); >> YA SE DEFINIO ANTES
                                                    foreach (DataGridViewRow fila_medidoY in dgv_datos.Rows)
                                                    {
                                                        decisionY = Convert.ToString(fila_medidoY.Cells["Coordenada"].Value); //leo la celda correspondiente para saber si debo registrar en puntosMedidosX o no
                                                        if (decisionY == "Y")
                                                        {

                                                            medidoY.InsertCommand.Parameters.Clear();

                                                            medidoY.InsertCommand.Parameters.Add(new SqlParameter("@codDmo", SqlDbType.VarChar));
                                                            medidoY.InsertCommand.Parameters.Add(new SqlParameter("@codMedicion", SqlDbType.Int));
                                                            medidoY.InsertCommand.Parameters.Add(new SqlParameter("@codMediY", SqlDbType.VarChar));
                                                            medidoY.InsertCommand.Parameters.Add(new SqlParameter("@medidoY", SqlDbType.Decimal));
                                                            medidoY.InsertCommand.Parameters.Add(new SqlParameter("@nominalY", SqlDbType.Decimal));
                                                            medidoY.InsertCommand.Parameters.Add(new SqlParameter("@desvY", SqlDbType.Decimal));
                                                            medidoY.InsertCommand.Parameters.Add(new SqlParameter("@upTolY", SqlDbType.Decimal));
                                                            medidoY.InsertCommand.Parameters.Add(new SqlParameter("@loTolY", SqlDbType.Decimal));
                                                            medidoY.InsertCommand.Parameters.Add(new SqlParameter("@critOotY", SqlDbType.Decimal));

                                                            medidoY.InsertCommand.Parameters["@codDmo"].Value = txt_CodigoDmo.Text;

                                                            //busco el codMedicion


                                                            SqlDataAdapter aux_codMedicionY = new SqlDataAdapter("SELECT d.codMedicion FROM detallesDocumentoDmo AS d WHERE d.idPtoMed=@idPtoMed AND d.codDmo=@codDmo", Conexion);
                                                            aux_codMedicionY.SelectCommand.Parameters.Clear();

                                                            aux_codMedicionY.SelectCommand.Parameters.Add(new SqlParameter("@idPtoMed", SqlDbType.VarChar));
                                                            aux_codMedicionY.SelectCommand.Parameters.Add(new SqlParameter("@codDmo", SqlDbType.VarChar));
                                                            aux_codMedicionY.SelectCommand.Parameters["@idPtoMed"].Value = Convert.ToString(fila_medidoY.Cells["Punto"].Value);
                                                            aux_codMedicionY.SelectCommand.Parameters["@codDmo"].Value = txt_CodigoDmo.Text;
                                                            DataTable dt_codMedicionY = new DataTable();
                                                            aux_codMedicionY.Fill(dt_codMedicionY);
                                                            codMedicionY = "";
                                                            if (dt_codMedicionY.Rows.Count == 0)
                                                            {
                                                                //MessageBox.Show("ERROR DURANTE EL REGISTRO DE PUNTOS MEDIDOS EN Y. NO SE ENCONTRO UN CODIGO DE MEDICION ASOCIADO.", "URGENTE!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                                                //limpiar();
                                                                //Conexion.Close();
                                                            }
                                                            else
                                                            {
                                                                codMedicionY = dt_codMedicionY.Rows[0][0].ToString();
                                                                //termino de buscar el código de la Medicion
                                                                medidoY.InsertCommand.Parameters["@codMedicion"].Value = Convert.ToInt32(codMedicionY);
                                                                medidoY.InsertCommand.Parameters["@codMediY"].Value = Convert.ToString(fila_medidoY.Cells["Punto"].Value);
                                                                aux_medidoY = Convert.ToString(fila_medidoY.Cells["dataGridViewTextBoxColumn2"].Value);
                                                                medidoY.InsertCommand.Parameters["@medidoY"].Value = decimal.Parse(aux_medidoY, culture);
                                                                aux_nominalY = Convert.ToString(fila_medidoY.Cells["Nominal"].Value);
                                                                medidoY.InsertCommand.Parameters["@nominalY"].Value = decimal.Parse(aux_nominalY, culture);
                                                                aux_desvY = Convert.ToString(fila_medidoY.Cells["Desviación"].Value);
                                                                medidoY.InsertCommand.Parameters["@desvY"].Value = decimal.Parse(aux_desvY, culture);
                                                                aux_upTolY = Convert.ToString(fila_medidoY.Cells["UpTol"].Value);
                                                                medidoY.InsertCommand.Parameters["@upTolY"].Value = decimal.Parse(aux_upTolY, culture);
                                                                aux_loTolY = Convert.ToString(fila_medidoY.Cells["LoTol"].Value);
                                                                medidoY.InsertCommand.Parameters["@loTolY"].Value = decimal.Parse(aux_loTolY, culture);

                                                                critOotY = Convert.ToString(fila_medidoY.Cells["CritOot"].Value);
                                                                if (string.IsNullOrWhiteSpace(critOotY))
                                                                {
                                                                    medidoY.InsertCommand.Parameters["@critOotY"].Value = DBNull.Value;
                                                                }
                                                                else
                                                                {
                                                                    aux_critOotY = Convert.ToString(fila_medidoY.Cells["CritOot"].Value);
                                                                    medidoY.InsertCommand.Parameters["@critOotY"].Value = decimal.Parse(aux_critOotY, culture);
                                                                }

                                                                medidoY.InsertCommand.ExecuteNonQuery();
                                                            }
                                                            //fin de busqueda

                                                        }
                                                    }
                                                    mensaje += "- Registro de Puntos Medidos en Y." + "\n";
                                                    //FIN DEL REGISTRO DE PUNTOS MEDIDOS EN Y

                                                    //COMIENZO EL REGISTRO DE PUNTOS MEDIDOS EN Z
                                                    try
                                                    {
                                                        medidoZ = new SqlDataAdapter();
                                                        SqlCommand agrega_medidoZ = new SqlCommand("INSERT INTO puntosMedidosZ (codDmo,codMedicion,codMediZ,medidoZ,nominalZ,desvZ,upTolZ,loTolZ,critOotZ) VALUES (@codDmo,@codMedicion,@codMediZ,@medidoZ,@nominalZ,@desvZ,@upTolZ,@loTolZ,@critOotZ)", Conexion);
                                                        medidoZ.InsertCommand = agrega_medidoZ;
                                                        string decisionZ = "";
                                                        string critOotZ = "";
                                                        string codMedicionZ = "";
                                                        string aux_medidoZ = "";
                                                        string aux_nominalZ = "";
                                                        string aux_desvZ = "";
                                                        string aux_upTolZ = "";
                                                        string aux_loTolZ = "";
                                                        string aux_critOotZ = "";
                                                        //CultureInfo culture = new CultureInfo("en-US"); >> YA SE DEFINIO ANTES
                                                        foreach (DataGridViewRow fila_medidoZ in dgv_datos.Rows)
                                                        {
                                                            decisionZ = Convert.ToString(fila_medidoZ.Cells["Coordenada"].Value); //leo la celda correspondiente para saber si debo registrar en puntosMedidosX o no
                                                            if (decisionZ == "Z")
                                                            {

                                                                medidoZ.InsertCommand.Parameters.Clear();

                                                                medidoZ.InsertCommand.Parameters.Add(new SqlParameter("@codDmo", SqlDbType.VarChar));
                                                                medidoZ.InsertCommand.Parameters.Add(new SqlParameter("@codMedicion", SqlDbType.Int));
                                                                medidoZ.InsertCommand.Parameters.Add(new SqlParameter("@codMediZ", SqlDbType.VarChar));
                                                                medidoZ.InsertCommand.Parameters.Add(new SqlParameter("@medidoZ", SqlDbType.Decimal));
                                                                medidoZ.InsertCommand.Parameters.Add(new SqlParameter("@nominalZ", SqlDbType.Decimal));
                                                                medidoZ.InsertCommand.Parameters.Add(new SqlParameter("@desvZ", SqlDbType.Decimal));
                                                                medidoZ.InsertCommand.Parameters.Add(new SqlParameter("@upTolZ", SqlDbType.Decimal));
                                                                medidoZ.InsertCommand.Parameters.Add(new SqlParameter("@loTolZ", SqlDbType.Decimal));
                                                                medidoZ.InsertCommand.Parameters.Add(new SqlParameter("@critOotZ", SqlDbType.Decimal));

                                                                medidoZ.InsertCommand.Parameters["@codDmo"].Value = txt_CodigoDmo.Text;

                                                                //busco el codMedicion


                                                                //SqlDataAdapter aux_codMedicionZ = new SqlDataAdapter("SELECT codMedicion FROM detallesDocumentoDmo WHERE idPtoMed=@idPtoMed", Conexion);
                                                                SqlDataAdapter aux_codMedicionZ = new SqlDataAdapter("SELECT d.codMedicion FROM detallesDocumentoDmo AS d WHERE d.idPtoMed=@idPtoMed AND d.codDmo=@codDmo", Conexion);
                                                                //SELECT d.codMedicion FROM detallesDocumentoDmo AS d WHERE d.idPtoMed=@idPtoMed AND d.codMedicion NOT IN (SELECT codMedicion FROM puntosMedidosZ)
                                                                aux_codMedicionZ.SelectCommand.Parameters.Clear();

                                                                aux_codMedicionZ.SelectCommand.Parameters.Add(new SqlParameter("@idPtoMed", SqlDbType.VarChar));
                                                                aux_codMedicionZ.SelectCommand.Parameters.Add(new SqlParameter("@codDmo", SqlDbType.VarChar));
                                                                aux_codMedicionZ.SelectCommand.Parameters["@idPtoMed"].Value = Convert.ToString(fila_medidoZ.Cells["Punto"].Value);
                                                                aux_codMedicionZ.SelectCommand.Parameters["@codDmo"].Value = txt_CodigoDmo.Text;
                                                                DataTable dt_codMedicionZ = new DataTable();
                                                                aux_codMedicionZ.Fill(dt_codMedicionZ);
                                                                codMedicionZ = "";
                                                                if (dt_codMedicionZ.Rows.Count == 0)
                                                                {
                                                                    //MessageBox.Show("ERROR DURANTE EL REGISTRO DE PUNTOS MEDIDOS EN Z. NO SE ENCONTRO UN CODIGO DE MEDICION ASOCIADO.", "URGENTE!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                                                    //limpiar();
                                                                    //Conexion.Close();
                                                                }
                                                                else
                                                                {
                                                                    codMedicionZ = dt_codMedicionZ.Rows[0][0].ToString();
                                                                    //termino de buscar el código de la Medicion
                                                                    medidoZ.InsertCommand.Parameters["@codMedicion"].Value = Convert.ToInt32(codMedicionZ);
                                                                    medidoZ.InsertCommand.Parameters["@codMediZ"].Value = Convert.ToString(fila_medidoZ.Cells["Punto"].Value);
                                                                    aux_medidoZ = Convert.ToString(fila_medidoZ.Cells["dataGridViewTextBoxColumn2"].Value);
                                                                    medidoZ.InsertCommand.Parameters["@medidoZ"].Value = decimal.Parse(aux_medidoZ, culture);
                                                                    aux_nominalZ = Convert.ToString(fila_medidoZ.Cells["Nominal"].Value);
                                                                    medidoZ.InsertCommand.Parameters["@nominalZ"].Value = decimal.Parse(aux_nominalZ, culture);
                                                                    aux_desvZ = Convert.ToString(fila_medidoZ.Cells["Desviación"].Value);
                                                                    medidoZ.InsertCommand.Parameters["@desvZ"].Value = decimal.Parse(aux_desvZ, culture);
                                                                    aux_upTolZ = Convert.ToString(fila_medidoZ.Cells["UpTol"].Value);
                                                                    medidoZ.InsertCommand.Parameters["@upTolZ"].Value = decimal.Parse(aux_upTolZ, culture);
                                                                    aux_loTolZ = Convert.ToString(fila_medidoZ.Cells["LoTol"].Value);
                                                                    medidoZ.InsertCommand.Parameters["@loTolZ"].Value = decimal.Parse(aux_loTolZ, culture);

                                                                    critOotZ = Convert.ToString(fila_medidoZ.Cells["CritOot"].Value);
                                                                    if (string.IsNullOrWhiteSpace(critOotZ))
                                                                    {
                                                                        medidoZ.InsertCommand.Parameters["@critOotZ"].Value = DBNull.Value;
                                                                    }
                                                                    else
                                                                    {
                                                                        aux_critOotZ = Convert.ToString(fila_medidoZ.Cells["CritOot"].Value);
                                                                        medidoZ.InsertCommand.Parameters["@critOotZ"].Value = decimal.Parse(aux_critOotZ, culture);
                                                                    }

                                                                    medidoZ.InsertCommand.ExecuteNonQuery();
                                                                }
                                                                //fin de busqueda

                                                            }
                                                        }
                                                        mensaje += "- Registro de Puntos Medidos en Z." + "\n";
                                                        //FIN DEL REGISTRO DE PUNTOS MEDIDOS EN Z

                                                        //COMIENZO EL REGISTRO DE PUNTOS MEDIDOS EN D
                                                        try
                                                        {
                                                            medidoD = new SqlDataAdapter();
                                                            SqlCommand agrega_medidoD = new SqlCommand("INSERT INTO puntosMedidosD (codDmo,codMedicion,codMediD,medidoD,nominalD,desvD,upTolD,loTolD,critOotD) VALUES (@codDmo,@codMedicion,@codMediD,@medidoD,@nominalD,@desvD,@upTolD,@loTolD,@critOotD)", Conexion);
                                                            medidoD.InsertCommand = agrega_medidoD;
                                                            string decisionD = "";
                                                            string critOotD = "";
                                                            string codMedicionD = "";
                                                            string aux_medidoD = "";
                                                            string aux_nominalD = "";
                                                            string aux_desvD = "";
                                                            string aux_upTolD = "";
                                                            string aux_loTolD = "";
                                                            string aux_critOotD = "";
                                                            //CultureInfo culture = new CultureInfo("en-US"); >> YA SE DEFINIO ANTES
                                                            foreach (DataGridViewRow fila_medidoD in dgv_datos.Rows)
                                                            {
                                                                decisionD = Convert.ToString(fila_medidoD.Cells["Coordenada"].Value); //leo la celda correspondiente para saber si debo registrar en puntosMedidosX o no
                                                                if (decisionD == "D")
                                                                {

                                                                    medidoD.InsertCommand.Parameters.Clear();

                                                                    medidoD.InsertCommand.Parameters.Add(new SqlParameter("@codDmo", SqlDbType.VarChar));
                                                                    medidoD.InsertCommand.Parameters.Add(new SqlParameter("@codMedicion", SqlDbType.Int));
                                                                    medidoD.InsertCommand.Parameters.Add(new SqlParameter("@codMediD", SqlDbType.VarChar));
                                                                    medidoD.InsertCommand.Parameters.Add(new SqlParameter("@medidoD", SqlDbType.Decimal));
                                                                    medidoD.InsertCommand.Parameters.Add(new SqlParameter("@nominalD", SqlDbType.Decimal));
                                                                    medidoD.InsertCommand.Parameters.Add(new SqlParameter("@desvD", SqlDbType.Decimal));
                                                                    medidoD.InsertCommand.Parameters.Add(new SqlParameter("@upTolD", SqlDbType.Decimal));
                                                                    medidoD.InsertCommand.Parameters.Add(new SqlParameter("@loTolD", SqlDbType.Decimal));
                                                                    medidoD.InsertCommand.Parameters.Add(new SqlParameter("@critOotD", SqlDbType.Decimal));

                                                                    medidoD.InsertCommand.Parameters["@codDmo"].Value = txt_CodigoDmo.Text;

                                                                    //busco el codMedicion


                                                                    //SqlDataAdapter aux_codMedicionD = new SqlDataAdapter("SELECT codMedicion FROM detallesDocumentoDmo WHERE idPtoMed=@idPtoMed", Conexion);
                                                                    //SqlDataAdapter aux_codMedicionD = new SqlDataAdapter("SELECT d.codMedicion FROM detallesDocumentoDmo AS d WHERE d.idPtoMed=@idPtoMed AND d.codMedicion NOT IN (SELECT codMedicion FROM puntosMedidosD)", Conexion);
                                                                    SqlDataAdapter aux_codMedicionD = new SqlDataAdapter("SELECT d.codMedicion FROM detallesDocumentoDmo AS d WHERE d.idPtoMed=@idPtoMed AND d.codDmo=@codDmo AND d.codMedicion NOT IN (SELECT codMedicion FROM puntosMedidosD)  AND d.codMedicion NOT IN (SELECT codMedicion FROM puntosMedidosX)", Conexion);
                                                                    aux_codMedicionD.SelectCommand.Parameters.Clear();

                                                                    aux_codMedicionD.SelectCommand.Parameters.Add(new SqlParameter("@idPtoMed", SqlDbType.VarChar));
                                                                    aux_codMedicionD.SelectCommand.Parameters.Add(new SqlParameter("@codDmo", SqlDbType.VarChar));
                                                                    aux_codMedicionD.SelectCommand.Parameters["@idPtoMed"].Value = Convert.ToString(fila_medidoD.Cells["Punto"].Value);
                                                                    aux_codMedicionD.SelectCommand.Parameters["@codDmo"].Value = txt_CodigoDmo.Text;
                                                                    DataTable dt_codMedicionD = new DataTable();
                                                                    aux_codMedicionD.Fill(dt_codMedicionD);
                                                                    codMedicionD = "";
                                                                    if (dt_codMedicionD.Rows.Count == 0)
                                                                    {
                                                                        //MessageBox.Show("ERROR DURANTE EL REGISTRO DE DISTANCIAS MEDIDOS (D). NO SE ENCONTRO UN CODIGO DE MEDICION ASOCIADO.", "URGENTE!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                                                        //limpiar();
                                                                        //Conexion.Close();
                                                                    }
                                                                    else
                                                                    {
                                                                        codMedicionD = dt_codMedicionD.Rows[0][0].ToString();
                                                                        //termino de buscar el código de la Medicion
                                                                        medidoD.InsertCommand.Parameters["@codMedicion"].Value = Convert.ToInt32(codMedicionD);
                                                                        medidoD.InsertCommand.Parameters["@codMediD"].Value = Convert.ToString(fila_medidoD.Cells["Punto"].Value);
                                                                        aux_medidoD = Convert.ToString(fila_medidoD.Cells["dataGridViewTextBoxColumn2"].Value);
                                                                        medidoD.InsertCommand.Parameters["@medidoD"].Value = decimal.Parse(aux_medidoD, culture);
                                                                        aux_nominalD = Convert.ToString(fila_medidoD.Cells["Nominal"].Value);
                                                                        medidoD.InsertCommand.Parameters["@nominalD"].Value = decimal.Parse(aux_nominalD, culture);
                                                                        aux_desvD = Convert.ToString(fila_medidoD.Cells["Desviación"].Value);
                                                                        medidoD.InsertCommand.Parameters["@desvD"].Value = decimal.Parse(aux_desvD, culture);
                                                                        aux_upTolD = Convert.ToString(fila_medidoD.Cells["UpTol"].Value);
                                                                        medidoD.InsertCommand.Parameters["@upTolD"].Value = decimal.Parse(aux_upTolD, culture);
                                                                        aux_loTolD = Convert.ToString(fila_medidoD.Cells["LoTol"].Value);
                                                                        medidoD.InsertCommand.Parameters["@loTolD"].Value = decimal.Parse(aux_loTolD, culture);

                                                                        critOotD = Convert.ToString(fila_medidoD.Cells["CritOot"].Value);
                                                                        if (string.IsNullOrWhiteSpace(critOotD))
                                                                        {
                                                                            medidoD.InsertCommand.Parameters["@critOotD"].Value = DBNull.Value;
                                                                        }
                                                                        else
                                                                        {
                                                                            aux_critOotD = Convert.ToString(fila_medidoD.Cells["CritOot"].Value);
                                                                            medidoD.InsertCommand.Parameters["@critOotD"].Value = decimal.Parse(aux_critOotD, culture);
                                                                        }

                                                                        medidoD.InsertCommand.ExecuteNonQuery();
                                                                    }
                                                                    //fin de busqueda

                                                                }
                                                            }
                                                            mensaje += "- Registro de Distancias Medidas (D)." + "\n";
                                                            //FIN DEL REGISTRO DE PUNTOS MEDIDOS EN D

                                                        }
                                                        catch (Exception ex6)
                                                        {
                                                            MessageBox.Show("ERROR EX6: " + ex6.ToString());
                                                        }
                                                    }
                                                    catch (Exception ex5)
                                                    {
                                                        MessageBox.Show("ERROR EX5: " + ex5.ToString());
                                                    }
                                                }
                                                catch (Exception ex4)
                                                {
                                                    MessageBox.Show("ERROR EX4: " + ex4.ToString());
                                                }
                                            }
                                            catch (Exception ex3)
                                            {
                                                MessageBox.Show("ERROR EX3: " + ex3.ToString());
                                            }
                                        }
                                        catch (Exception ex2)
                                        {
                                            MessageBox.Show("ERROR EX2: " + ex2.ToString());
                                        }
                                        ////////////////////////////////////////////
                                        MessageBox.Show(mensaje);
                                        limpiar();
                                    }
                                    catch (Exception ex)
                                    {
                                        MessageBox.Show("ERROR EX: " + ex.ToString());
                                    }
                                    finally
                                    {
                                        Conexion.Close();
                                    }
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("El Archivo DMO ya se encuentra registrado", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpiar();
                Conexion.Close();
            }
        }

        private void limpiar()
        {
            txt_ApProg.Text = "";
            txt_Archivo.Text = "";
            txt_CodigoDmo.Text = "";
            txt_Disenio.Text = "";
            txt_Establecimiento.Text = "";
            txt_FechaActualiz.Text = "";
            txt_FechaDmo.Text = "";
            txt_Guia.Text = "";
            txt_HoraDmo.Text = "";
            txt_Lote.Text = "";
            txt_Maquina.Text = "";
            txt_Modelo.Text = "";
            txt_Programa.Text = "";
            txt_Programador.Text = "";
            txt_Regla.Text = "";
            txt_Revision.Text = "";
            txt_SistRef.Text = "";
            txt_Subgrupo.Text = "";
            txt_Version.Text = "";
            //limpio el dgv_DetDmo
            dgv_DetDmo.Rows.Clear();
            dgv_DetDmo.Refresh();
            dgv_Dmo.Rows.Clear();
            dgv_Dmo.Refresh();
            dgv_datos.Rows.Clear();
            dgv_datos.Refresh();
            dgv_nombresPuntos.Rows.Clear();
            dgv_nombresPuntos.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void Btn_conocer_Click(object sender, EventArgs e)
        {
            VisorDmo f = new VisorDmo();
            f.Show();
        }
    }
}
