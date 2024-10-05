using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Its.Me.AleSeixas.SolidNET6.Ocp.Correto
{
    public class DescontoClienteRegular : IDesconto
    {
        public decimal CalcularDesconto(Pedido pedido)
        {
            return pedido.Valor * 0.1m;
        }
    }

    public class DescontoClienteVIP : IDesconto
    {
        public decimal CalcularDesconto(Pedido pedido)
        {
            return pedido.Valor * 0.2m;
        }
    }

    public class DescontoClienteSuperVIP : IDesconto
    {
        public decimal CalcularDesconto(Pedido pedido)
        {
            return pedido.Valor * 0.3m;
        }
    }

}
