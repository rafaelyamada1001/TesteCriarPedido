

namespace Testeestagio.Models
{
    public class PedidoCabecalho
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }

        public Cliente Cliente { get; set; }
        public double ValorTotal { get; set; }
        public List<PedidoItem> Itens { get; set; }

        public PedidoCabecalho(int id, DateTime data, Cliente cliente, double valortotal, List<PedidoItem> itens)
        {
            Id = id;
            Data = data;
            Cliente = cliente;
            ValorTotal = valortotal;
            Itens = itens;
        }
    }

}
