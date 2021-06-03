using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using ADM.PruebaTecnica.Services.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ADM.PruebaTecnica.Api.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class AlgoritmosController : ControllerBase
    {
        private readonly IAlgortimosDomain _domain;

        public AlgoritmosController(IAlgortimosDomain domain)
        {
            _domain = domain;
        }

        [HttpGet]
        [Route("Multiplicar/{numeroA}/{numeroB}")]
        public IActionResult Get(double numeroA, double numeroB)
        {
            double suma = _domain.MultiplicarNumeroSinMultiplicacion(numeroA, numeroB);
            return Ok("El resultado de la multiplicación es: " + suma.ToString());
        }

        [HttpGet]
        [Route("Mayor/{json}")]
        public IActionResult Get(string json)
        {
            double[] valores = JsonSerializer.Deserialize<double[]>(json);
            double mayor = _domain.ValorMayorConUnFor(valores);
            return Ok("El valor mayor es: " + mayor.ToString());
        }

        [HttpGet]
        [Route("Repetidos/{texto}/{palabra}")]
        public IActionResult Get(string texto, string palabra)
        {
            IList<string> palabras = _domain.SplitCadena(texto);
            int count = _domain.VecesPalabraEnTexto(palabras, palabra);
            return Ok("Cantidad de veces que se encontró la palabra es: " + count.ToString());
        }

        [HttpGet]
        [Route("Palindromas/{palabra}")]
        public IActionResult GetPalindromas(string palabra)
        {
            string palabraInversa = _domain.InvertirCadena(palabra).ToLower();
            palabra = _domain.QuitarTildes(palabra.ToLower());
            palabraInversa = _domain.QuitarTildes(palabraInversa);
            bool palindroma = _domain.Palindroma(palabra, palabraInversa);
            if (palindroma)
                return Ok("el texto es palindromo");
            return Ok("el texto no es palindromo");
        }
    }
}
