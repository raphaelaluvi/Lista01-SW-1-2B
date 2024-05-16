namespace exe06
{
    class Program
    {
        static void Main(string[] args)
        {
            // Criando alguns produtos
            Produto produto1 = new Produto("Camiseta", 29.99, 50);
            Produto produto2 = new Produto("Calça Jeans", 59.99, 30);

            // Criando a loja
            Loja loja = new Loja();

            // Adicionando produtos à loja
            loja.AdicionarProduto(produto1);
            loja.AdicionarProduto(produto2);

            // Exibindo produtos na loja
            loja.ExibirProdutos();

            // Consultando produto pelo nome
            Produto produtoConsultado = loja.ConsultarProduto("Camiseta");
            if (produtoConsultado != null)
            {
                Console.WriteLine("\nProduto encontrado:");
                produtoConsultado.ExibirInformacoes();
            }
            else
            {
                Console.WriteLine("\nProduto não encontrado na loja.");
            }
        }
    }
}