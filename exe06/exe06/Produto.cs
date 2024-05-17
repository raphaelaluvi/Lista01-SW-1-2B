using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exe06
{
    class Produto
    {
        // Atributos
        public string Nome { get; set; }
        public double Preco { get; set; }
        public int QuantidadeEmEstoque { get; set; }

        // Construtor
        public Produto(string nome, double preco, int quantidadeEmEstoque)
        {
            Nome = nome;
            Preco = preco;
            QuantidadeEmEstoque = quantidadeEmEstoque;
        }

        // Método para adicionar itens ao estoque
        public void AdicionarEstoque(int quantidade)
        {
            QuantidadeEmEstoque += quantidade;
        }

        // Método para remover itens do estoque
        public void RemoverEstoque(int quantidade)
        {
            if (QuantidadeEmEstoque >= quantidade)
            {
                QuantidadeEmEstoque -= quantidade;
            }
            else
            {
                Console.WriteLine("Quantidade insuficiente em estoque.");
            }
        }

        // Método para exibir informações do produto
        public void ExibirInformacoes()
        {
            Console.WriteLine($"Nome: {Nome}, Preço: {Preco:C}, Quantidade em estoque: {QuantidadeEmEstoque}");
        }
    }
}
