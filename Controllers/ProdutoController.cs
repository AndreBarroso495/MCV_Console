using System.Collections.Generic;
using MCV_Console.Models;
using MCV_Console.Views;

namespace MCV_Console.Controllers
{
    public class ProdutoController
    {

        Produto produto = new Produto();
        ProdutoView produtoView = new ProdutoView();

        public void MostrarProdutos()
        {

            List<Produto> todos = produto.Ler();
            produtoView.ListarTodos(todos);

        }

        public void Cadastrar()
        {
            produto.Inserir(produtoView.CadastrarProduto());
        }
    }
}