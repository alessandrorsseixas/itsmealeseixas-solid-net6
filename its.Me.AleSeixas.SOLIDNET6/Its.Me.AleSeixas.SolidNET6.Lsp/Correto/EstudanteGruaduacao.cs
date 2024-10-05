using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Its.Me.AleSeixas.SolidNET6.Lsp.Correto
{
    public class EstudanteGraduacao:Estudante
    {
        public EstudanteGraduacao(string nome) : base(nome)
        {
            base.Nome = nome;
        }

        public override void estudar()
        {
            Console.WriteLine($"{base.Nome} Estudando Graduação.");
        }

        public void entregarTCC()
        {
            Console.WriteLine($"{base.Nome} Entregou o TCC.");
        }

    }
}
