namespace exe04
{
    class Program
    {
        static void Main(string[] args)
        {
            //ta "chamando" a class
            AgendaTelefonica agenda = new AgendaTelefonica();

            // Adicionando alguns contatos para testar
            agenda.AdicionarContato("João", "123456789", "joao@example.com");
            agenda.AdicionarContato("Maria", "987654321", "maria@example.com");

            // Removendo um contato
            agenda.RemoverContato("Maria");

            // Buscando um contato
            Contato contatoEncontrado = agenda.BuscarContato("João");
            if (contatoEncontrado != null)
            {
                Console.WriteLine($"Contato encontrado: {contatoEncontrado.Nome}, {contatoEncontrado.Telefone}, {contatoEncontrado.Email}");
            }
            else
            {
                Console.WriteLine("Contato não encontrado.");
            }
        }
    }
}