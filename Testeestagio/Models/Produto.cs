

using System.Security.Cryptography.X509Certificates;

namespace Testeestagio.Models
{
    public class Produto
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public int Estoque { get; set; }
        public double Valor { get; set; }

        public Produto(int id, string descricao, int estoque, double valor)
        {
            Id = id;
            Descricao = descricao;
            Estoque = estoque;
            Valor = valor;
        }
    }
}
