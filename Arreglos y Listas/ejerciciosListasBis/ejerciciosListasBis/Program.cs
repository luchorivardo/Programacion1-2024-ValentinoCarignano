using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejerciciosListasBis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio 1
            //Console.WriteLine("Ingrese palabras a una lista. Termina cuando se de enter sin colocar nada.");
            //List<string> palabras = new List<string>();

            //string palabraIngresada = "palabra";

            //while (!string.IsNullOrWhiteSpace(palabraIngresada))
            //{
            //    palabraIngresada = Console.ReadLine();
            //    palabras.Add(palabraIngresada);
            //}

            //palabras.Sort();

            //Console.WriteLine("Lista ordenada alfabeticamente: ");
            //foreach (string palabra in palabras)
            //{
            //    Console.WriteLine(palabra);
            //}

            //Ejercicio 2
            Console.WriteLine("Ingrese numeros enteros a una lista. Termina cuando se ingrese un cero.");

            List<int> enteros = new List<int>();
            int numero = 1;

            while(numero != 0)
            {
                if (!Int32.TryParse(Console.ReadLine(), out numero))
                {
                    Console.WriteLine("Numero no valido, ingrese otro.");
                    numero = 1;
                }
                else
                {
                    enteros.Add(numero);
                }
            }

            //enteros.Sort((a, b) => b.CompareTo(a));
            var numerosOrdenados = enteros.OrderBy(num => num).Reverse().ToList();
            //var numerosOrdenados = enteros.OrderByDescending(num => num);

            Console.WriteLine("Elementos pares de la lista ordenados de mayor a menor: ");
            foreach (int entero in numerosOrdenados)
            {
                if (entero % 2 == 0)
                {
                    Console.WriteLine(entero);
                }
            }
        }
    }
}
