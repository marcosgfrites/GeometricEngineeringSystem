using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimerasHU_GES
{
    class ValidarLetraNumero
    {
        public static void SoloLetras(KeyPressEventArgs K)
        {
            if (char.IsLetter(K.KeyChar))
                K.Handled = false;
            else if (char.IsSeparator(K.KeyChar))
                K.Handled = false;
            else if (char.IsControl(K.KeyChar))
                K.Handled = false;
            else
            {
                K.Handled = true;
                MessageBox.Show("Este campo solo acepta LETRAS.", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
                
        }
        public static void SoloNumeros(KeyPressEventArgs K)
        {
            if (char.IsDigit(K.KeyChar))
                K.Handled = false;
            else if (char.IsSeparator(K.KeyChar))
                K.Handled = false;
            else if (char.IsControl(K.KeyChar))
                K.Handled = false;
            else
            {
                K.Handled = true;
                MessageBox.Show("Este campo solo acepta NUMEROS ENTEROS.", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
                
        }

    }
}
