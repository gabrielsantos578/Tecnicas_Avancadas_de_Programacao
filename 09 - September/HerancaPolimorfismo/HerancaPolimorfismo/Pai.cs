using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerancaPolimorfismo
{
    internal class Pai
    {
        public string? Nome { get; set; }
        public string? Sexo { get; set; }

        public Pai() { }
        public virtual double participacaoLucro()
        {
            return 1200 * 0.25;
        }
    }
}
