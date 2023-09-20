using HerancaPolimorfismo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneralizacaoPolimorfismo
{
    internal class FuncionarioN1 : Pai
    {

        public FuncionarioN1() { }
        public double participacaoLucro()
        {
            return 1200 * 0.2;
        }

    }
}
