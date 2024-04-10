Console.Write("Ingrese la longitud de un lado del cuadrado: ");
float lado, area;
if (!float.TryParse(Console.ReadLine(), out lado) || lado <= 0)
{
    Console.WriteLine("Error, numero no valido.");
}
else
{
    area = lado * lado;
    Console.WriteLine("El area del cuadrado es: " + area);
}