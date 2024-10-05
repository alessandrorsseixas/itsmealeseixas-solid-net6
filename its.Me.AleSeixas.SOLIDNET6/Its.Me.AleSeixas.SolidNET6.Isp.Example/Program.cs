

using Its.Me.AleSeixas.SolidNET6.Isp.Correto;

Console.WriteLine("Uso Correto do LSP.");
Its.Me.AleSeixas.SolidNET6.Isp.Correto.Desenvolvedor desenvolvedor = new Its.Me.AleSeixas.SolidNET6.Isp.Correto.Desenvolvedor();
desenvolvedor.Trabalhar();
desenvolvedor.TirarFolga();
Gerente gerente = new Gerente();
gerente.Trabalhar();
gerente.TirarFolga();
gerente.GerenciarEquipe();



Console.WriteLine("Uso Incorreto do LSP.");
Its.Me.AleSeixas.SolidNET6.Isp.Incorreto.Desenvolvedor desenvolvedorIncorreto = new Its.Me.AleSeixas.SolidNET6.Isp.Incorreto.Desenvolvedor();
desenvolvedorIncorreto.Trabalhar();
desenvolvedorIncorreto.TirarFolga();
desenvolvedorIncorreto.GerenciarEquipe();
