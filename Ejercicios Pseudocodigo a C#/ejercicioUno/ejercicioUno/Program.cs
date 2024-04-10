Console.Write("Ingrese el primer numero: ");
int number1, number2;
if(!Int32.TryParse(Console.ReadLine(), out number1))
{
    Console.Write("Error, numero incorrecto");
}
else
{
    Console.Write("Ingrese el segundo numero: ");
    if (!Int32.TryParse(Console.ReadLine(), out number2))
    {
        Console.Write("Error, numero incorrecto");
    }
    else
    {
        Console.Write("La suma entre los dos numeros es: " + (number1 + number2));  
    }
} 