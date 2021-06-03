using ADM.PruebaTecnica.Services.Domain;
using ADM.PruebaTecnica.UnitTest.Stubs;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;

namespace ADM.PruebaTecnica.UnitTest.Mocks.Domain
{
    class AlgoritmosDomainMock
    {
        public Mock<IAlgortimosDomain> _domain { get; set; }

        public AlgoritmosDomainMock()
        {
            _domain = new Mock<IAlgortimosDomain>();
            Setup();
        }

        private void Setup()
        {
            _domain.Setup(x => x.InvertirCadena(It.IsAny<string>())).Returns(AlgoritmosStub.palabraPalindromaInvertida);
            _domain.Setup(x => x.QuitarTildes(It.IsAny<string>())).Returns(AlgoritmosStub.palabraSinTilde);
            _domain.Setup(x => x.Palindroma(It.IsAny<string>(), It.IsAny<string>()));
        }
    }
}
