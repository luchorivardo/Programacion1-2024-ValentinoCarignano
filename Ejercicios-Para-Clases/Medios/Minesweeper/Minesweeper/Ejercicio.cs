using System;

namespace Minesweeper
{

    /*
    Consigna:
        Buscaminas es un juego popular en el que el usuario tiene que encontrar las minas utilizando pistas numéricas que indican cuántas minas están directamente adyacentes (horizontal, vertical, diagonal) a un cuadrado.

        Instrucciones
        Tu tarea consiste en sumar la cantidad de minas a los cuadrados vacíos de un tablero de Buscaminas completo. El tablero en sí es un rectángulo compuesto de cuadrados que están vacíos ( ' ' ) o tienen una mina ( '*' ).

        En cada casilla vacía, cuente la cantidad de minas adyacentes (horizontal, vertical y diagonalmente). Si la casilla vacía no tiene minas adyacentes, déjela vacía. De lo contrario, reemplácela con el recuento de minas adyacentes.

        Por ejemplo, puede recibir un tablero de 5 x 4 como éste (los espacios vacíos se representan aquí con el carácter '·' para su visualización en pantalla):

            ·*·*·
            ··*··
            ··*··
            ·····

        Tu código debería transformarse en esto:

            1*3*1
            13*31
            ·2*2·
            ·111·
    */

    public static class Minesweeper
    {
        public static string[] Annotate(string[] input)
        {
            string[] arrayResultado = new string[input.Length];
            char[] charArray = new char[input.Length];

            int contadorMinas = 0;
            int contadorCaracteres = 0;

            for (int i = 0; i < input.Length; i++)
            {
                contadorCaracteres += input[i].Length;
                char[] arrayFila = input[i].ToCharArray();

                if (string.IsNullOrEmpty(input[i]))
                {
                    arrayResultado = input;
                }
                else
                {
                    for (int j = 0; j < input[i].Length; j++)
                    {
                        int minasAlrededor = 0;

                        if (input[i][j] == '*')
                        {
                            contadorMinas++;
                        }

                        if(input[i][j] == ' ')
                        {

                            if (i > 0 && j > 0 && input[i - 1][j - 1] == '*') minasAlrededor++;
                            if (i > 0 && input[i - 1][j] == '*') minasAlrededor++;
                            if (i > 0 && j < input[i - 1].Length - 1 && input[i - 1][j + 1] == '*') minasAlrededor++;
                            if (j > 0 && input[i][j - 1] == '*') minasAlrededor++;
                            if (j < input[i].Length - 1 && input[i][j + 1] == '*') minasAlrededor++;
                            if (i < input.Length - 1 && j > 0 && input[i + 1][j - 1] == '*') minasAlrededor++;
                            if (i < input.Length - 1 && input[i + 1][j] == '*') minasAlrededor++;
                            if (i < input.Length - 1 && j < input[i + 1].Length - 1 && input[i + 1][j + 1] == '*') minasAlrededor++;




                            string minasAlrededorStr = minasAlrededor.ToString();
                            arrayFila[j] = minasAlrededorStr[0];

                            if(minasAlrededor == 0)
                            {
                                minasAlrededorStr = " ";
                            }
                        }

                        arrayResultado[i] = new string(arrayFila);
                    }
                }    
            }

            if (contadorMinas == 0 || contadorMinas == contadorCaracteres)
            {
                arrayResultado = input;
            }

            return arrayResultado;
        }
    }

}
