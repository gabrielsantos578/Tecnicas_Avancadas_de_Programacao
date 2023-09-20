using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerancaPolimorfismo
{
    internal class FuncionarioN2 : Pai
    {
        public int? Idade { get; set; }

        public FuncionarioN2() { }
        public double participacaoLucro()
        {
            return 1200 * 0.3;
        }
    }
}
