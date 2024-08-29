using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rotational_Cipher
{
    /*
    Consigna: 
        Crear una implementación del cifrado rotacional, también llamado a veces cifrado César.

        El cifrado César es un cifrado por desplazamiento simple que se basa en la transposición de todas las letras del alfabeto utilizando una clave entera entre 0 y 26.
        El uso de una clave de 0 o 26 siempre dará como resultado el mismo resultado debido a la aritmética modular. La letra se desplaza para tantos valores como el valor de la clave.

        La notación general para los cifrados rotacionales es ROT + <key>. El cifrado rotacional más comúnmente utilizado es ROT13.

        La A ROT13 en el alfabeto latino quedaría así:
            Original:  abcdefghijklmnopqrstuvwxyz
            Cipher:    nopqrstuvwxyzabcdefghijklm

        Es más fuerte que el cifrado Atbash porque tiene 27 claves posibles y 25 claves utilizables.

        El texto cifrado se escribe con el mismo formato que la entrada, incluidos los espacios y la puntuación.

        Ejemplos
        ROT5 "omg" da "trl"
        ROT0 "c" da "c"
        ROT26 "Cool" da "Cool"
        ROT13 "The quick brown fox jumps over the lazy dog." da "Gur dhvpx oebja sbk whzcf bire gur ynml qbt."
        ROT13 "Gur dhvpx oebja sbk whzcf bire gur ynml qbt." da "The quick brown fox jumps over the lazy dog."
 */

    public static class Ejercicio
    {
        public static string Rotate(string text, int shiftKey)
        {
            throw new NotImplementedException("You need to implement this method.");
        }
    }
}
