using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using estudiando_xd;
using MiBiblioteca;

namespace estudiando_xd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ejercicios n1 = new Ejercicios();
            // n1.sumaNumeros();
            //n1.unocien();
            //n1.indicarN()
           //Console.WriteLine("Ingrese cuantos nombres desea poner: ");
           //int cantidad = int.Parse(Console.ReadLine());
            // n1.insertarMascotas(cantidad);
            //n1.mostrarMascotas();
            //n1.buscarMascota();
            //n1.matrices();

            Console.WriteLine("Ingrese el numero de filas: ");
            int f = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el numero de columnas: ");
            int c = int.Parse(Console.ReadLine());
            n1.sumaMatrices(f,c);
            Console.ReadKey();
        }
    }
}
