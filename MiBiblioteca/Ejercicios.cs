using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace MiBiblioteca
{
    public class Ejercicios
    {
        private static IEnumerable<int> numeros;

        //ARREGLO UNIDIMENSIONAL
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

        /* Ejercicio 7

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
        */


        //ARREGLO BURBUJA O DE ORDENAMIENTO

        /* // ARREGLO BURBUJA EJEMPLO 
        public void burbuja()
        {
            int[] numeros = new int[] { 14, 5, 27, 19, 8, 3 };
            Console.WriteLine("INICIO");

            int extIteraciones = 0;
            int intIteraciones = 0;
           // bool flag = true;  //Para evitar iteraciones de más si el arreglo ya está ordenado


            for (int i = 0; i < numeros.Length ; i++) // Se agrega ---> && flag

            {
            // flag = false; //Para que  que continue el algoritmo si exista una comparacion    


                extIteraciones++;
                for (int j = 0; j < numeros.Length-i-1; j++)// si se le agrega -1 las iteraciones internas se reducen mucho
                {
                    intIteraciones++;  
                    if (numeros[j] > numeros[j+1])
                    {
                        //flag = true; //Si se hace un intercambio, significa que el arreglo no está ordenado
                        int aux = numeros[j];
                        numeros[j] = numeros[j + 1];
                        numeros[j + 1] = aux;
                    }
                }
               /* foreach (int numero in numeros)
                {
                    Console.Write(numero + " ");
                }
                Console.WriteLine("\n");
                // con esto se ve como el arreglo funciona
               





            }
            Console.WriteLine("numero de iteraciones externas: " + extIteraciones);
            Console.WriteLine("numero de iteraciones internas: " + intIteraciones);
            Console.WriteLine("Despues de ordenar: ");
            foreach (int numero in numeros)
            {
                Console.Write(numero + " ");
            }
            Console.WriteLine("\n");

            Console.ReadKey();
        */



        /* DESARROLLO CASO PRACTICO SEMANA 12 ARREGLO BURBUJA


        string[] listadeMascotas;
        public void insertarMascotas(int cantidad)
        {
            listadeMascotas = new string[cantidad];
            for (int i = 0; i < cantidad; i++)
            {
                Console.WriteLine("Ingrese el nombre de la mascota " + (i + 1) + ": ");
                listadeMascotas[i] = Console.ReadLine();
            }

        }
        public void mostrarMascotas()
        {
            Console.WriteLine("Lista de mascotas: ");
            for (int i = 0; i < listadeMascotas.Length; i++)
            {
                Console.WriteLine("Mascota " + (i + 1) + ": " + listadeMascotas[i]);
            }


        }
        public void buscarMascota()
        {
            Console.WriteLine("Ingrese el nombre de la mascota que desea buscar : ");
            string nombremascota = Console.ReadLine();
            for (int i = 0; i < listadeMascotas.Length; i++)
            {
                if (listadeMascotas[i] == nombremascota)
                {
                    Console.WriteLine("MASCOTA ENCONTRADA: " + listadeMascotas[i]);
                    return;




                }

            }
            Console.WriteLine("La mascota no se encuentra en la lista");

        }
        public void eliminarMascota()
        {
            Console.WriteLine("INGRESE EL NOMBRE DE LA MASCOTA A ELIMINAR: ");
            String nombreMascota = Console.ReadLine();
            for (int i = 0; i < listadeMascotas.Length; i++)
            {
                if (listadeMascotas[i] == nombreMascota)
                {
                    for (int j = 0; j < listadeMascotas.Length - 1; j++)
                    {
                        listadeMascotas[j] = listadeMascotas[j + 1];
                    }
                }
                Array.Resize(ref listadeMascotas, listadeMascotas.Length - 1);
                Console.WriteLine("Mascota eliminada correctamente.");
                return;
            }
            Console.WriteLine("MASCOTA NO ENCONTRADA PARA ELIMINAR.");
        }
        public void OrdenarMascota()
        {
            for (int i = 0; i < listadeMascotas.Length - 1; i++)
            {
                for (int j = 0; j < listadeMascotas.Length; j++)
                {
                    if (listadeMascotas[i].CompareTo(listadeMascotas[i + 1]) > 0)
                    {
                        string aux = listadeMascotas[i];
                        listadeMascotas[i] = listadeMascotas[i + 1];
                        listadeMascotas[i + 1] = aux;
                    }
                }
            }
        }
        */



        //ARREGLOS MATRICES

        /* ENSEÑAMOS EL ARRAY
         int[] num = new int[10];
         for (int i = 0; i < num.Length; i++)
         {
             num[i] = i + 1; //Con esto dependiendo al numero que sumes se ponen los numeros
             Console.WriteLine(num[i]);
         }
         */

        /*SUMA DEL ARRAY 
         int[] numeros = new int[] { 2, 4, 5, 15, 16 };
         int suma= 0;
         for (int i = 0; i < numeros.Length; i++)
         { 
         suma += numeros[i];
         }
         Console.WriteLine("La suma de los numeros es: " + suma);
         */

        //USO DE MATRICES

        /*
        int[ , ] numeros = new int[10, 8];
        Random r1 = new Random();
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 8; j++)
            {
                numeros[i, j] = r1.Next(0, 9);
                Console.Write(numeros[i, j] + " ");

            }
            Console.WriteLine();
        }
        */

        /*SUMA DE CADA COLUMNA
        int[] resultado = new int[10];
        for (int a = 0; a < 8; a++)
        {
            resultado[a] = 0; // Inicializamos el resultado en 0 para cada columna
            for (int b = 0; b < 10; b++)
            {
                resultado[a] += numeros[b, a];
            }
            Console.WriteLine("La suma de la columna " + resultado[a] + " ");
        }
        */


        //SEMANA 15 ARREGLOS PRACTICA SEMANAL

        //Ejercicio 1 : Matrices

        int[ , ] m3 = new int[10,10];
        // [10  ,   10]
        // [filas, columnas]
        // [0    ,    1]
        public void GfilasColumnas()
        {
            for (int i = 0; i < 10; i++)
            {
                for ( int j = 0; j < 10; j++)
                {
                    if (i==j)
                    {
                        m3[i, j] = 1;
                    }
                    else
                    {
                        m3[i, j] = 0;
                    }
                }
            }
            
             //[0,0]
             for (int i = 0; i < m3.GetLength(0); i++)
            {
                for (int j = 0; j < m3.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        m3[i, j] = 1;
                    }
                    else
                    {
                        m3[i, j] = 0;
                    }
                }

            }
        }
          public void MostrarFc()
        {
            for (int i = 0; i < m3.GetLength(0); i++)
            {
                for (int j = 0; j < m3.GetLength(1); j++)
                {
                    Console.Write(m3[i, j] + " ");
                }
                Console.WriteLine();
            }
        }


        //Ejercicio 3 suma

        public void sumaMatrices(int f , int c )
        { 
         float [,] m1 = new float[f, c];
           

            for (int i = 0; i < f ; i++)
            { 
                for (int j = 0; j < c ; j++)
                {
                    
                    Console.Write("Ingrese el valor  de la posicion ");
                    m1[i, j] = float.Parse(Console.ReadLine());
                }
                for (int i = 0; i < f; i++)
                {
                   float sumaFila = 0;
                   for (int j = 0; j < c; j++)
                    {
                        sumaFila += m1[i, j];
                    }
                    Console.WriteLine("La suma de la fila {i} es: " + sumaFila );
                }
            }
        } 


        }

    }
        








    
}









































