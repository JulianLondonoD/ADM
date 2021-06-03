using ADM.PruebaTecnica.Entities;
using ADM.PruebaTecnica.Repository.Interfaces;
using ADM.PruebaTecnica.Services.Implementaciones;
using ADM.PruebaTecnica.Services.Interfaces;
using ADM.PruebaTecnica.UnitTest.Mocks.Repository;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ADM.PruebaTecnica.UnitTest
{
    [TestClass]
    public class CategoriasTest
    {
        private static  ICategoriasService _service;

        [ClassInitialize]
        public static void Setup(TestContext context)
        {
            Mock<ICategoriasRepository> _repository = new CategoriasRepositoryMock()._repository;
            _service = new CategoriasService(_repository.Object);
        }

        [TestMethod]
        public async Task CategoriasNoDebeSerVacia()
        {
            IList<CategoriaEntity> result = await _service.GetCategorias();
            result.Should().NotBeEmpty();
        }


    }
}
