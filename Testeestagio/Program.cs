using System;
using Testeestagio.Models;

void CriarPedido()
{
    Cliente cliente = new Cliente(1, "Rafael", 20, "Av Nossa Senhora", 220, "Sertãozinho", "SP");


    Produto x = new Produto(1, "Tv 32 polegadas", 5, 1500);
    Produto y = new Produto(2, "Sansung Glaxy", 10, 900);

    List<PedidoItem> itens = new List<PedidoItem>();

    PedidoItem primeiroitem = new PedidoItem(1, x, 1, x.Valor);
    PedidoItem segundoitem = new PedidoItem(2, y, 2, y.Valor);

    itens.Add(primeiroitem);
    itens.Add(segundoitem);

    DateTime datapedido = new DateTime(2024, 8, 7);

    PedidoCabecalho pedido = new PedidoCabecalho(1, datapedido, cliente, 1500, itens);

}
