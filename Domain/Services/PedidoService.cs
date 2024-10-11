using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services
{
    public class PedidoService
    {
      
        List<ItensPedido> Itens = new List<ItensPedido>();
        public void AdicionarProduto(Produto produto, int quantidade)
        {

            if (quantidade <= 0)
            {
                throw new ArgumentException("Selecione quantos itens deste produto quer adicionar.");
            }
           
            var item = new ItensPedido(produto, quantidade);
            Itens.Add(item);
        }
        public decimal CalcularTotal()
        {
            return Itens.Sum(item => item.Produto.Valor * item.Quantidade);
        }

        public void Finalizar()
        {
            if (!Itens.Any())
                throw new InvalidOperationException("O pedido deve ter pelo menos um item.");
        }
    }
}
