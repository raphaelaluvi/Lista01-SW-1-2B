using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exe03
{
    //criando o imovel
    class Imovel
    {
        public string Endereco { get; set; }
        public double Preco { get; set; }
        public string Tipo { get; set; }

        public Imovel(string endereco, double preco, string tipo)
        {
            Endereco = endereco;
            Preco = preco;
            Tipo = tipo;
        }
    }

    //construtor:
    class CorretoraDeImoveis
    {
        //lista dos imoveis
        private List<Imovel> imoveis = new List<Imovel>();

        public void InserirImovel(string endereco, double preco, string tipo)
        {
            Imovel imovel = new Imovel(endereco, preco, tipo);
            //adiciona
            imoveis.Add(imovel);
            Console.WriteLine("Imóvel inserido com sucesso!");
        }

        public void AlterarPreco(string endereco, double novoPreco)
        {
            Imovel imovel = imoveis.Find(i => i.Endereco == endereco);
            if (imovel != null)
            {
                //muda o preco, substitui
                imovel.Preco = novoPreco;
                Console.WriteLine("Preço do imóvel alterado com sucesso!");
            }
            else
            {
                Console.WriteLine("Imóvel não encontrado.");
            }
        }

        public void ListarImoveisDisponiveis()
        {
            if (imoveis.Count == 0)
            {
                Console.WriteLine("Não há imóveis disponíveis.");
            }
            else
            {
                Console.WriteLine("Imóveis disponíveis:");
                //seria o for
                foreach (Imovel imovel in imoveis)
                {
                    Console.WriteLine($"Endereço: {imovel.Endereco}, Preço: {imovel.Preco}, Tipo: {imovel.Tipo}");
                }
            }
        }

        public double CalcularValorMedio()
        {
            if (imoveis.Count == 0)
            {
                return 0;
            }
            else
            {
                double somaPrecos = 0;
                foreach (Imovel imovel in imoveis)
                {
                    //adiona ao somaprecos o valor do imovel
                    somaPrecos += imovel.Preco;
                }
                //vai retornar o valor medio
                return somaPrecos / imoveis.Count;
            }
        }
    }
}
