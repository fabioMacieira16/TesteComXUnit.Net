using Demo;
using Xunit;

namespace DemoTest
{
    public class AssertNumber
    {
        [Fact]
        public void Calculadora_Somar_DeveSerIgual()
        {
            // Arrrange
            var calculadora = new Calculadora();

            // Act
            var result = calculadora.Somar(1, 2);

            // Assert
            Assert.Equal(3, result);
        }

        [Fact]
        public void Calculadora_Somar_NaoDeveSerIgual()
        {
            // Arrrange
            var calculadora = new Calculadora();

            // Act
            var result = calculadora.Somar(1.1312112123, 2.231313131);

            // Assert
            Assert.NotEqual(3.3, result, 1);
        }

    }
}
