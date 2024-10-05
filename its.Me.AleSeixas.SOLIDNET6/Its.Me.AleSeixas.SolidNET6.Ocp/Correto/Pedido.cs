using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Its.Me.AleSeixas.SolidNET6.Ocp.Correto
{
    public class Pedido
    {
        public string Cliente { get; set; }
        public decimal Valor { get; set; }
        private readonly IDesconto _desconto;

        public Pedido(string cliente, decimal valor, IDesconto desconto)
        {
            Cliente = cliente;
            Valor = valor;
            _desconto = desconto;
        }

        public decimal ObterDesconto()
        {
            return _desconto.CalcularDesconto(this);
        }
    }

}
