using System;

namespace Luhn
{

    /*
    Consigna:
        Dado un número, determine si es válido o no según la fórmula de Luhn.

        El algoritmo de Luhn es una fórmula de suma de comprobación simple que se utiliza para validar una variedad de números de identificación, como números de tarjetas de crédito y números de seguro social canadienses.

        La tarea es comprobar si una cadena dada es válida.

        Validando un número
        Las cadenas de longitud 1 o menos no son válidas. Se permiten espacios en la entrada, pero deben eliminarse antes de la verificación. No se permiten otros caracteres que no sean dígitos.

        Ejemplo 1: número de tarjeta de crédito válido
            4539 3195 0343 6467

            El primer paso del algoritmo de Luhn es duplicar cada segundo dígito, comenzando desde la derecha.
                4_3_ 3_9_ 0_4_ 6_6_

            Si al duplicar el número se obtiene un número mayor que 9, se resta 9 del producto. Los resultados de la duplicación son:
                8569 6195 0383 3437

            Luego suma todos los dígitos:
                8+5+6+9+6+1+9+5+0+3+8+3+3+4+3+7 = 80

            Si la suma es divisible por 10, entonces el número es válido. ¡Este número es válido!

        Ejemplo 2: número de tarjeta de crédito no válido
            8273 1232 7352 0569

            Duplica los segundos dígitos, empezando desde la derecha.
                7253 2262 5312 0539

            Sumar los dígitos
                7+2+5+3+2+2+6+2+5+3+1+2+0+5+3+9 = 57

            57 no es divisible exactamente por 10, por lo que este número no es válido.
    */

    public static class Luhn
    {
        public static bool IsValid(string number)
        {
            bool isValidNumber = true;

            number = new string(number.Trim().Replace(" ", "").Reverse().ToArray());

            foreach (char c in number)
            {
                if (!char.IsDigit(c))
                {
                    isValidNumber = false;
                }
            }

            if (number.Length == 1)
            {
                isValidNumber = false;
            }

            int sumaDigitos = 0;
            for (int i = 0; i < number.Length; i ++)
            {
                int nuevoNumero = number[i] - '0';
                if (i % 2 != 0)
                {
                    nuevoNumero = nuevoNumero * 2;
                    if (nuevoNumero > 9)
                    {
                        nuevoNumero -= 9;
                    }
                }
                sumaDigitos += nuevoNumero;
            }

            if((sumaDigitos / 10F) % 2 != 0 && sumaDigitos != 10)
            {
                isValidNumber = false;
            }

           


            return isValidNumber;
        }
    }
}
