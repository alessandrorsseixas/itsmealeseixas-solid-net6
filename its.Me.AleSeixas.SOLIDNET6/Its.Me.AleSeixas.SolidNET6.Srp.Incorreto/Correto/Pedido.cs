using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Its.Me.AleSeixas.SolidNET6.Srp.Correto
{
    public class Pedido
    {
        public int Id { get; set; }
        public string Produto { get; set; }
        public int Quantidade { get; set; }
        public Pedido(string produto ,int quantidade)
        {
            Produto = produto;
            Quantidade = quantidade;
        }
        public void AdicionarPedido()
        {
            Console.WriteLine($"Pedido de {Produto} com quantidade {Quantidade} adicionado.");
        }
    }

}
