using CalculadoraComTestes.Services;
using Xunit;

namespace CalculadoraTeste.CalculadoraComTestes.Services
{
    public class CalculadoraServiceTest
    {
        private CalculadoraService _service;

        private void Setup()
        {
            _service = new CalculadoraService();
        }

        [Fact]
        public void Somar_deve_somar()
        {
            Setup();

            //ARRANGE
            var a = 1;
            var b = 1;

            var expected = 2;

            //ACT
            var result = _service.Somar(a, b);

            //ASSERT
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Subtrair_deve_subtrair()
        {
            Setup();

            //ARRANGE
            var a = 6;
            var b = 3;

            var expected = 3;

            //ACT
            var result = _service.Subtracao(a, b);

            //ASSERT
            Assert.Equal(expected, result);
        }
    }
}
