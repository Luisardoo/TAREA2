using NUnit.Framework;
using WEB_Horoscopo.Controllers;

namespace NUnitTestHoroscopo
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        // Inicio GET
        public void TestHoroscopoGet()
        {
            //Arrange=preparacion
            int dia = 16;
            int mes = 10;
            string esperado = "Libra => Si no sabes bailar, no significa que no debas bailar ";
            HoroscopoController txt = new HoroscopoController();

            //Act=ejecucion
            string resultado = txt.horoscopoget(dia, mes);

            //Assert=verificacion
            Assert.AreEqual(esperado, resultado);
        }


        [Test]
        // Inicio POST
        public void TestHoroscopoPost()
        {
            //Arrange=preparacion
            int dia = 6;
            int mes = 8;
            string esperado = "Leo => Ganarás todos tus dotitas del dia ";
            HoroscopoController txt = new HoroscopoController();

            //Act=ejecucion
            string resultado = txt.horoscopopost(dia, mes);

            //Assert=verificacion
            Assert.AreEqual(esperado, resultado);
        }
    }
}
