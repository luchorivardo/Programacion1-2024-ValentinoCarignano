Console.Write("Ingrese un numero para determinar si es positivo: ");
float number;
if (!float.TryParse(Console.ReadLine(), out number))
{
    Console.WriteLine("Error, numero invalido");
}
else
{
    if (number > 0)
    {
        Console.WriteLine("El numero es positivo.");
    }
    else
    {
        Console.WriteLine("El numero no es positivo.");
    }
}