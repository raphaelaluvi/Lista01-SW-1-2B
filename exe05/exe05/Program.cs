namespace exe05
{
    class Program
    {
        static void Main(string[] args)
        {
            //chama a class
            GerenciadorDeTarefas gerenciador = new GerenciadorDeTarefas();

            //adiona passando os parametros na ordem
            gerenciador.AdicionarTarefa("Estudar C#", new DateTime(2024, 5, 15));
            gerenciador.AdicionarTarefa("Fazer compras", new DateTime(2024, 5, 16));
            gerenciador.AdicionarTarefa("Enviar relatório", new DateTime(2024, 5, 15));

            //lista
            Console.WriteLine("Lista de Tarefas:");
            gerenciador.ListarTarefas();

            //tarefas de hoje
            Console.WriteLine("\nTarefas para hoje:");
            gerenciador.VerificarTarefasParaHoje();

            //remove a tarefa, passa o parametro de descricao
            gerenciador.RemoverTarefa("Estudar C#");

            Console.WriteLine("\nLista de Tarefas atualizada:");
            gerenciador.ListarTarefas();
        }
    }
}