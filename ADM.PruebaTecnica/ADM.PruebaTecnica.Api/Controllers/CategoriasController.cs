using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using ADM.PruebaTecnica.Entities;
using ADM.PruebaTecnica.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ADM.PruebaTecnica.Api.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriasController : ControllerBase
    {
        private readonly ICategoriasService _service;
        public CategoriasController(ICategoriasService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IList<CategoriaEntity>> Get()
        {
            return await _service.GetCategorias();
        }

        [HttpPost]
        public async Task Post(CategoriaEntity categoria)
        {
            await _service.NewCategoria(categoria);
        }

        [HttpDelete("{categoria}")]
        public async Task Delete(string categoria)
        {
            CategoriaEntity _categoria = JsonSerializer.Deserialize<CategoriaEntity>(categoria);
            await _service.RemoveCategoria(_categoria);
        }
    }
}
