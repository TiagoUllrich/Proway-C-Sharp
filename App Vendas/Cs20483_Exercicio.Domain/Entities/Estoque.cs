using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cs20483_Exercicio.Domain.Entities
{
    public class Estoque : Base
    {
        public Produto Produto { get; set; }
        public short Quantidade { get; set; }
    }
}
