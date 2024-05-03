using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exe02
{
    class RegistroDeCompras
    {
        // aqui o struct esta definindo essa estrutura das compras
        public struct Compra
        {
            public DateTime Data;
            public string Produto;
            public double Valor;
        }

        // vai armazenar as compras em uma lista
        private List<Compra> compras;

        // o construtor, tem o mesmo nome q a classe
        public RegistroDeCompras()
        {
            // Inicializa a lista de compras
            compras = new List<Compra>();
        }

        //esse metodo va adicionar uma nova compra
        public void AdicionarCompra(DateTime data, string produto, double valor)
        {
            Compra novaCompra = new Compra { Data = data, Produto = produto, Valor = valor };
            compras.Add(novaCompra);
        }

        //metodo que lista as compra registradas

        public void ListarCompras()
        {
            if (compras.Count == 0)
            {
                Console.WriteLine("Não há compras registradas.");
                return;
            }


            //foreach é um recurso do C# que possibilita executar um conjunto de comandos para cada elemento presente em uma lista
            Console.WriteLine("Registro de Compras:");
            foreach (var compra in compras)
            {
                Console.WriteLine($"Data: {compra.Data.ToShortDateString()}, Produto: {compra.Produto}, Valor: {compra.Valor}");
            }
        }
    }

}
