using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_HerancaPolimorfismo
{
    internal class Veiculo
    {
        public string? MarcaVeiculo { get; set; }
        public string? ModeloVeiculo { get; set; }
        public double? ValorVeiculo { get; set; }

        public virtual double DescontoVeiculo(int PorcentagemDesconto)
        {
            return (double)(ValorVeiculo * (PorcentagemDesconto / 100));
        }

        public virtual double NovoValor(double Desconto)
        {
            return (double)(ValorVeiculo - Desconto);
        }

    }
}
