

namespace Testeestagio.Models
{
    public class Endereco
    {
        public string Logradouro { get; set; }
        public int Numero { get; set; }
        public string Municipio { get; set; }
        public string Uf {  get; set; }

        public Endereco(string logradouro, int numero, string municipio, string uf)
        {

            Logradouro = logradouro;
            Numero = numero;
            Municipio = municipio;
            Uf = uf;
        }
    }
}
