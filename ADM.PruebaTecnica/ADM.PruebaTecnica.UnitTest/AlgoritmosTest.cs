using ADM.PruebaTecnica.Services.Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentAssertions;

namespace ADM.PruebaTecnica.UnitTest
{
    [TestClass]
    public class AlgoritmosTest
    {
        private static IAlgortimosDomain _domain;

        [ClassInitialize]
        public static void Setup(TestContext context)
        {
            _domain = new AlgortimosDomain();
        }

        [TestMethod]
        public void EsPalindromo()
        {
            string palabra = "amor a Roma";
            string palabraInversa = _domain.InvertirCadena(palabra).ToLower();
            palabra = _domain.QuitarTildes(palabra.ToLower());
            palabraInversa = _domain.QuitarTildes(palabraInversa);
            bool palindroma = _domain.Palindroma(palabra, palabraInversa);
            palindroma.Should().BeTrue();
        }
    }
}
