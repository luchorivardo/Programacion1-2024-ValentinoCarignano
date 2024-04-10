Console.Write("Ingrese el primer numero: ");
float number1, number2;
if (!float.TryParse(Console.ReadLine(), out number1))
{
    Console.WriteLine("Error, numero no valido.");
}
else
{
    Console.Write("Ingrese el segundo numero: ");
    if (!float.TryParse(Console.ReadLine(), out number2))
    {
        Console.WriteLine("Error, numero no valido.");
    }
    else
    {
        if (number1 > number2)
        {
            Console.WriteLine("El mayor de los dos numeros es: " + number1);
        }
        else if (number1 < number2)
        {
            Console.WriteLine("El mayor de los dos numeros es: " + number2);
        }
        else
        {
            Console.WriteLine("Los numeros son iguales.");
        }
    }
}