using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {



        }

        private static void CalculoDeList()
        {
            List<int> entrada = new List<int>();
            entrada.Add(4);
            entrada.Add(6);
            entrada.Add(20);
            entrada.Add(1);
            entrada.Add(11);
            entrada.Add(600);

            Calculadora laCalculadora = new Calculadora();

            List<int> salida = laCalculadora.CalcularFibonacciDeLista(entrada);

            foreach (int i in salida)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}