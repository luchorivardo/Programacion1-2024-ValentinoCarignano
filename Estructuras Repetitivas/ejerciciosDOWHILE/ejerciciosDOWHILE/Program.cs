using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejerciciosDOWHILE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio 1.
            /*Console.WriteLine("Ingrese el usuario y clave: ");
            string user = "";
            string password = "667788";
            do
            {
                if (password != "667788")
                {
                    Console.WriteLine("Clave incorrecta. Vuelva a intentar.");
                }

                Console.Write("Usuario: ");
                user = Console.ReadLine();

                Console.Write("Clave: ");
                password = Console.ReadLine();

            } while (password != "667788");

            Console.WriteLine("Inicio de sesion realizado con exito.");*/

            //Ejercicio 2.
            /*Console.WriteLine("Ingrese numeros negativos. El programa terminara cuando ingrese un positivo.");
            double numero;

            do
            {
                if(!double.TryParse(Console.ReadLine()?.Replace(".", ","), out numero))
                {
                    Console.WriteLine("Numero no valido. Ingrese otro.");
                    numero = -1;
                }
            } while (numero < 0);*/

            //Ejercicio 3.
            /*Console.WriteLine("Ingrese numeros negativos para mostrar su promedio. El programa terminara cuando ingrese un positivo.");
            double numero;
            int cantidad = 0;
            double total = 0;

            do
            {
                if (!double.TryParse(Console.ReadLine()?.Replace(".", ","), out numero))
                {
                    Console.WriteLine("Numero no valido. Ingrese otro.");
                    numero = -1;
                }
                else
                {
                    cantidad += 1;
                    total += numero;
                }
            } while (numero < 0);
            double promedio = total / (cantidad-1);
            Console.WriteLine($"El promedio de los numero ingresados es: {promedio}");*/

            //Ejercicio 4.
            /*Console.WriteLine("Ingrese numeros. El programa terminara cuando ingrese un numero mayor a 3 cifras.");
            double numero;
            double suma = 0;

            do
            {
                if(!double.TryParse(Console.ReadLine()?.Replace(".", ","), out numero))
                {
                    Console.WriteLine("Numero no valido. Ingrese otro.");
                    numero = 0;
                }
                else
                {
                    suma += numero;
                }
            } while (numero < 1000 && numero > -1000);

            Console.WriteLine($"El resultado de la suma de los numeros es: {suma - numero}");*/

            //Ejercicio 5.
            /*Console.WriteLine("Ingrese numeros para calcular su promedio. El programa terminara cuando ingrese un numero mayor a 3 cifras.");
            double numero;
            int cantidad = 0;
            double suma = 0;

            do
            {
                if(!double.TryParse(Console.ReadLine()?.Replace(".", ","), out numero))
                {
                    Console.WriteLine("Numero no valido. Ingrese otro.");
                    numero = 0;
                }
                else
                {
                    suma += numero;
                    cantidad++;
                }
            } while (numero < 1000 && numero > -1000);

            double promedio = (suma - numero) / (cantidad - 1);
            Console.WriteLine($"El promedio de los numeros ingresados es: {promedio}");*/
        }
    }
}
