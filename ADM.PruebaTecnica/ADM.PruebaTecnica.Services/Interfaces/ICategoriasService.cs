using ADM.PruebaTecnica.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ADM.PruebaTecnica.Services.Interfaces
{
    public interface ICategoriasService
    {
        Task<IList<CategoriaEntity>> GetCategorias();
        Task RemoveCategoria(CategoriaEntity categoria);
        Task NewCategoria(CategoriaEntity categoria);
    }
}
