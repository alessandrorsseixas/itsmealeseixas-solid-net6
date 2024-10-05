using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Its.Me.AleSeixas.SolidNET6.Ocp.Incorreto
{
    public class Pedido
    {
        public string Cliente { get; set; }
        public decimal Valor { get; set; }
        public string TipoCliente { get; set; }

        public Pedido(string cliente, decimal valor, string tipoCliente)
        {
            Cliente = cliente;
            Valor = valor;
            TipoCliente = tipoCliente;
        }

        public decimal CalcularDesconto()
        {
            if (TipoCliente == "Regular")
            {
                return Valor * 0.1m;
            }
            else if (TipoCliente == "VIP")
            {
                return Valor * 0.2m;
            }
            else if (TipoCliente == "SuperVIP")
            {
                return Valor * 0.3m;
            }
            else
            {
                return 0;
            }
        }
    }

}
