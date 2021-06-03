using ADM.PruebaTecnica.Services.Interfaces;
using ADM.PruebaTecnica.UnitTest.Stubs;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;

namespace ADM.PruebaTecnica.UnitTest.Mocks.Services
{
    public class CategoriasServiceMock
    {
        public Mock<ICategoriasService> _service { get; set; }

        public CategoriasServiceMock()
        {
            _service = new Mock<ICategoriasService>();
            Setup();
        }

        private void Setup()
        {
            _service.Setup(x => x.GetCategorias()).ReturnsAsync(CategoriaStub.categorias);
        }
    }
}
