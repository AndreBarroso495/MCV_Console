using System;
using System.Collections.Generic;
using MCV_Console.Models;

namespace MCV_Console.Views
{
    public class ProdutoView
    {
        public void ListarTodos(List<Produto> produtos)
       {
           foreach (Produto item in produtos)
           {
               Console.WriteLine($"Código : {item.Codigo}");
               Console.WriteLine($"Nome : {item.Nome}");
               Console.WriteLine($"Preço : R$ {item.Preco}");
               Console.WriteLine();
           }
       }

       public Produto CadastrarProduto()
       {
           Produto produto = new Produto();

           Console.WriteLine($"Digite o código do produto: ");
           produto.Codigo = int.Parse(Console.ReadLine());

           Console.WriteLine($"Digite  o nome do produto:");
           produto.Nome = Console.ReadLine();
           
           Console.WriteLine($"Digite o preço do produto:");
           produto.Preco = float.Parse(Console.ReadLine());

           return produto;
       }
    }
}