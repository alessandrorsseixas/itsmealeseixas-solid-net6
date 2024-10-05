using Its.Me.AleSeixas.SolidNET6.Lsp.Correto;
using Its.Me.AleSeixas.SolidNET6.Lsp.Incorreto;

Console.WriteLine("Uso Correto do LSP.");
string nome = "Alessandro";
Its.Me.AleSeixas.SolidNET6.Lsp.Correto.Estudante estudante = new Its.Me.AleSeixas.SolidNET6.Lsp.Correto.Estudante(nome);
estudante.estudar();

EstudanteGraduacao estudanteGraduacao = new EstudanteGraduacao(nome);
estudanteGraduacao.estudar();
estudanteGraduacao.entregarTCC();

Console.WriteLine("Uso Incorreto do LSP.");
nome = "Alessandro";
Its.Me.AleSeixas.SolidNET6.Lsp.Incorreto.Estudante estudante1 = new Its.Me.AleSeixas.SolidNET6.Lsp.Incorreto.Estudante(nome);
estudante1.estudar();
estudante1.entregarTCC();

EstudanteMestrado estudanteMestrado = new EstudanteMestrado(nome);
estudanteMestrado.estudar();
estudanteMestrado.entregarTCC();

Console.WriteLine("");

