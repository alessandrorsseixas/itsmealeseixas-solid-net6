namespace Its.Me.AleSeixas.SolidNET6.Srp.Incorreto
{
    /*Exemplo Sem SRP
        Aqui, a classe Pedido é responsável por gerenciar a lógica do pedido, 
        persistir dados e notificar o cliente. 
        Isso viola o SRP, pois a classe Pedido tem mais de uma responsabilidade.
    
    Problemas:
        Pedido está gerenciando três responsabilidades diferentes:
        Gerenciar o pedido (lógica de negócio).
        Persistir o pedido (salvar no banco de dados).
        Enviar uma confirmação (notificar o cliente).

     */
    public class Pedido
    {
        public int Id { get; set; }
        public string Produto { get; set; }
        public int Quantidade { get; set; }



        public void AdicionarPedido(string produto, int quantidade)
        {
            Produto = produto;
            Quantidade = quantidade;
            Console.WriteLine($"Pedido de {Produto} com quantidade {Quantidade} adicionado.");
        }
        public void SalvarPedido()
        {
            // Violação do SRP: responsabilidade de persistência de dados
            Console.WriteLine("Pedido salvo no banco de dados.");
        }

        public void EnviarEmailConfirmacao()
        {
            // Violação do SRP: responsabilidade de envio de email
            Console.WriteLine("Email de confirmação enviado para o cliente.");
        }
    }
}