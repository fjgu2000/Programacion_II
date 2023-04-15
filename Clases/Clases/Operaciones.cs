using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    internal class Operadores
    {
        static public int Suma(int num1, int num2)
        {
            return (num1 + num2);
        }
        static public int Resta(int num1, int num2)
        {
            return (num1 - num2);
        }
        static public int Multi(int num1, int num2)
        {
            return (num1 * num2);
        }
        static public int Divis(int num1, int num2)
        {
            if (num2 == 0)
            {
                MessageBox.Show("No se puede dividir por 0");
                return 0;
            }
            else
            {
                return (num1 / num2);
            }
        }
    }
}
