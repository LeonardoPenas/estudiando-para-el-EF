using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace MiBiblioteca
{
    public class Ejercicios
    {
        /*Ejercicio 4
         public void datos()
         {
             Console.WriteLine("Ingrese el numero de nombres y edades que desea: ");
             int cantidad= int.Parse(Console.ReadLine());

             string[] nombres = new string[cantidad];
             int[] edades = new int[cantidad];

             for (int i = 0; i < nombres.Length; i++)
             {
                 Console.WriteLine("Ingrese los nombres: ");
                 nombres[i] = Console.ReadLine();
                 Console.WriteLine("Ingrese las edades: ");
                 edades[i] = int.Parse(Console.ReadLine());


             }
             for (int i = 0; i < cantidad; i++)
             {
                 Console.WriteLine("Nombre: " + nombres[i] + " Edad: " + edades[i]);
             }
             Console.ReadKey();
        */

        /*Ejercicio 5

        public void sumaNumeros()
        {
            Console.WriteLine("Ingrese el tamaño del arreglo que desea: ");
            int cantidad = int.Parse(Console.ReadLine());
            int[] n1 = new int[cantidad];
            int[] n2 = new int[cantidad];
            int[] n3 = new int[cantidad];


            for (int i = 0; i < n1.Length; i++)
            {
                Console.WriteLine(" Ingrese el primer valor:  ");
                n1[i] = int.Parse(Console.ReadLine());
                Console.WriteLine(" Ingrese el segundo valor:  ");
                n2[i] = int.Parse(Console.ReadLine());
               
                n3[i] = n1[i] + n2[i];
            }
            for (int i = 0; i < cantidad; i++)
            {
                Console.WriteLine("El primer valor es: " + n1[i]);
                Console.WriteLine( "El segundo valor es: " + n2[i]);
                Console.WriteLine("La suma de los dos valores es: " + n3[i]);

            }
            Console.ReadKey();
       */

        /* Ejercicio 6

        public void unocien()
        {
            Console.WriteLine("Ingrese la cantidad del 1 al 100");
            int cantidad = int.Parse(Console.ReadLine());
            if (cantidad > 1 & cantidad <100)
            {
                Random r1 = new Random();
                int[] numeros = new int[cantidad];
               

                for (int i = 0; i < numeros.Length; i++)
                {
                    numeros[i] = r1.Next(1, 101);
                    Console.WriteLine("Los numeros generados aleatoriamente son: " + numeros[i]);
                }
                

            }
            else
            {
                Console.WriteLine("El numero ingresado no es valido, debe ser del 1 al 100");
            }
            Console.ReadKey()
        */

        // Ejercicio 7

        public void indicarN()
        { 
            Console.WriteLine("Ingrese la cantidad de numeros que desea generar: ");
            int x = int.Parse(Console.ReadLine());
            Random r1 = new Random();

            int[] numeros = new int[x];
            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = r1.Next(0,20);
                Console.WriteLine("Los numeros generados aleatoriamente son: " + numeros[i]);
            }
            for (int i = 0; i <= numeros[i]; i++)
            {
                Console.WriteLine("Ingrese el numero que desea buscar: ");
                int buscar = int.Parse(Console.ReadLine());
                if (buscar == numeros[i])
                {
                    Console.WriteLine("El número" + buscar + " se encuentra en la poscicion" + i);
                    
                    
                }
                else
                {
                    Console.WriteLine("El número " + buscar + " no se encuentra en el arreglo.");
                }



            }


        }












    }











}
    

