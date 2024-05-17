using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exe04
{
    

    class AgendaTelefonica
    {
        private List<Contato> contatos = new List<Contato>();

        // Método para adicionar um contato à lista
        public void AdicionarContato(string nome, string telefone, string email)
        {
            Contato novoContato = new Contato(nome, telefone, email);
            contatos.Add(novoContato);
            Console.WriteLine("Contato adicionado com sucesso!");
        }

        // Método para remover um contato da lista
        public void RemoverContato(string nome)
        {
            Contato contato = contatos.Find(c => c.Nome == nome);
            if (contato != null)
            {
                contatos.Remove(contato);
                Console.WriteLine("Contato removido com sucesso!");
            }
            else
            {
                Console.WriteLine("Contato não encontrado.");
            }
        }
        // Método para buscar um contato na lista
        public Contato BuscarContato(string nome)
        {
            return contatos.Find(c => c.Nome == nome);
        }
    }
}
