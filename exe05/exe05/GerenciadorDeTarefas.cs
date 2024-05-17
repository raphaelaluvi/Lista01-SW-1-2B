using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exe05
{
   

    public class GerenciadorDeTarefas
    {
        private List<Tarefa> listaDeTarefas;

        //construtor que vai criar uma lista, chamando a class tarefa dentro do List
        public GerenciadorDeTarefas()
        {
            listaDeTarefas = new List<Tarefa>();
        }

        //metodo q vai adicionar, parametros: descricao e vencimento
        public void AdicionarTarefa(string descricao, DateTime dataVencimento)
        {
            Tarefa novaTarefa = new Tarefa(descricao, dataVencimento);
            //adiciona
            listaDeTarefas.Add(novaTarefa);
        }

        //remove
        public void RemoverTarefa(string descricao)
        {
            //armazena a descricao na variavel tarefa
            Tarefa tarefa = listaDeTarefas.Find(t => t.Descricao == descricao);
            //se tiver faca:
            if (tarefa != null)
            {
                listaDeTarefas.Remove(tarefa);
                Console.WriteLine("Tarefa removida: " + descricao);
            }
            else
            {
                Console.WriteLine("Tarefa não encontrada: " + descricao);
            }
        }

        //vai listar
        public void ListarTarefas()
        {
            if (listaDeTarefas.Count == 0)
            {
                Console.WriteLine("Não há tarefas na lista.");
            }
            else
            {
                //vai passar em cada tarefa
                foreach (var tarefa in listaDeTarefas)
                {
                    Console.WriteLine($"- {tarefa.Descricao}, Vencimento: {tarefa.DataVencimento.ToShortDateString()}");
                }
            }
        }

        //verifica
        public void VerificarTarefasParaHoje()
        {
            //armazena a data de hoje
            DateTime hoje = DateTime.Today;
            //vai procurar a data de vencimento para ver se é igual a de hoje e armazenar para tarefasParaHoje
            List<Tarefa> tarefasParaHoje = listaDeTarefas.FindAll(t => t.DataVencimento.Date == hoje);

            if (tarefasParaHoje.Count == 0)
            {
                Console.WriteLine("Não há tarefas para hoje.");
            }
            else
            {
                //vai percorrer em cada tarefa
                foreach (var tarefa in tarefasParaHoje)
                {
                    Console.WriteLine($"- {tarefa.Descricao}");
                }
            }
        }
    }
}
