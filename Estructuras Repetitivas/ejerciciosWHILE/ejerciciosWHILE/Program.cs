using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejerciciosWHILE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio 1
            /*Console.WriteLine("Ingrese valores positivos para sumarlos (el programa finaliza al ingresar 0): ");
            float valor = 1;
            float sumaValores = 0;
            while (valor != 0)
            {
                if(!float.TryParse(Console.ReadLine(), out valor))
                {
                    Console.WriteLine("El numero ingresado no es valido. Ingrese otro numero.");
                    valor = 1;
                }
                else
                {
                    sumaValores += valor;
                }
            }
            Console.WriteLine($"La suma de los valores ingresados es: {sumaValores}");*/

            //Ejercicio 2.
            /*Console.WriteLine("Ingrese valores positivos para calcular el promedio (el programa finaliza al ingresar 0): ");
            float valor = 1;
            float sumaValores = 0;
            int cantidadValores = 0;
            float promedio = 0;
            while (valor != 0)
            {
                if(!float.TryParse(Console.ReadLine(), out valor))
                {
                    Console.WriteLine("El numero ingresado no es valido. Ingrese otro numero.");
                    valor = 1;
                }
                else
                {
                    sumaValores += valor;
                    cantidadValores += 1;
                }
            }
            promedio = sumaValores / (cantidadValores - 1);
            Console.WriteLine($"El promedio de los valores ingresados es: {promedio}");*/

            //Ejercicio 3.
            /*Console.WriteLine("Ingrese un nombre (si no ingresa caracteres el programa terminara):");
            string nombre = " ";
            int cantidadNombres = -1;

            while (!string.IsNullOrEmpty(nombre))
            {
                nombre = Console.ReadLine();
                cantidadNombres++;
            }
            Console.WriteLine($"La cantidad de nombres ingresados es: {cantidadNombres}");*/

            //Ejercicio 4.
        }
    }
}
