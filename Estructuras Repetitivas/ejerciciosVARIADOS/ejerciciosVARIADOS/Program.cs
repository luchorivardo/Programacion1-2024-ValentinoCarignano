using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejerciciosVARIADOS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio 1.
            Console.WriteLine("Carga de productos. Finaliza al ingresar codigo 0.");
            int codigo = 1;
            int contador = 0;
            int cantidad = 0;
            int cantidadVentas = 1;
            int cantidadFinal = 0;
            int mayorCantidad = int.MinValue;
            int mayorCodigo = 0;
            double precio = 0;

            while(codigo != 0 && contador < 10)
            {
                Console.Write("Ingrese codigo del producto: ");
                if(!Int32.TryParse(Console.ReadLine(), out codigo) || codigo > 10 || codigo < 0)
                {
                    Console.WriteLine("Numero invalido. Carga cancelada, ingrese otro codigo.");
                }
                else
                {
                    Console.Write($"Ingrese el precio del producto con codigo {codigo}: ");
                    if(!double.TryParse(Console.ReadLine(), out precio) || precio <= 0)
                    {
                        Console.WriteLine("Numero invalido. Carga cancelada, ingrese otro producto.");
                    }
                    else
                    {
                        Console.Write($"Ingrese la cantidad del producto con codigo {codigo}: ");
                        if (!Int32.TryParse(Console.ReadLine(), out cantidad) || cantidad < 0)
                        {
                            Console.WriteLine("Numero invalido. Carga cancelada, ingrese otro producto.");
                        }
                        else
                        {
                            if(mayorCantidad < cantidad)
                            {
                                mayorCantidad = cantidad;
                                mayorCodigo = codigo;
                            }
                            contador++;

                            while(cantidadVentas != 0)
                            {
                                Console.Write($"Ingrese la ventas que tuvo el producto con codigo {codigo}:");
                                if (!Int32.TryParse(Console.ReadLine(), out cantidadVentas) || cantidadVentas < 0)
                                {
                                    Console.WriteLine("Numero invalido. Carga cancelada, ingrese otro producto.");
                                    cantidadVentas = 1;
                                }
                                else
                                {
                                    cantidadFinal += cantidad - cantidadVentas;
                                    Console.WriteLine(cantidadFinal);
                                    if (cantidadFinal <= 0)
                                    {
                                        Console.WriteLine($"El producto con codigo {codigo}, no tiene stock o esta en numeros negativos.");
                                    }
                                }
                            }
                        }
                    }
                }
            }
            Console.Write($"El producto con codigo {mayorCodigo}, es el que mayor cantidad tenia a la hora de cargar los productos ({mayorCantidad}).");
        }
    }
}
