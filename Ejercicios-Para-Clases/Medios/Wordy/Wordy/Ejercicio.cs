using System;
using System.IO;

namespace Wordy
{
    /*
    Consigna:
        Instrucciones
        Analizar y evaluar problemas matemáticos simples y devolver la respuesta como un número entero.

        Iteración 0 — Números
            Los problemas sin operaciones simplemente se evalúan al número dado.

                What is 5?
                    Se evalúa como 5.

        Iteración 1 — Adición
            Sumar dos números juntos.

                What is 5 plus 13?
                    Se evalúa como 18.

            Manejar números grandes y números negativos.

        Iteración 2: Resta, multiplicación y división
            Ahora, realiza las otras tres operaciones.

                What is 7 minus 5?
                    2

                What is 6 multiplied by 4?
                    24

                What is 25 divided by 5?
                    5

        Iteración 3: Operaciones múltiples
            Manejar un conjunto de operaciones, en secuencia.

            Dado que se trata de problemas verbales, evalúe la expresión de izquierda a derecha, ignorando el orden típico de operaciones.

                What is 5 plus 13 plus 6?
                    24

                What is 3 plus 2 multiplied by 3?
                    15 (es decir, no 9)

        Iteración 4: Errores
            El analizador debe rechazar:

            Operaciones no admitidas ("What is 52 cubed?")

            Preguntas no matemáticas ("Who is the President of the United States?")

            Problemas de palabras con sintaxis no válida ("What is 1 plus plus 2?")
    */

    public static class Wordy
    {
        public static int Answer(string question)
        {
            int respuesta = 0;

            string[] pregunta = question.Replace("What is", null).Replace("?", null).Split(" ");

            #region errores
            if (pregunta.Contains("cubed"))
            {
                throw new ArgumentException();
            }

            int sinNumeros = 0;
            for (int i = 0; i < pregunta.Length; i++)
            {
                Int32.TryParse(pregunta[i], out sinNumeros);
            }
            if(sinNumeros == 0)
            {
                throw new ArgumentException();
            }

            int number1, number2;
            for (int i = 0; i < pregunta.Length - 1; i++)
            {
                if (Int32.TryParse(pregunta[i], out number1) && Int32.TryParse(pregunta[i + 1], out number2))
                {
                    if (number1 + number2 != 0)
                    {
                        throw new ArgumentException();
                    }
                }
            } 

            for (int i = 0; i < pregunta.Length; i++)
            {
                if (i + 1 < pregunta.Length)
                {
                    if ((pregunta[i] == "plus" || pregunta[i] == "minus" || pregunta[i] == "multiplied" || pregunta[i] == "divided") &&
                    (pregunta[i + 1] == "plus" || pregunta[i + 1] == "minus" || pregunta[i + 1] == "multiplied" || pregunta[i + 1] == "divided"))
                    {
                        throw new ArgumentException();
                    }
                }
            }
            #endregion

            #region operaciones
            for (int i = 0; i < pregunta.Length; i++)
            {
                if (pregunta[i] == "plus")
                {
                    if (pregunta[i - 2] is null or "plus" or "minus" or "by")
                    {
                        respuesta += int.Parse(pregunta[i + 1]);
                    }
                    else
                    {
                        respuesta = int.Parse(pregunta[i - 1]) + int.Parse(pregunta[i + 1]);
                    }
                }

                if (pregunta[i] == "minus")
                {
                    if (pregunta[i - 2] is null or "plus" or "minus" or "by")
                    {
                        respuesta -= int.Parse(pregunta[i + 1]);
                    }
                    else
                    {
                        respuesta = int.Parse(pregunta[i - 1]) - int.Parse(pregunta[i + 1]);
                    }
                }
                
                if (pregunta[i] == "multiplied")
                {
                    if (pregunta[i - 2] is null or "plus" or "minus" or "by")
                    {
                        respuesta *= int.Parse(pregunta[i + 2]);
                    }
                    else
                    {
                        respuesta = int.Parse(pregunta[i - 1]) * int.Parse(pregunta[i + 2]);
                    }
                }
                
                if (pregunta[i] == "divided")
                {
                    if (pregunta[i - 2] is null or "plus" or "minus" or "by")
                    {
                        respuesta /= int.Parse(pregunta[i + 2]);
                    }
                    else
                    {
                        respuesta = int.Parse(pregunta[i - 1]) / int.Parse(pregunta[i + 2]);
                    }
                }
            }
           
            if(respuesta == 0)
            {
                respuesta = int.Parse(pregunta[1]);
            }
            #endregion

            return respuesta;
        }
    }
}
