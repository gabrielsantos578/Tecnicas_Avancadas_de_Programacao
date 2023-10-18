using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_HerancaPolimorfismo
{
    internal class Empresarial : Veiculo
    {
        public double? CapacidadePesoEmpresarial { get; set; }

        public int? QuantidadeEixosEmpresarial { get; set; }

        public override double DescontoVeiculo(int PorcentagemDesconto)
        {
            return (double)(((ValorVeiculo * (PorcentagemDesconto / 100)) + (ValorVeiculo * 0.07)));
        }

    }
}
