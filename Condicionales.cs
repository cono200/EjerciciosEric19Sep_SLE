using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sadadsdadd121
{
    internal class Condicionales
    {
        public string ParImpar(int numero)
        {
            if (numero > 0)
            {
                return "El numero es positivo";
            }
            else if (numero > 0)
            {
                return "El numero es negativo";
            }
            return "Es igual a cero";

        }


        public int MayorMenor(int numero1, int numero2, int numero3)
        {
            if (numero1 > numero2 && numero1 > numero3)
            {
                Console.WriteLine(numero1);
            }
            else if (numero2 > numero1 && numero2 > numero3)
            {
                return numero2;
            }
            else if (numero3 > numero1 && numero3 > numero1)
            {
                return numero3;
            }

            return numero1;
        }


        public int Calificaciones(int numero)
        {
            if (numero >= 90)
            {
                Console.WriteLine("A");
            }
            else if (numero < 90 && numero >= 80)
            {
                Console.WriteLine("B");
            }
            else if (numero < 80 && numero >= 70)
            {
                Console.WriteLine("C");
            }
            else if (numero < 70 && numero >= 60)
            {
                Console.WriteLine("D");
            }
            else
            {
                Console.WriteLine("E");
            }
            return numero;
        }


        public int NumAleatorio(int numero)
        {

        }




    }

}

