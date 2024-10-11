using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class ItensPedido
    {
        public ItensPedido(Produto produto, int quantidade)
        {
            Produto = produto;
            quantidade = quantidade;
        }
        [Required]
        [Key]
        public int Id { get; set; }
        [Required]
        public int IdPedido { get; set; }
        public virtual Pedido Pedido { get; set; }

        [Required]
        public int IdProduto { get; set; }
        public virtual Produto Produto { get; set; }

        public int Quantidade { get; set; }

    }
}
