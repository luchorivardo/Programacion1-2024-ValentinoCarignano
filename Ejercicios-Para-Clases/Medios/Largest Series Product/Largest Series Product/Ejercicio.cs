namespace Largest_Series_Product
{
    /*
        Consigna: 
            Trabajas para una agencia gubernamental que ha interceptado una serie de señales de comunicación cifradas de un grupo de ladrones de bancos. Las señales contienen una larga secuencia de dígitos.
            Tu equipo debe utilizar varias técnicas de procesamiento de señales digitales para analizar las señales e identificar cualquier patrón que pueda indicar la planificación de un atraco.

            Instrucciones
            Su tarea es buscar patrones en la larga secuencia de dígitos de la señal cifrada.

            La técnica que vamos a utilizar aquí se llama producto de la serie más grande.

            Definamos primero algunos términos.

            entrada : la secuencia de dígitos que necesitas analizar
            serie : una secuencia de dígitos adyacentes (aquellos que están uno al lado del otro) que está contenida dentro de la entrada
            span : ¿cuántos dígitos tiene cada serie?
            producto : lo que obtienes cuando multiplicas números
            Trabajemos con un ejemplo, con la entrada "63915".

            Para formar una serie, tome los dígitos adyacentes en la entrada original.
            Si está trabajando con un lapso de 3, habrá tres series posibles:
            "639"
            "391"
            "915"
            Luego necesitamos calcular el producto de cada serie:
            El producto de la serie "639" es 162 ( 6 × 3 × 9 = 162)
            El producto de la serie "391" es 27 ( 3 × 9 × 1 = 27)
            El producto de la serie "915" es 45 ( 9 × 1 × 5 = 45)
            162 es mayor que 27 y 45, por lo que el producto de la serie más grande de "63915"es de la serie "639". Por lo tanto, la respuesta es 162 .
     */

    public class Ejercicio
    {
        public static long GetLargestProduct(string digits, int span)
        {
            if (digits.Length < span || span < 0)
            {
                throw new ArgumentException();
            }

            foreach (char c in digits)
            {
                if (!char.IsDigit(c))
                {
                    throw new ArgumentException();
                }
            }

            long respuesta = 0;

            for (int i = 0; i <= digits.Length - span; i++)
            {
                string substring = digits.Substring(i, span);

                long resultado = 1;
                foreach (char n in substring)
                {
                    resultado *= n - '0';
                }

                if (resultado > respuesta)
                {
                    respuesta = resultado;
                }
            }

            return respuesta;
        }
    }
}
            