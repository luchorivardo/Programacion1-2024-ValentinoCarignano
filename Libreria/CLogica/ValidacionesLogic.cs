using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CLogica
{
    public class ValidacionesLogic
    {
        public static bool DocumentoEsValido(string documento)
        {

            if (string.IsNullOrEmpty(documento))
            {
                return true;
            }
            else if (string.IsNullOrWhiteSpace(documento) || documento.Length < 8)
            {
                return false;
            }

            foreach (char c in documento)
            {
                if (!char.IsNumber(c))
                {
                    return false;
                }
            }

            return true;
        }
        public static bool NombreApellidoEsValido(string texto)
        {
            if (string.IsNullOrWhiteSpace(texto))
            {
                return false;
            }

            texto = texto.Trim();

            if (texto.Contains("  "))
            {
                return false;
            }

            if (texto.Length < 3 || texto.Length > 20)
            {
                return false;
            }

            foreach (char c in texto)
            {
                if (!char.IsLetter(c) && !char.IsWhiteSpace(c))
                {
                    return false;
                }
            }

            return true;
        }
        public static bool TelefonoEsValido(string telefono)
        {
            if (string.IsNullOrEmpty(telefono))
            {
                return true;
            }

            var regex = new Regex(@"^\+\d{1,4}\s?\d{1,5}\s?\d{6,}$");
            return regex.IsMatch(telefono);
        }
        public static DateTime ParsearFecha(string fechaString)
        {
            if (string.IsNullOrWhiteSpace(fechaString))
            {
                throw new ArgumentException("La cadena de fecha no puede estar vacía o ser nula.", nameof(fechaString));
            }

            if (DateTime.TryParse(fechaString, out DateTime fecha))
            {
                return fecha;
            }
            else
            {
                throw new FormatException("La cadena no tiene un formato de fecha válido.");
            }
        }

    }
}
