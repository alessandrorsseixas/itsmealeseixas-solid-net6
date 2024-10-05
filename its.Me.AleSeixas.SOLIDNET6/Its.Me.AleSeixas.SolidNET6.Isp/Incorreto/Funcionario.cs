using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Its.Me.AleSeixas.SolidNET6.Isp.Incorreto
{
    public interface IAcaoFuncionario
    {
        void Trabalhar();
        void TirarFolga();
        void GerenciarEquipe();
    }

    public class Desenvolvedor : IAcaoFuncionario
    {
        public void Trabalhar()
        {
            Console.WriteLine("Desenvolvedor está escrevendo código.");
        }

        public void TirarFolga()
        {
            Console.WriteLine("Desenvolvedor está tirando folga.");
        }

        public void GerenciarEquipe()
        {
            // Desenvolvedor não gerencia equipe, mas é forçado a implementar.
            throw new NotImplementedException();
        }
    }
}
