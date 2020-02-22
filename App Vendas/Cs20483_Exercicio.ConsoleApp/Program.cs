using Cs20483_Exercicio.Data.Repository;
using Cs20483_Exercicio.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cs20483_Exercicio.ConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            ProdutoRepository repositorio = new ProdutoRepository();

            Produto produto = new Produto { Nome = "Nokia", Descricao = "Indestrutivel", 
                                            Codigo = "3004", PrecoUnitario = 1000.00M };

            //repositorio.Create(produto);

            //var prodUpdate = repositorio.GetById(2);
            //prodUpdate.Nome = "Iphone";
            //prodUpdate.Descricao = "Destrutível, sem bateria";
            //repositorio.Update(prodUpdate);
            repositorio.Delete(3);

            foreach (var item in repositorio.ListAll())
            {
                Console.WriteLine($"{item.Nome}, {item.Descricao}, {item.PrecoUnitario}");
            }

            Console.ReadLine();
        }
    }
}
