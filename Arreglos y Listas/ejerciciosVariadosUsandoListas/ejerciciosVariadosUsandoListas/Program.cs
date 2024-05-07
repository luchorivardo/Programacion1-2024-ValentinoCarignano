using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ejerciciosVariadosUsandoListas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inicia la carga de productos. Finaliza al ingresar codigo 0.");
            Console.WriteLine();

            List<int> codigosIngresados = new List<int>();
            List<List<double>> productos = new List<List<double>>();

            int codigo = 1, cantidad = 0, contador = 0;
            int mayorCantidad = 0, mayorCodigo = 0;
            int totalVentas = 0;
            double precio = 0;

            while (codigo != 0 && contador < 10)
            {
                Console.Write("Ingrese codigo del producto: ");
                if (!Int32.TryParse(Console.ReadLine(), out codigo) || codigo > 10 || codigo < 0 || codigosIngresados.Contains(codigo))
                {
                    Console.WriteLine("Codigo invalido o ya ingresado. Carga cancelada, ingrese otro codigo.");
                    codigo = 1;
                }
                else if (codigo == 0)
                {
                    break;
                }
                else
                {
                    codigosIngresados.Add(codigo);

                    Console.Write($"Ingrese el precio: ");
                    if (!double.TryParse(Console.ReadLine(), out precio) || precio <= 0)
                    {
                        Console.WriteLine("Numero invalido. Carga cancelada, ingrese otro producto.");
                        codigosIngresados.Remove(codigo);
                    }
                    else
                    {
                        Console.Write($"Ingrese el stock: ");
                        if (!Int32.TryParse(Console.ReadLine(), out cantidad) || cantidad < 0)
                        {
                            Console.WriteLine("Numero invalido. Carga cancelada, ingrese otro producto.");
                            codigosIngresados.Remove(codigo);
                        }
                        else
                        {
                            if (mayorCantidad < cantidad)
                            {
                                mayorCantidad = cantidad;
                                mayorCodigo = codigo;
                            }
                        }
                    }
                    productos.Add(new List<double> { codigo, precio, cantidad, totalVentas });
                }
                Console.WriteLine();
            }
            Console.Write($"\nEl producto con codigo {mayorCodigo}, es el que mayor stock tenia a la hora de cargar los productos ({mayorCantidad}).");
            Console.WriteLine();

            //Ordena la lista
            productos.Sort((a, b) => a[0].CompareTo(b[0]));

            Console.WriteLine("\nInicia la carga de ventas de productos. Finaliza al ingresar 0.");
            Console.WriteLine();

            foreach (List<double> i in productos)
            {
                int cantidadVentas = 1;
                int numeroVenta = 1;
                while (cantidadVentas != 0)
                {
                    Console.WriteLine($"Producto codigo {i[0]}: ");

                    Console.Write($"Venta {numeroVenta}:");
                    if (!Int32.TryParse(Console.ReadLine(), out cantidadVentas) || cantidadVentas < 0)
                    {
                        Console.WriteLine("Numero invalido. Carga cancelada, ingrese otro producto.");
                        cantidadVentas = 1;
                    }
                    else
                    {
                        i[2] -= cantidadVentas;
                        i[3] += cantidadVentas;
                    }
                    numeroVenta++;
                }
            }

            Console.WriteLine("Los siguientes productos tienen actualmente un stock en cero o negativo:");
            foreach (List<double> i in productos)
            {
                if (i[2] <= 0)
                {
                    Console.WriteLine($"Producto codigo {i[0]}. Stock: {i[2]}.");
                }
            }

            Console.WriteLine($"Inicio carga de nombre de productos: ");
            List<string> nombresProductos = new List<string>();
            string nombreProducto;

            foreach (List<double> producto in productos)
            {
                Console.Write($"Codigo {producto[0]}: ");
                nombreProducto = Console.ReadLine();
                nombresProductos.Add(nombreProducto);
            }

            Console.WriteLine($"Los siguientes productos tuvieron menos de diez ventas: ");
            int indice = 0;
            foreach (List<double> producto in productos)
            {
                if (producto[3] < 10)
                {
                    Console.WriteLine(nombresProductos[indice]);
                }
                indice++;
            }
        }
    }
}
