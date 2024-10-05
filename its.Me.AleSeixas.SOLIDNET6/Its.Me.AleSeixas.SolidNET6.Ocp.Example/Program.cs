// See https://aka.ms/new-console-template for more information
using Its.Me.AleSeixas.SolidNET6.Ocp.Correto;

Console.WriteLine("Uso Incorreto do OCP.");
var cliente1 = "Cliente 1";
var valor1 = 1000m;
var tipoCliente1 = "Regular";
var cliente2 = "Cliente 2";
var valor2 = 2000m;
var tipoCliente2 = "VIP";
var cliente3 = "Cliente 3";
var tipoCliente3 = "SuperVIP";
var valor3 = 3000m;
Its.Me.AleSeixas.SolidNET6.Ocp.Incorreto.Pedido pedido1 = new Its.Me.AleSeixas.SolidNET6.Ocp.Incorreto.Pedido
                                                              (cliente1,valor1,tipoCliente1);
Its.Me.AleSeixas.SolidNET6.Ocp.Incorreto.Pedido pedido2 = new Its.Me.AleSeixas.SolidNET6.Ocp.Incorreto.Pedido
                                                              (cliente2,valor2,tipoCliente2);
Its.Me.AleSeixas.SolidNET6.Ocp.Incorreto.Pedido pedido3 = new Its.Me.AleSeixas.SolidNET6.Ocp.Incorreto.Pedido
                                                              (cliente3, valor3, tipoCliente3);

Console.WriteLine($"Desconto para Cliente {pedido1.TipoCliente}: {pedido1.CalcularDesconto()}");
Console.WriteLine($"Desconto para Cliente {pedido2.TipoCliente}: {pedido2.CalcularDesconto()}");
Console.WriteLine($"Desconto para Cliente {pedido3.TipoCliente}: {pedido3.CalcularDesconto()}");

Console.WriteLine("");
Console.WriteLine("Uso Correto do OCP.");

var pedidoRegular = new Its.Me.AleSeixas.SolidNET6.Ocp.Correto.Pedido("Cliente 1", 1000m, new DescontoClienteRegular());
Console.WriteLine($"Desconto para Cliente Regular: {pedidoRegular.ObterDesconto()}");

var pedidoVIP = new Its.Me.AleSeixas.SolidNET6.Ocp.Correto.Pedido("Cliente 2", 2000m, new DescontoClienteVIP());
Console.WriteLine($"Desconto para Cliente VIP: {pedidoVIP.ObterDesconto()}");

var pedidoSuperVIP = new Its.Me.AleSeixas.SolidNET6.Ocp.Correto.Pedido("Cliente 3", 3000m, new DescontoClienteSuperVIP());
Console.WriteLine($"Desconto para Cliente SuperVIP: {pedidoSuperVIP.ObterDesconto()}");
