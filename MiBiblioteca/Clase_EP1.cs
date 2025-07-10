using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MiBiblioteca
{
    public class Clase_EP1
    {
        int[] dias = new int[7] { 1, 2, 3, 4, 5, 6, 7 }; //representa los dias de la semana
        int[,] numeros = new int[7, 7];
        int[] resultado = new int[7];
        int[] articulos = new int[7];



        public void articulo1()
        {

            int col = 0;
            Random r = new Random();
            Console.WriteLine("Datos de Lunes");
            for (int i = 0; i < numeros.GetLength(0); i++)//muestra la cantidad de valores por dimension
            {
                int unidades = r.Next(0, 201);
                Console.WriteLine(dias[i] + ": " + unidades);
                numeros[i, col] = unidades; //accede a la primera columna
                Thread.Sleep(300);
            }


        }
        public void articulo2()
        {
            int col = 1;
            Random r = new Random();
            Console.WriteLine("Datos de Martes");
            for (int i = 0; i < numeros.GetLength(0); i++)//muestra la cantidad de valores por dimension
            {
                int unidades = r.Next(0, 201);
                Console.WriteLine(dias[i] + ": " + unidades);
                numeros[i, col] = unidades; //accede a la segunda columna
                Thread.Sleep(300);
            }
        }
        public void articulo3()
        {
            int col = 2;
            Random r = new Random();
            Console.WriteLine("Datos de Miercoles");
            for (int i = 0; i < numeros.GetLength(0); i++)//muestra la cantidad de valores por dimension
            {
                int unidades = r.Next(0, 201);
                Console.WriteLine(dias[i] + ": " + unidades);
                numeros[i, col] = unidades; //accede a la tercera columna
                Thread.Sleep(300);
            }
        }
        public void articulo4()
        {
            int col = 3;
            Random r = new Random();
            Console.WriteLine("Datos de Jueves");
            for (int i = 0; i < numeros.GetLength(0); i++)//muestra la cantidad de valores por dimension
            {
                int unidades = r.Next(0, 201);
                Console.WriteLine(dias[i] + ": " + unidades);
                numeros[i, col] = unidades; //accede a la cuarta columna
                Thread.Sleep(300);
            }
        }
        public void articulo5()
        {
            int col = 4;
            Random r = new Random();
            Console.WriteLine("Datos de Viernes");
            for (int i = 0; i < numeros.GetLength(0); i++)//muestra la cantidad de valores por dimension
            {
                int unidades = r.Next(0, 201);
                Console.WriteLine(dias[i] + ": " + unidades);
                numeros[i, col] = unidades; //accede a la quinta columna
                Thread.Sleep(300);
            }
        }
        public void articulo6()
        {
            int col = 5;
            Random r = new Random();
            Console.WriteLine("Datos de Sábado");
            for (int i = 0; i < numeros.GetLength(0); i++)//muestra la cantidad de valores por dimension
            {
                int unidades = r.Next(0, 201);
                Console.WriteLine(dias[i] + ": " + unidades);
                numeros[i, col] = unidades; //accede a la sexta columna
                Thread.Sleep(300);
            }
        }
        public void articulo7()
        {
            int col = 6;
            Random r = new Random();
            Console.WriteLine("Datos de Domingo");
            for (int i = 0; i < numeros.GetLength(0); i++)//muestra la cantidad de valores por dimension
            {
                int unidades = r.Next(0, 201);
                Console.WriteLine(dias[i] + ": " + unidades);
                numeros[i, col] = unidades; //accede a la septima columna
                Thread.Sleep(300);
            }
        }
        public void sumaDeColumnas()
        {

            for (int i = 0; i < 7; i++)

            {
                resultado[i] = 0; //inicializa el array resultado en 0
                for (int j = 0; j < 7; j++)
                {
                    resultado[i] += numeros[j, i]; //suma los valores de cada columna
                }

                Console.Write(+resultado[i] + "\t\t");
            }


        }
        public void sumaDeFilas()
        {
            for (int i = 0; i < 7; i++)

            {
                resultado[i] = 0; //inicializa el array resultado en 0
                for (int j = 0; j < 7; j++)
                {
                    resultado[i] += numeros[j, i]; //suma los valores de cada columna
                }

                Console.WriteLine(+resultado[i] + "\t\t");
            }
        }


        public void mostrarDatos()
        {
            Console.WriteLine("ARTICULOS \tLunes\t\tMartes\t\tMiercoles\tJueves\t\tViernes\t\tSábado\t\tDomingo\t\tTOTAL ");
            for (int i = 0; i < numeros.GetLength(0); i++)
            {
                Console.Write("Articulo " + dias[i] + " :     ");
                for (int j = 0; j < numeros.GetLength(1); j++)
                {
                    Console.Write(numeros[i, j] + "  \t\t");
                }
                ;
            }
            Console.Write("Ventas diarias   ");
        }

        int[] menorVenta = new int[7];
        int[] mayorVenta = new int[7];
        public void CalcularVentaasManMiv()
        {

            for (int i = 0; i < 7; i++)
            {
                menorVenta[i] = numeros[i, 0];
                mayorVenta[i] = numeros[i, 0];
                for (int j = 0; j < 7; j++)
                {
                    if (numeros[i, j] < menorVenta[i])
                    {
                        menorVenta[i] = numeros[i, j];
                    }
                    if (numeros[i, j] > mayorVenta[i])
                    {
                        mayorVenta[i] = numeros[i, j];
                    }
                }
            }
        }
        public void mostrarVentasMinMax()
        {
            CalcularVentaasManMiv();

            Console.WriteLine("\n--- Registro de ventas mínimas y máximas por artículo ---");

            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine("Artículo " + (i + 1) + ": venta mínima registrada: " + menorVenta[i] +
                                  " | venta máxima registrada: " + mayorVenta[i]);
            }
        }

        public void CalcularTotalesSemanales()
        {
            int totalSemanal = 0;
            for (int i = 0; i < 7; i++)
            {
                totalSemanal += resultado[i];
            }
            Console.WriteLine("\nTotal semanal de ventas: " + totalSemanal);
        }




    }







    
}
