using CDatos.Contexts;
using CDatos.Repositories.Contracts;
using CEntidades.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDatos.Repositories
{
    public class AutorRepository : Repository<Autor>, IAutorRepository
    {
        public AutorRepository(LibreriaContext context) : base(context)
        {

        }

        public void CreateAutor(Autor autor)
        {
            _context.Autor.Attach(autor);
        }

        public List<Autor> ObtenerAutores()
        {
            return _context.Autor.Include(a => a.PersonaAutor).ToList();
        }
    }
}
