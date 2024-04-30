using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicosArreglos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio 1.
            /*Console.WriteLine("Ingrese 5 numeros enteros: ");
            int[] numeros = new int[5];
            int numero;
            for (int i = 0; i < numeros.Length; i++)
            {
                if(!Int32.TryParse(Console.ReadLine(), out numero))
                {
                    Console.WriteLine("Numero no valido. Ingrese otro.");
                    i--;
                }
                else
                {
                    numeros[i] = numero;
                }
            }
            Console.WriteLine("El arreglo quedo de la siguiente manera: ");
            foreach (int i in numeros)
            {
                Console.WriteLine(i);
            }*/

            //Ejercicio 2.
            /*Console.WriteLine("Ingrese 5 notas: ");
            double[] notas = new double[5];
            double nota;
            double suma = 0;
            double promedio = 0;
            int contador = 0;
            for (int i = 0; i < notas.Length; i++)
            {
                if(!double.TryParse(Console.ReadLine()?.Replace(".", ","), out nota))
                {
                    Console.WriteLine("Nota no valida. Ingrese otra.");
                    i--;
                }
                else
                {
                    notas[i] = nota;
                    suma += nota;
                    contador++;
                }
            }
            promedio = suma / contador;

            Console.WriteLine("Las notas ingresadas fueron: ");
            foreach (int i in notas)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine($"El promedio de las notas es: {promedio}");*/
        }
    }
}
