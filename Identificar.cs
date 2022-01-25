using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numero_Mayor_de_5_2._0
{
    class Identificar
    {
        public string Identificar2(double n1, double n2, double n3, double n4, double n5, string Mayor = "")
        {
            
            //__________________________________________________________________
            if (n1 > n2 && n1 > n3 && n1 > n4 && n1 > n5)
            {
                Mayor = "El numero 1 es mayor con: " + n1;
            }
            else if (n2 > n1 && n2 > n3 && n2 > n4 && n2 > n5)
            {
                Mayor = "El numero 2 es mayor con: " +  n2;
            }
            else if (n3 > n1 && n3 > n2 && n3 > n4 && n3 > n5)
            {
                Mayor = "El numero 3 es mayor con: " + n3;
            }
            else if (n4 > n1 && n4 > n3 && n4 > n2 && n4 > n5)
            {
                Mayor = "El numero 4 es mayor con: " + n4;
            }
            else if (n5 > n1 && n5 > n3 && n5 > n4 && n5 > n2)
            {
                Mayor = "El numero 5 es mayor con: " + n5;
            }
            else if (n1 == n2 && n1 == n3 && n1 == n4 && n1 == n5)
            {
                Mayor = "Todos Los Numeros son iguales";
            }
            //____________________________________________________________________
            return Mayor;

        }
    }
}
