using System;
using MCV_Console.Controllers;
using MCV_Console.Models;

namespace MCV_Console
{
    class Program
    {
        static void Main(string[] args)
        {
           ProdutoController produtoController = new ProdutoController();

           produtoController.Cadastrar();
           
           produtoController.MostrarProdutos();
        }
    }
}
