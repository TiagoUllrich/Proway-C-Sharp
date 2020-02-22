using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cs20483_Exercicio.Domain.Entities
{
    public class PessoaFisica : Pessoa
    {
        public string Sobrenome { get; set; }
        public byte Idade { get; set; }
        public string Cpf { get; set; }
        public string Rg { get; set; }
    }
}
