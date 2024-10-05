using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Its.Me.AleSeixas.SolidNET6.Srp.Correto
{
    public class EmailService
    {
        public void EnviarConfirmacao(Pedido pedido)
        {
            Console.WriteLine($"Email de confirmação enviado para o cliente sobre o pedido de {pedido.Produto}.");
        }
    }
}
