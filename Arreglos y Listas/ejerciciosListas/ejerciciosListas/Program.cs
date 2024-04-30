using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejerciciosListas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio 3.
            /*Console.WriteLine("Agregue 5 numeros enteros a la lista: ");
            List<int> numeros = new List<int>();
            int numero;

            for (int i = 0; i < 5; i++)
            {
                if(!Int32.TryParse(Console.ReadLine(), out numero))
                {
                    Console.WriteLine("Numero no valido. Ingrese otro");
                    i--;
                }
                else
                {
                    numeros.Add(numero);
                }
            }
            Console.WriteLine("Los numero ingresaron fueron los siguientes:");
            foreach (int i in numeros)
            {
                Console.WriteLine(i);
            }*/

            //Ejercicio 4.
            Console.WriteLine("Ingrese 5 notas: ");
            List<double> notas = new List<double>();
            double nota;
            double suma = 0;
            double promedio = 0;
            int contador = 0;
            for (int i = 0; i < 5; i++)
            {
                if (!double.TryParse(Console.ReadLine()?.Replace(".", ","), out nota))
                {
                    Console.WriteLine("Nota no valida. Ingrese otra.");
                    i--;
                }
                else
                {
                    notas.Add(nota);
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

            Console.WriteLine($"El promedio de las notas es: {promedio}");
        }
    }
}
