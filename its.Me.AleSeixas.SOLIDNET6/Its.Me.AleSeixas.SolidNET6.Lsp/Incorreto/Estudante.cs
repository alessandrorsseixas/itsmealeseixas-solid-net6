using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Its.Me.AleSeixas.SolidNET6.Lsp.Incorreto
{
    public class Estudante
    {
        public string Nome { get; set; }

        public Estudante(String nome)
        {
            this.Nome = nome;
        }

        public virtual void estudar()
        {
            Console.WriteLine($"{Nome} salvo no banco de dados.");
        }

        public virtual void entregarTCC()
        {
            Console.WriteLine($"{Nome} Entregou TCC.");
        }

    }
}
