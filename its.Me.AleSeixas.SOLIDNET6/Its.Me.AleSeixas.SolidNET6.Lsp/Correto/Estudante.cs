using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Its.Me.AleSeixas.SolidNET6.Lsp.Correto
{
    public class Estudante
    {
        public String Nome { get; set;}

        public Estudante(String nome)
        {
            this.Nome = nome;
        }

        public virtual void estudar()
        {
            Console.WriteLine($"{Nome} Está estudando Ensino Médio.");
        }


      
    }
}
