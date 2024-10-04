using CalculoCDB.Models;

namespace CalculoCDB.Services
{
    public class CDBService
    {
        private const decimal TaxaBanco = 1.08m; // 108%
        private const decimal CDI = 0.009m; // 0.9%

        public (decimal Bruto, decimal Liquido) CalcularCDB(ParametrosCDB investimento)
        {
            decimal valorFinalBruto = investimento.ValorInicial;

            for (int i = 0; i < investimento.Meses; i++)
            {
                valorFinalBruto *= (1 + (CDI * TaxaBanco));
            }

            decimal imposto = CalcularImposto(investimento.Meses, valorFinalBruto);
            decimal valorFinalLiquido = valorFinalBruto - imposto;

            return (valorFinalBruto, valorFinalLiquido);
        }

        private decimal CalcularImposto(int meses, decimal valorBruto)
        {
            decimal percentualImposto;

            if (meses <= 6)
                percentualImposto = 0.225m; // 22,5%
            else if (meses <= 12)
                percentualImposto = 0.20m; // 20%
            else if (meses <= 24)
                percentualImposto = 0.175m; // 17,5%
            else
                percentualImposto = 0.15m; // 15%

            return valorBruto * percentualImposto;
        }
    }
}
