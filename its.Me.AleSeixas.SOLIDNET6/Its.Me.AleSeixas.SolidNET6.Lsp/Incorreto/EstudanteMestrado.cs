using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Its.Me.AleSeixas.SolidNET6.Lsp.Incorreto
{
    public class EstudanteMestrado:Estudante
    {
        public EstudanteMestrado(string nome) : base(nome)
        {
            base.Nome = nome;
        }

        public override void estudar()
        {
            Console.WriteLine($"{base.Nome} Estudando Graduação.");
        }

        public override void entregarTCC()
        {
           throw new NotImplementedException("Estudantes de Mestrado não entregam TCC");
        }

    }
}
