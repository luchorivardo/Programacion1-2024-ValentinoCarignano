Console.Write("Ingrese el primer lado de un triangulo: ");
float lado1, lado2, lado3, perimetro;
if (!float.TryParse(Console.ReadLine(), out lado1) || lado1 <= 0)
{
    Console.WriteLine("Error, numero no valido.");
}
else
{
    Console.Write("Ingrese el segundo lado de un triangulo: ");
    if (!float.TryParse(Console.ReadLine(), out lado2) || lado2 <= 0)
    {
        Console.WriteLine("Error, numero no valido.");
    }
    else
    {
        Console.Write("Ingrese el tercer lado de un triangulo: ");
        if (!float.TryParse(Console.ReadLine(), out lado3) || lado3 <= 0)
        {
            Console.WriteLine("Error, numero no valido.");
        }
        else
        {
            perimetro = lado1 + lado2 + lado3;
            Console.WriteLine("El perimetro del triangulo es: " + perimetro);
        }
    }
}