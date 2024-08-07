using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Azure.Identity;
using CDatos.Contexts;
using CEntidades.Entidades;
using Microsoft.EntityFrameworkCore;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CLogica.Metodos
{
    public class CRUDPersona
    {
        LibreriaContext context = new LibreriaContext();
        public void AltaPersona(Persona persona)
        {
            Persona personaNueva = new Persona();

            if (persona == null)
            {
                throw new ArgumentNullException("No se ha ingresado ninguna persona.");
            }

            if (context.Persona.Any(p => p.Documento == persona.Documento))
            {
                throw new InvalidOperationException("El DNI no puede coincidir con uno ya ingresado.");
            }

            if (!DocumentoEsValido(persona.Documento))
            {
                throw new ArgumentException("El DNI ingresado no es valido.");
            }

            if (!NombreApellidoEsValido(persona.Nombre))
            {
                throw new ArgumentException("El nombre ingresado no es valido.");
            }

            if (!NombreApellidoEsValido(persona.Apellido))
            {
                throw new ArgumentException("El apellido ingresado no es valido.");
            }

            if (!TelefonoEsValido(persona.Telefono))
            {
                throw new ArgumentException("El apellido ingresado no es valido.");
            }

            if (persona.Autor != null)
            {
                personaNueva.Autor = persona.Autor;
            }
            else if (persona.Cliente != null)
            {
                personaNueva.Cliente = persona.Cliente;
            }
            else if (persona.Empleado != null)
            {
                personaNueva.Empleado = persona.Empleado;
            }
            else
            {
                throw new ArgumentException("La persona debe ser de tipo Autor, Cliente o Empleado.");
            }

            personaNueva = persona;
            context.Persona.Add(personaNueva);
            context.SaveChanges();
        }

        public List<Persona> ObtenerPersonas()
        {
            return context.Persona.ToList();
        }

        public void BajaPersona(Persona persona)
        {
            if (persona == null)
            {
                throw new ArgumentNullException("No se ha seleccionado ninguna persona.");
            }

            var personaEliminada = context.Persona.FirstOrDefault(p => p.Documento == persona.Documento);

            if (personaEliminada == null)
            {
                throw new InvalidOperationException("La persona que se desea eliminar no existe.");
            }

            context.Persona.Remove(personaEliminada);
            context.SaveChanges();
        }

        //Metodos de validacion
        private bool DocumentoEsValido(string documento)
        {
            if (string.IsNullOrWhiteSpace(documento) || documento.Length < 8)
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
        private bool NombreApellidoEsValido(string texto)
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
        private bool TelefonoEsValido(string telefono)
        {
            if (string.IsNullOrEmpty(telefono))
            {
                return true;
            }

            var regex = new Regex(@"^\+\d{1,4}\s?\d{1,5}\s?\d{6,}$");
            return regex.IsMatch(telefono);
        }
    }
}
