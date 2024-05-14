using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listasPracticaParcial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio 1
            //Console.WriteLine("Promedio de numeros enteros en un arreglo.");
            //Console.WriteLine("Ingrese la cantidad de elementos que tendra su arreglo: ");

            //int cantidadElementos;

            //if (!Int32.TryParse(Console.ReadLine(), out cantidadElementos) || cantidadElementos <= 0)
            //{
            //    Console.WriteLine("Numero no valido. Debe ingresar un numero entero positivo.");
            //}
            //else
            //{
            //    int[] numeros = new int[cantidadElementos];

            //    Console.WriteLine("Ingrese los numeros que almacenara su arreglo: ");
            //    for (int i = 0; i < numeros.Length; i++)
            //    {
            //        if (!Int32.TryParse(Console.ReadLine(), out numeros[i]))
            //        {
            //            Console.WriteLine("Numero no valido. Debe ingresar un numero entero.");
            //            i--;
            //        }
            //    }

            //    int sumaElementos = 0;

            //    foreach (int numero in numeros)
            //    {
            //        sumaElementos += numero;
            //    }

            //    double promedio = (double)sumaElementos / (double)cantidadElementos;

            //    Console.WriteLine($"El promedio de los elementos de su arreglo es: {promedio}");
            //}

            //Ejercicio 2
            //Console.WriteLine("Conteo de números negativos en una lista.");
            //Console.WriteLine("Ingrese numeros enteros para agregar a la lista (finalizara la carga al ingresar 0): ");

            //List<int> numeros = new List<int>();
            //int numeroEntrada = 1;
            //int valor = 1;

            //while (numeroEntrada != 0)
            //{
            //    Console.Write($"Numero {valor}: ");
            //    if (!Int32.TryParse(Console.ReadLine(), out numeroEntrada))
            //    {
            //        Console.WriteLine("Numero no valido. Ingrese otro numero entero.");
            //        numeroEntrada = 1;
            //    }
            //    else if (numeroEntrada != 0)
            //    {
            //        numeros.Add(numeroEntrada);
            //        valor++;
            //    }
            //}

            //int cantidadNegativos = 0;

            //foreach (int numero in numeros)
            //{
            //    if (numero < 0)
            //    {
            //        cantidadNegativos++;
            //    }
            //}

            //Console.WriteLine($"Se ingresaron {cantidadNegativos} numeros negativos a la lista.");
        }
    }
}