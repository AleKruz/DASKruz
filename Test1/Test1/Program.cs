using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Hello World");
            System.Console.WriteLine("Goodbye");
            //System.Console.ReadKey();
            int i = 1;
            while (true){
                Console.WriteLine(Fibonacci.Calcular(i));
                i++;
            }
            
            //    (ulong i = 0; i < 10000; )
            //{ 
            System.Console.ReadKey();
            }
            

            //Fibonacci f = new Fibonacci();
            //System.Console.WriteLine(f.Calcular(1));
            //System.Console.WriteLine(f.Calcular(2));
            //System.Console.WriteLine(f.Calcular(3));
            //System.Console.WriteLine(f.Calcular(4));
            //System.Console.WriteLine(f.Calcular(5));
            //System.Console.WriteLine(f.Calcular(6));
            //System.Console.WriteLine(f.Calcular(7));
            //System.Console.WriteLine(f.Calcular(8));
            //System.Console.WriteLine(f.Calcular(9));
            //System.Console.WriteLine(f.Calcular(10));
            //Console.ReadKey();
        }
    }
