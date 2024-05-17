using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exe06
{
    class Loja
    {
        private List<Produto> produtos = new List<Produto>();

        // Método para adicionar um produto à lista de produtos
        public void AdicionarProduto(Produto produto)
        {
            produtos.Add(produto);
        }

        // Método para exibir todos os produtos na lista
        public void ExibirProdutos()
        {
            Console.WriteLine("Produtos na loja:");
            foreach (Produto produto in produtos)
            {
                produto.ExibirInformacoes();
            }
        }

        // Método para consultar um produto pelo nome
        public Produto ConsultarProduto(string nome)
        {
            foreach (Produto produto in produtos)
            {
                if (produto.Nome == nome)
                {
                    return produto;
                }
            }
            return null;
        }
    }
}
