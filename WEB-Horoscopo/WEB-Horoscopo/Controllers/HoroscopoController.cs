using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WEB_Horoscopo.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HoroscopoController : Controller
    {
        [HttpGet]
        public string horoscopoget(int dia, int mes)
        {
            if (dia > 31 || dia < 1)
            {
                return "Fecha de nacimiento no válida";
            }

            if (mes < 1 || mes > 12)
            {
                return "Fecha de nacimiento no válida";
            }
            if ((dia >= 21 && mes == 1) || (dia <= 19 && mes == 2))
            {
                return "Acuarius => El fin se acerca, y es tu culpa :(";
            }
            if ((dia >= 20 && mes == 2) || (dia <= 20 && mes == 3))
            {
                return "Piscis => Eres Natural !... como los desastres ";
            }
            if ((dia >= 21 && mes == 3) || (dia <= 20 && mes == 4))
            {
                return "Aries => Si te sientes mal, bebe una taza de café. No te sentirás mejor, pero al menos beberás café ";
            }
            if ((dia >= 21 && mes == 4) || (dia <= 20 && mes == 5))
            {
                return "Tauro => Si no te acuerdas, no pasó";
            }
            if ((dia >= 21 && mes == 5) || (dia <= 21 && mes == 6))
            {
                return "Geminis => Obtendrás aquello que siempre estuviste queriendo :) ";
            }
            if ((dia >= 22 && mes == 6) || (dia <= 22 && mes == 7))
            {
                return "Cancer => Encontrarás a Martha esta semana ";
            }
            if ((dia >= 23 && mes == 7) || (dia <= 23 && mes == 8))
            {
                return "Leo => Ganarás todos tus dotitas del dia ";
            }
            if ((dia >= 24 && mes == 8) || (dia <= 22 && mes == 9))
            {
                return "Virgo => Tocarás muchas puertas pero no se abrirá ninguna ";
            }
            if ((dia >= 23 && mes == 9) || (dia <= 22 && mes == 10))
            {
                return "Libra => Si no sabes bailar, no significa que no debas bailar ";
            }
            if ((dia >= 23 && mes == 10) || (dia <= 22 && mes == 11))
            {
                return "Escorpion => Dejá de ser tan sucha ";
            }
            if ((dia >= 23 && mes == 11) || (dia <= 21 && mes == 12))
            {
                return "Sagitario => Te va a dar COVID ";
            }
            if ((dia >= 22 && mes == 12) || (dia <= 20 && mes == 1))
            {
                return "Capricornio => Te va a crecer 2 centimetrazos más ";
            }
            return "";
        }
        [HttpPost]
        public string horoscopopost([FromHeader] int dia, [FromHeader] int mes)
        {
            if (dia > 31 || dia < 1)
            {
                return "Fecha de nacimiento no válida";
            }

            if (mes < 1 || mes > 12)
            {
                return "Fecha de nacimiento no válida";
            }
            if ((dia >= 21 && mes == 1) || (dia <= 19 && mes == 2))
            {
                return "Acuarius => El fin se acerca, y es tu culpa :(";
            }
            if ((dia >= 20 && mes == 2) || (dia <= 20 && mes == 3))
            {
                return "Piscis => Eres Natural !... como los desastres ";
            }
            if ((dia >= 21 && mes == 3) || (dia <= 20 && mes == 4))
            {
                return "Aries => Si te sientes mal, bebe una taza de café. No te sentirás mejor, pero al menos beberás café ";
            }
            if ((dia >= 21 && mes == 4) || (dia <= 20 && mes == 5))
            {
                return "Tauro => Si no te acuerdas, no pasó";
            }
            if ((dia >= 21 && mes == 5) || (dia <= 21 && mes == 6))
            {
                return "Geminis => Obtendrás aquello que siempre estuviste queriendo :) ";
            }
            if ((dia >= 22 && mes == 6) || (dia <= 22 && mes == 7))
            {
                return "Cancer => Encontrarás a Martha esta semana ";
            }
            if ((dia >= 23 && mes == 7) || (dia <= 23 && mes == 8))
            {
                return "Leo => Ganarás todos tus dotitas del dia ";
            }
            if ((dia >= 24 && mes == 8) || (dia <= 22 && mes == 9))
            {
                return "Virgo => Tocarás muchas puertas pero no se abrirá ninguna ";
            }
            if ((dia >= 23 && mes == 9) || (dia <= 22 && mes == 10))
            {
                return "Libra => Si no sabes bailar, no significa que no debas bailar ";
            }
            if ((dia >= 23 && mes == 10) || (dia <= 22 && mes == 11))
            {
                return "Escorpion => Dejá de ser tan sucha ";
            }
            if ((dia >= 23 && mes == 11) || (dia <= 21 && mes == 12))
            {
                return "Sagitario => Te va a dar COVID ";
            }
            if ((dia >= 22 && mes == 12) || (dia <= 20 && mes == 1))
            {
                return "Capricornio => Te va a crecer 2 centimetrazos más ";
            }
            return "";
        }
    }
}
