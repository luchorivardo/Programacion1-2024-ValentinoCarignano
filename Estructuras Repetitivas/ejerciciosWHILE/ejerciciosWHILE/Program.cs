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
                if(!float.TryParse(Console.ReadLine()?.Replace(".", ","), out valor) || valor < 0)
                {
                    Console.WriteLine(valor);
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
                if(!float.TryParse(Console.ReadLine(), out valor)?.Replace(".", ",") || valor < 0)
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
            /*Console.WriteLine("Ingrese los datos requeridos para calcular el total de una factura: ");
            Console.WriteLine("(Cuando el costo unitario ingresado sea 0 el programa finalizara)");
            double costoUnitario = 1;
            int cantidadComprada = 0;
            double totalAdeudado = 0;

            while (costoUnitario != 0)
            {
                Console.Write("Costo unitario: ");
                if (!double.TryParse(Console.ReadLine()?.Replace(".",","), out costoUnitario) || costoUnitario < 0)
                {
                    Console.WriteLine("Error, numero no valido. Ingrese otro.");
                    costoUnitario = 1;
                }
                else
                {
                    Console.Write("Cantidad comprada: ");
                    if (!Int32.TryParse(Console.ReadLine(), out cantidadComprada) || cantidadComprada < 0)
                    {
                        Console.WriteLine("Error, numero no valido. Ingrese otro.");
                        costoUnitario = 1;
                    }
                    else
                    {
                        totalAdeudado += costoUnitario * cantidadComprada;
                    }
                }
            }
            Console.WriteLine($"El total adeudado es de: ${totalAdeudado}");*/

            //Ejercicio 5.
            /*Console.WriteLine("Ingrese los datos requeridos para calcular el consumo total del cliente: ");
            double costoUnitario = 0;
            int cantidadProductos = 0;
            double totalAdeudado = 0;
            int i = 1;

            Console.Write("Cantidad comprada: ");
            if (!Int32.TryParse(Console.ReadLine(), out cantidadProductos) || cantidadProductos <= 0)
            {
                Console.WriteLine("Error, numero no valido. Ingrese otro.");
            }
            else
            {
                while (i <= cantidadProductos)
                {
                    Console.Write($"Precio producto {i}: ");
                    if (!double.TryParse(Console.ReadLine()?.Replace(".", ","), out costoUnitario) || costoUnitario < 0)
                    {
                        Console.WriteLine("Error, numero no valido. Ingrese otro.");
                    }
                    else
                    {
                        totalAdeudado += costoUnitario;
                        i++;
                    }
                }
            }
            Console.WriteLine($"El total adeudado por el cliente es de: ${totalAdeudado}");*/
        }
    }
}
