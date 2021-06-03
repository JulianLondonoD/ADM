using System;
using System.Collections.Generic;
using System.Text;

namespace ADM.PruebaTecnica.Services.Domain
{
    public interface IAlgortimosDomain
    {
        double MultiplicarNumeroSinMultiplicacion(double numeroA, double numeroB);
        double ValorMayorConUnFor(double[] valores);
        IList<string> SplitCadena(string texto);
        int VecesPalabraEnTexto(IList<string> palabras, string palabra);
        string InvertirCadena(string palabra);
        string QuitarTildes(string palabra);
        bool Palindroma(string palabra, string palabraInversa);
    }
}
