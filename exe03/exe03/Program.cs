namespace exe03
{
    class Program
    {
        static void Main(string[] args)
        {
            CorretoraDeImoveis corretora = new CorretoraDeImoveis();
            int opcao;

            do
            {
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1. Inserir Imóvel");
                Console.WriteLine("2. Alterar Preço do Imóvel");
                Console.WriteLine("3. Listar Imóveis Disponíveis");
                Console.WriteLine("4. Calcular Valor Médio dos Imóveis");
                Console.WriteLine("5. Sair");
                Console.Write("Escolha uma opção: ");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.Write("\nEndereço do Imóvel: ");
                        string endereco = Console.ReadLine();
                        Console.Write("Preço do Imóvel: ");
                        double preco = double.Parse(Console.ReadLine());
                        Console.Write("Tipo do Imóvel: ");
                        string tipo = Console.ReadLine();
                        corretora.InserirImovel(endereco, preco, tipo);
                        break;
                    case 2:
                        Console.Write("\nEndereço do Imóvel para Alteração de Preço: ");
                        endereco = Console.ReadLine();
                        Console.Write("Novo Preço do Imóvel: ");
                        double novoPreco = double.Parse(Console.ReadLine());
                        corretora.AlterarPreco(endereco, novoPreco);
                        break;
                    case 3:
                        Console.WriteLine();
                        corretora.ListarImoveisDisponiveis();
                        break;
                    case 4:
                        double valorMedio = corretora.CalcularValorMedio();
                        Console.WriteLine($"\nO valor médio dos imóveis é: {valorMedio}");
                        break;
                    case 5:
                        Console.WriteLine("\nSaindo...");
                        break;
                    default:
                        Console.WriteLine("\nOpção inválida. Tente novamente.");
                        break;
                }
            } while (opcao != 5);
        }
    }
}