using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejerciciosFOR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio 1.
            /*Console.WriteLine("Ingresar 5 valores enteros:");
            int numero;
            int suma = 0;
            for (int i = 1; i <= 5; i++)
            {
                Console.Write($"Valor {i}: ");
                if (!int.TryParse(Console.ReadLine(), out numero))
                {
                    Console.WriteLine("El numero ingresado no es valido.");
                    i--;
                }
                else
                {
                    suma += numero;
                }
            }
            
            Console.WriteLine($"La suma de los 5 numeros es: {suma}");*/

            //Ejercicio 2.
            /*Console.WriteLine("Ingrese las 8 notas que obtuvo el alumno para sacar su promedio: ");
            float nota = 0;
            float suma = 0;
            float promedio = 0;

            for (int i = 1; i <= 8; i++)
            {
                Console.Write($"Nota {i}: ");
                if (!float.TryParse(Console.ReadLine()?.Replace(".", ","), out nota))
                {
                    Console.WriteLine("El numero ingresado no es valido.");
                    i--;
                }
                else
                {
                    suma += nota;
                    promedio = suma / i;
                }
            }
            Console.WriteLine($"El promedio del alumno es: {promedio}");*/

            //Ejercicio 3.
            /*Console.WriteLine("Ingrese los datos de 5 compras.");
            float costoUnitario;
            int cantidadComprada;
            float resultado = 0;
            float total = 0;

            for (int i = 1; i <= 5; i++)
            {
                Console.Write($"Compra {i}. Costo unitario: ");
                if (!float.TryParse(Console.ReadLine()?.Replace(".", ","), out costoUnitario))
                {
                    Console.WriteLine("El numero ingresado no es valido.");
                    i--;
                }
                else
                {
                    Console.Write($"Compra {i}. Cantidad comprada: ");
                    if (!int.TryParse(Console.ReadLine(), out cantidadComprada))
                    {
                        Console.WriteLine("El numero ingresado no es valido.");
                        i--;
                    }
                    else
                    {
                        resultado = costoUnitario * cantidadComprada;
                        total += resultado;
                    }
                }
            }
            Console.WriteLine($"El total de las 5 compras es: {total}");*/

            //Ejercicio 4.
            /*float numero, mayor = 0;

            Console.WriteLine("Ingrese 8 numeros para determinar cual es el mayor");

            for (int i = 1; i <= 8; i++)
            {
                Console.Write($"Numero {i}: ");
                if (!float.TryParse(Console.ReadLine()?.Replace(".", ","), out numero))
                {
                    Console.WriteLine("El numero ingresado no es valido.");
                    i--;
                }
                else
                {
                    if (i == 1)
                    {
                        mayor = numero;
                    }
                    else if (numero > mayor)
                    {
                        mayor = numero;
                    }
                }
            }
            Console.WriteLine($"El mayor numero ingresado es: {mayor}");*/

            //Ejercicio 5.
            /*Console.WriteLine("Ingrese los datos de 5 compras.");
            string nombreCliente;
            string nombreClienteMax = "";
            float totalGastado;
            float gastoMaximo = 0;

            for (int i = 1; i <= 5; i++)
            {
                Console.Write($"Entrada {i}. Nombre del cliente: ");
                nombreCliente = Console.ReadLine();
                Console.Write($"Compra {i}. Cantidad comprada: ");
                if (!float.TryParse(Console.ReadLine()?.Replace(".", ","), out totalGastado))
                {
                    Console.WriteLine("El numero ingresado no es valido.");
                    i--;
                }
                else
                {
                    if (i == 1)
                    {
                        gastoMaximo = totalGastado;
                        nombreClienteMax = nombreCliente;
                    }
                    else if (totalGastado > gastoMaximo)
                    {
                        gastoMaximo = totalGastado;
                        nombreClienteMax = nombreCliente;
                    }
                }
            }
            Console.WriteLine($"El cliente {nombreClienteMax} fue quien mas gasto, con un total de: {gastoMaximo}");*/

            //Ejercicio 6.
            /*Console.Write("Ingrese un numero natural para calcular su factorial: ");
            int n;
            int resultado = 1;

            if(!Int32.TryParse(Console.ReadLine(), out n) || n <= 0)
            {
                Console.WriteLine("Error, numero invalido.");
            }
            else
            {
                for(int i = 1; i <= n; i++)
                {
                    resultado *= i;
                }
                Console.WriteLine($"El factorial de {n} es: {resultado}");
            }*/
        }
    }
}
