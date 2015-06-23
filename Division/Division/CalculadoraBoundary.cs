using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Division
{
    class CalculadoraBoundary
    {
        public double ObtenerDividendo()
        {
            Console.WriteLine("Introduzca el dividendo: ");
            string dividendo = Console.ReadLine();
            double respuesta = double.Parse(dividendo);
            return respuesta;
        }

        public double ObtenerDivisor()
        {
            Console.WriteLine("Introduzca el divisor: ");
            string divisor = Console.ReadLine();
            double respuesta = double.Parse(divisor);
            return respuesta;
        }

        internal void MostrarResultado(string resultado)
        {
            Console.WriteLine("El resutado es: "+ resultado);
            Console.ReadLine();
        }
    }
}
