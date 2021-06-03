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
            try
            {
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
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public double ValorMayorConUnFor(double[] valores)
        {
            double mayor = valores[0];
            try
            {
                for (int i = 1; i < valores.Length; i++)
                {
                    if (valores[i] > mayor)
                        mayor = valores[i];
                }

                return mayor;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IList<string> SplitCadena(string texto)
        {
            IList<string> palabras = new List<string>();
            string cadena = string.Empty;

            try
            {
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
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public int VecesPalabraEnTexto(IList<string> palabras, string palabra)
        {
            int count = 0;

            try
            {
                for (int i = 0; i < palabras.Count; i++)
                {
                    if (palabras[i] == palabra)
                        count += 1;
                }

                return count;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public string InvertirCadena(string palabra)
        {
            string cadena = string.Empty;
            try
            {
                for (int i = palabra.Length - 1; i >= 0; i--)
                    cadena += palabra[i];

                return cadena;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public string QuitarTildes(string palabra)
        {
            string caracteresEspeciales = "áéíóúñ";
            try
            {
                palabra = Regex.Replace(caracteresEspeciales.Normalize(NormalizationForm.FormD), @"[^a-zA-z0-9 ]+", palabra);
                return palabra;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Palindroma(string palabra, string palabraInversa)
        {
            bool palindroma = false;
            try
            {
                if (palabra.Equals(palabraInversa))
                    palindroma = !palindroma;
                return palindroma;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
