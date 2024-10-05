using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Its.Me.AleSeixas.SolidNET6.Isp.Correto
{
    public interface ITrabalho
    {
        void Trabalhar();
    }

    public interface IFolga
    {
        void TirarFolga();
    }

    public interface IGerencia
    {
        void GerenciarEquipe();
    }

    public class Desenvolvedor : ITrabalho, IFolga
    {
        public void Trabalhar()
        {
            Console.WriteLine("Desenvolvedor está escrevendo código.");
        }

        public void TirarFolga()
        {
            Console.WriteLine("Desenvolvedor está tirando folga.");
        }
    }

    public class Gerente : ITrabalho, IFolga, IGerencia
    {
        public void Trabalhar()
        {
            Console.WriteLine("Gerente está gerenciando o projeto.");
        }

        public void TirarFolga()
        {
            Console.WriteLine("Gerente está tirando folga.");
        }

        public void GerenciarEquipe()
        {
            Console.WriteLine("Gerente está gerenciando a equipe.");
        }
    }
}
