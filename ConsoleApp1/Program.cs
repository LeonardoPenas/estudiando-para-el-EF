using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MiBiblioteca;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
          Clase_EP1 clase = new Clase_EP1();
         //clase.valores();
         //clase.sumaDeColumnas(7);
            clase.articulo1();
            clase.articulo2();
            clase.articulo3();
            clase.articulo4();
            clase.articulo5();
            clase.articulo6();
            clase.articulo7();
            clase.sumaDeFilas();
            clase.mostrarDatos();
            clase.sumaDeColumnas();
            clase.mostrarVentasMinMax();
            clase.CalcularTotalesSemanales();

            //clase.sumaDeFilas();
            

            Console.ReadKey();

        }


        

    }
}

