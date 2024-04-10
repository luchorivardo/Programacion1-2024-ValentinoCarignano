Console.Write("Ingrese el primer numero: ");
float number1, number2, number3, prom;
if(!float.TryParse(Console.ReadLine(), out number1))
{
    Console.WriteLine("Error, numero no valido");
}
else
{
    Console.Write("Ingrese el segundo numero: ");
    if (!float.TryParse(Console.ReadLine(), out number2))
    {
        Console.WriteLine("Error, numero no valido");
    }
    else
    {
        Console.Write("Ingrese el tercer numero: ");
        if (!float.TryParse(Console.ReadLine(), out number3))
        {
            Console.WriteLine("Error, numero no valido");
        }
        else
        {
            prom = (number1 + number2 + number3) / 3;
            Console.WriteLine("El promedio entre los tres numeros ingresados es: " + prom);
        }
    }
}