using ADM.PruebaTecnica.Data;
using ADM.PruebaTecnica.Entities;
using ADM.PruebaTecnica.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ADM.PruebaTecnica.Repository.Implementaciones
{
    public class CategoriaRepository : ICategoriasRepository
    {
        private readonly ADMDbContext _context;
        public CategoriaRepository(ADMDbContext context)
        {
            _context = context;
        }

        public async Task Create(CategoriaEntity categoria)
        {
            using (_context)
            {
                try
                {
                    _context.Entry(categoria).State = EntityState.Added;
                    await _context.SaveChangesAsync();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public async Task Delete(CategoriaEntity categoria)
        {
            string strSQL = string.Empty;
            using (_context)
            {
                try
                {
                    strSQL = "DELETE FROM Categorias WHERE IdCategoria = " + categoria.IdCategoria.ToString();
                    await _context.Database.ExecuteSqlRawAsync(strSQL);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public async Task<IList<CategoriaEntity>> Read()
        {
            using (_context) 
            {
                try
                {
                    return await _context.Categorias.ToListAsync();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }
    }
}
