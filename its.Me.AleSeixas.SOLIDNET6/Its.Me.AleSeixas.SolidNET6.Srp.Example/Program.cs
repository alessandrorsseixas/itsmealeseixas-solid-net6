// See https://aka.ms/new-console-template for more information
using Its.Me.AleSeixas.SolidNET6.Srp.Correto;
using Its.Me.AleSeixas.SolidNET6.Srp.Incorreto;

Console.WriteLine("Uso Incorreto do SRP.");
var produto = "teste1";
var quantidade = 1;
Its.Me.AleSeixas.SolidNET6.Srp.Incorreto.Pedido pedidoSrpIncorreto = new Its.Me.AleSeixas.SolidNET6.Srp.Incorreto.Pedido();
pedidoSrpIncorreto.AdicionarPedido(produto, quantidade);
pedidoSrpIncorreto.SalvarPedido();
pedidoSrpIncorreto.EnviarEmailConfirmacao();

Console.WriteLine("");
Console.WriteLine("Uso Correto do SRP.");

var pedidoCorreto = new Its.Me.AleSeixas.SolidNET6.Srp.Correto.Pedido(produto, quantidade);
var pedidoRepository = new PedidoRepository();
var emailService = new EmailService();

var pedidoService = new PedidoService(pedidoRepository, emailService);
pedidoService.ProcessarPedido(pedidoCorreto);






