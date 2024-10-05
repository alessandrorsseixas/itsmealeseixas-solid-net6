using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Its.Me.AleSeixas.SolidNET6.Srp.Correto
{
    public class PedidoService
    {
        private readonly PedidoRepository _pedidoRepository;
        private readonly EmailService _emailService;

        public PedidoService(PedidoRepository pedidoRepository, EmailService emailService)
        {
            _pedidoRepository = pedidoRepository;
            _emailService = emailService;
        }

        public void ProcessarPedido(Pedido pedido)
        {
            pedido.AdicionarPedido();
            _pedidoRepository.Salvar(pedido);
            _emailService.EnviarConfirmacao(pedido);
        }
    }
}
