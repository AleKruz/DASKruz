using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Division
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculadoraBoundary cb = new CalculadoraBoundary();
            double dividendo = cb.ObtenerDividendo();
            double divisor = cb.ObtenerDivisor();


            CalculadoraController cc = new CalculadoraController();
            string resultado = cc.CoordineLaDivision(divisor, dividendo);

            cb.MostrarResultado(resultado);
        }
    }
}
