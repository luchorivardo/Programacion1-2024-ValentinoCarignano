using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CDatos.Contexts;
using CEntidades.Entidades;

namespace CLogica.Metodos
{
    public class CRUDPersona
    {
        LibreriaContext context = new LibreriaContext();

        public void Alta(Persona persona)
        {
            Persona nuevaPersona = new Persona();

            if (persona != null)
            {
                var documentoBuscado = context.Persona.Find(persona.Documento);
                if(documentoBuscado == null)
                {
                    if (persona.Documento.Length >= 8)
                    {
                        if (persona.Nombre.Length > 2 && persona.Nombre.Length < 20)
                        {
                            if (persona.Apellido.Length > 2 && persona.Apellido.Length < 20)
                            {
                                if (persona.Autor != null)
                                {
                                    nuevaPersona.Autor = persona.Autor;
                                }
                                else if (persona.Cliente != null)
                                {
                                    nuevaPersona.Cliente = persona.Cliente;
                                }
                                else if (persona.Empleado != null)
                                {
                                    nuevaPersona.Empleado = persona.Empleado;
                                }
                                nuevaPersona = persona;
                                context.Persona.Add(nuevaPersona);
                                context.SaveChanges();
                            }
                            else
                            {
                                throw new Exception("El apellido no es valido.");
                            }
                        }
                        else
                        {
                            throw new Exception("El nombre no es valido.");
                        }
                    }
                    else
                    {
                        throw new Exception("El DNI ingresado no es valido.");
                    }
                }
                else
                {
                    throw new Exception("El DNI ingresado ya ha sido ingresado.");
                }
            }
            else
            {
                throw new Exception("No se ha recibido ninguna persona.");
            }
        }
    }
}
