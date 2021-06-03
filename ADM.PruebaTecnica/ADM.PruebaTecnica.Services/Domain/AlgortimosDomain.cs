using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace ADM.PruebaTecnica.Services.Domain
{
    public class AlgortimosDomain : IAlgortimosDomain
    {
        public double MultiplicarNumeroSinMultiplicacion(double numeroA, double numeroB)
        {
            double acum = 0;
            if (numeroA > numeroB)
            {
                for (int i = 1; i <= numeroB; i++)
                    acum += numeroA;
            }
            else
                for (int i = 1; i <= numeroA; i++)
                    acum += numeroB;

            return acum;
        }

        public double ValorMayorConUnFor(double[] valores)
        {
            double mayor = valores[0];
            for (int i = 1; i < valores.Length; i++)
            {
                if (valores[i] > mayor)
                    mayor = valores[i];
            }

            return mayor;
        }

        public IList<string> SplitCadena(string texto)
        {
            IList<string> palabras = new List<string>();
            string cadena = string.Empty;

            for (int i = 0; i < texto.Length; i++)
            {
                string letra = texto[i].ToString();
                if (letra != " ")
                    cadena += letra;
                if (i == texto.Length - 1)
                    palabras.Add(cadena);
                if (letra == " ")
                {
                    palabras.Add(cadena);
                    cadena = string.Empty;
                }
            }

            return palabras;
        }

        public int VecesPalabraEnTexto(IList<string> palabras, string palabra)
        {
            int count = 0;

            for (int i = 0; i < palabras.Count; i++)
            {
                if (palabras[i] == palabra)
                    count += 1;
            }

            return count;
        }

        public string InvertirCadena(string palabra)
        {
            string cadena = string.Empty;
            for (int i = palabra.Length - 1; i >= 0; i--)
                cadena += palabra[i];

            return cadena;
        }

        public string QuitarTildes(string palabra) 
        {
            string caracteresEspeciales = "áéíóúñ";
            palabra = Regex.Replace(caracteresEspeciales.Normalize(NormalizationForm.FormD), @"[^a-zA-z0-9 ]+", palabra);
            return palabra;
        }

        public bool Palindroma(string palabra, string palabraInversa) 
        {
            bool palindroma = false;
            if (palabra.Equals(palabraInversa))
                palindroma = !palindroma;
            return palindroma;
        }
    }
}
