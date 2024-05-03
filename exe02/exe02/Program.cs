namespace exe02
{
    class Program
    {
        static void Main(string[] args)
        {
            //criando a instancia da classe
            RegistroDeCompras registro = new RegistroDeCompras();

            // Adicionando algumas compras
            //Compra novaCompra = new Compra { Data = data, Produto = produto, Valor = valor };
            registro.AdicionarCompra(new DateTime(2024, 4, 25), "Camisa", 49.99);
            registro.AdicionarCompra(new DateTime(2024, 4, 26), "Calça Jeans", 79.99);
            registro.AdicionarCompra(new DateTime(2024, 4, 27), "Tênis", 99.99);

            // ta chamando o metodo de listar as compras
            registro.ListarCompras();
        }
    }
}