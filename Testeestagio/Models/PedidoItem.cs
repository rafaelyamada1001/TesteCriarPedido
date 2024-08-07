

namespace Testeestagio.Models
{
    public class PedidoItem
    {
        public int Sequencia { get; set; }
        public Produto Produto { get; set; }
        public int Quantidade { get; set; }
        public double ValorUnitario { get; set; }

        public PedidoItem(int sequencia, Produto produto, int quantidade, double valorunitario)
        {
            Sequencia = sequencia;
            Produto = produto;
            Quantidade = quantidade;
            ValorUnitario = valorunitario;
        }
    }
}
