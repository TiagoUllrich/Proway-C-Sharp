using Cs20483_Exercicio.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cs20483_Exercicio.Data.Context
{
    public class Cs20483Context : DbContext
    {
        //Propriedade do tipo DbSet que irá gerar uma nova tabela no banco de dados
        //A tabela será gerada de acordo com as propriedades da classe de domínio
        public DbSet<Produto> Produto { get; set; }
        public DbSet<Estoque> Estoque { get; set; }
        public DbSet<PessoaFisica> PessoaFisica { get; set; }
        public DbSet<PessoaJuridica> PessoaJuridica { get; set; }


        //A classe do banco deve ter um construtor que usa o comando base chamando a classe mãe que é a DbContext 
        //E entre parênteses deve ter o caminho do banco conforme as propriedades dele.
        public Cs20483Context():base(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\67375\Documents\Cs20483-master\Cs20483_Exercicio\Cs20483_Exercicio.Data\Database\Cs20483Database.mdf;Integrated Security=True")
        {

        }
        
    }
}
