using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Its.Me.AleSeixas.SolidNET6.Ocp.Correto
{
    public interface IDesconto
    {
        decimal CalcularDesconto(Pedido pedido);
    }
}
