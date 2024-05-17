using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Class1
{
    //class de tarefa que vai receber a descricao e a data de validade
    public class Tarefa
    {
        public string Descricao { get; set; }
        public DateTime DataVencimento { get; set; }

        public Tarefa(string descricao, DateTime dataVencimento)
        {
            Descricao = descricao;
            DataVencimento = dataVencimento;
        }
    }
}
