using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cs20483_Exercicio.Domain.Entities
{
    public class Produto : Base
    {
        public string Nome { get; set; }
        public decimal PrecoUnitario { get; set; }
        public string Descricao { get; set; }
        public string Codigo { get; set; }
    }
}
