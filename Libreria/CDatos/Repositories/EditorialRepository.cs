using CDatos.Contexts;
using CDatos.Repositories.Contracts;
using CEntidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDatos.Repositories
{
    public class EditorialRepository : Repository<Editorial>, IEditorialRepository
    {
        public EditorialRepository(LibreriaContext context) : base(context)
        {

        }

    }
}
