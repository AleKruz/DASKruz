using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Division
{
    class CalculadoraController
    {
        public string CoordineLaDivision(double dividendo, double divisor)
        {
            CalculadoraEntity ce = new CalculadoraEntity();

            double resultado = ce.Dividir(divisor,dividendo);

            string resultadoString = resultado.ToString();

            return resultadoString;
        }

    }
}
