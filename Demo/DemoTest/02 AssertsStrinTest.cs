using Demo;
using Xunit;

namespace DemoTest
{
    public class AssertsStrinTest
    {
        [Fact]
        public void StrinsTool_unirNome_RetornaNomeCompleto()
        {
            // Arrange
            var sut = new StringsTools();

            //Act
            var nomeCompleto = sut.Unir("Fabio", "Macieira");

            // Assert
            Assert.Equal("Fabio Macieira", nomeCompleto);
        }
         
        [Fact]
        public void StringTools_UnirNomes_DeveAcabarcom()
        {
            // Arrange
            var sut = new StringsTools();

            // Act
            var nomeCompleto = sut.Unir("Fabio", "Macieira");

            // Assert
            Assert.EndsWith("eira", nomeCompleto);

        }

        [Fact]
        public void StringTools_UnirNomes_ValidarExpresaoRegular()
        {
            // Arrange
            var sut = new StringsTools();

            // Act
            var nomeCompleto = sut.Unir("Fabio", "Macieira");

            // Assert
            Assert.Matches("[A-Z]{1}[a-z] + [A-Z]{1}[a-z]+", nomeCompleto);

        }

    }
}
