using CalculoCDB.Models;
using CalculoCDB.Services;

namespace XUnitTestProject.Testes
{
    public class CDBServiceTest
    {
        private readonly CDBService _cdbService;

        public CDBServiceTest()
        {
            _cdbService = new CDBService();
        }

        [Theory]
        [InlineData(1000, 6)]
        [InlineData(1000, 12)]
        [InlineData(1000, 24)]
        [InlineData(1000, 36)]
        public void CalcularCDB_ValorPositivo_ReturnsExpectedResult(decimal valorInicial, int meses)
        {
            // Act
            var (bruto, liquido) = _cdbService.CalcularCDB(new ParametrosCDB { ValorInicial = valorInicial, Meses = meses });

            // Assert
            Assert.True(bruto > 0);
            Assert.True(liquido >= 0);
        }

        [Fact]
        public void CalcularCDB_ValorInicialZero_ReturnsExpectedResult()
        {
            // Act
            var (bruto, liquido) = _cdbService.CalcularCDB(new ParametrosCDB { ValorInicial = 0, Meses = 12 });

            // Assert
            Assert.Equal(0, bruto);
            Assert.Equal(0, liquido);
        }

        [Fact]
        public void CalcularCDB_MesesZero_ReturnsExpectedResult()
        {
            // Act
            var (bruto, liquido) = _cdbService.CalcularCDB(new ParametrosCDB { ValorInicial = 1000, Meses = 0 });

            // Assert
            Assert.Equal(1000, bruto);
            Assert.Equal(1000, liquido);
        }

        [Theory]
        [InlineData(1000, 6, 1.082634)] // Valor esperado bruto para 6 meses
        [InlineData(1000, 12, 1.182464)] // Valor esperado bruto para 12 meses
        [InlineData(1000, 24, 1.345912)] // Valor esperado bruto para 24 meses
        [InlineData(1000, 36, 1.473811)] // Valor esperado bruto para 36 meses
        public void CalcularCDB_CalculoBrutoCorreto(decimal valorInicial, int meses, decimal valorEsperadoBruto)
        {
            // Act
            var (bruto, liquido) = _cdbService.CalcularCDB(new ParametrosCDB { ValorInicial = valorInicial, Meses = meses });

            // Assert
            Assert.InRange(bruto, valorEsperadoBruto - 0.01m, valorEsperadoBruto + 0.01m); // Tolerância de 0.01
        }

        [Theory]
        [InlineData(1000, 6, 0.225)] // Imposto de 22,5%
        [InlineData(1000, 12, 0.20)] // Imposto de 20%
        [InlineData(1000, 24, 0.175)] // Imposto de 17,5%
        [InlineData(1000, 36, 0.15)] // Imposto de 15%
        public void CalcularCDB_CalculoImpostoCorreto(decimal valorInicial, int meses, decimal percentualImposto)
        {
            // Act
            var (bruto, liquido) = _cdbService.CalcularCDB(new ParametrosCDB { ValorInicial = valorInicial, Meses = meses });

            // Assert
            var valorImposto = bruto * percentualImposto;
            Assert.Equal(valorImposto, bruto - liquido);
        }
    }
}
