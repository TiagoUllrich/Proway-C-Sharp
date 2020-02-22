using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cs20483_Exercicio.Domain.Entities
{
    public class PessoaJuridica : Pessoa
    {
        public string CNPJ { get; set; }
        public string InscricaoEstadual { get; set; }
    }
}
