using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimerasHU_GES
{
    class ValidarAutoincrementable
    {
        public static void Autoincrementable(KeyPressEventArgs A)
        {
                A.Handled = true;
                MessageBox.Show("Este campo es autoincrementable, no debe ingresar ningun dato. " +
                    "Si desea Consultar, Eliminar o Modificar una seccion, seleccione desde la grilla, " +
                    "la fila que desea de la columna codSeccion. Si en la grilla no aparecen los datos, pulse 'Ver todas las secciones'.", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);  
        }
    }
}
