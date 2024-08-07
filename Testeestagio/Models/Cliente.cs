

using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Testeestagio.Models
{
    public class Cliente : Endereco
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }

        public Cliente(int id, string nome, int idade, string logradouro, int numero, string municipio, string uf) 
            : base (logradouro, numero, municipio, uf)
        {
            Id = id;
            Nome = nome;
            Idade = idade;
            Logradouro = logradouro;
            Numero = numero;
            Municipio = municipio;
            Uf = uf;
        }
    }
}
