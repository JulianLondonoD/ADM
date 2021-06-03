using ADM.PruebaTecnica.Entities;
using ADM.PruebaTecnica.Repository.Interfaces;
using ADM.PruebaTecnica.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ADM.PruebaTecnica.Services.Implementaciones
{
    public class CategoriasService : ICategoriasService
    {
        private readonly ICategoriasRepository _repository;
        public CategoriasService(ICategoriasRepository repository)
        {
            _repository = repository;
        }
        public async Task<IList<CategoriaEntity>> GetCategorias()
        {
            return await _repository.Read();
        }

        public async Task NewCategoria(CategoriaEntity categoria)
        {
            await _repository.Create(categoria);
        }

        public async Task RemoveCategoria(CategoriaEntity categoria)
        {
            await _repository.Delete(categoria);
        }
    }
}
