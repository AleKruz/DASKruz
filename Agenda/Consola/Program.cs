using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            LogicaDeAplicacion.CarritoDeCompras cdc = new LogicaDeAplicacion.CarritoDeCompras();
            cdc.AgregarAlCarrito(new LogicaDeAplicacion.Producto(10199, "iPod Touch 64GB", "2015-06-06"));
            cdc.AgregarAlCarrito(new LogicaDeAplicacion.Producto(13100, "ChromeCast", "2015-03-06"));
            cdc.AgregarAlCarrito(new LogicaDeAplicacion.Producto(10299, "Laptop HB 256GB", "2015-07-06"));

            cdc.ImprimirLista();

            Console.ReadKey();
        }
    }
}
