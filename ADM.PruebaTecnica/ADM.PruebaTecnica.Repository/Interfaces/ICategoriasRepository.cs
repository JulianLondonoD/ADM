using ADM.PruebaTecnica.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ADM.PruebaTecnica.Repository.Interfaces
{
    public interface ICategoriasRepository
    {
        Task<IList<CategoriaEntity>> Read();
        Task Create(CategoriaEntity categoria);
        Task Delete(CategoriaEntity categoria);
    }
}
