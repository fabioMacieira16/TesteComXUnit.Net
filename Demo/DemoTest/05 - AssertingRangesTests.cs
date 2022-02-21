using Demo;
using Xunit;

namespace DemoTest
{
    public class AssertingRangesTests
    {
        [Theory]
        [InlineData(700)]
        [InlineData(1500)]
        [InlineData(2000)]
        [InlineData(7500)]
        [InlineData(8000)]
        [InlineData(15000)]

        public void Funcionario_Salario_FaixasSalarioaisDevemReitarNivelProfissional(double salario)
        {
            //Arrange & Act
            var funcionario = new Funcionario("Fabio", salario);

            // Assert
            if (funcionario.NivelProfisional == NivelProfissional.Junio)
                Assert.InRange(funcionario.Salario, 500, 1999);

            if (funcionario.NivelProfisional == NivelProfissional.Pleno)
                Assert.InRange(funcionario.Salario, 2000, 7999);

            if (funcionario.NivelProfisional == NivelProfissional.Senior)
                Assert.InRange(funcionario.Salario, 8000, double.MaxValue);

                Assert.NotInRange(funcionario.Salario, 0, 499);


        }
    }
}
