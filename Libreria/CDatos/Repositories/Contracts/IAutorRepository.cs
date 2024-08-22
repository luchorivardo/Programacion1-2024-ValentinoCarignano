using CEntidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDatos.Repositories.Contracts
{
    public interface IAutorRepository: IRepository<Autor>
    {
        void CreateAutor(Autor autor);
        List<Autor> ObtenerAutores();
    }
}
