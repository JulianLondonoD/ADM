using ADM.PruebaTecnica.Entities;
using ADM.PruebaTecnica.Repository.Interfaces;
using ADM.PruebaTecnica.UnitTest.Stubs;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;

namespace ADM.PruebaTecnica.UnitTest.Mocks.Repository
{
    public class CategoriasRepositoryMock
    {
        public Mock<ICategoriasRepository> _repository { get; set; }

        public CategoriasRepositoryMock()
        {
            _repository = new Mock<ICategoriasRepository>();
            Setup();
        }

        private void Setup()
        {
            _repository.Setup(x => x.Read()).ReturnsAsync(CategoriaStub.categorias);
        }
    }
}
