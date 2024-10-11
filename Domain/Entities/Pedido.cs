using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class Pedido
    {
        [Required]
        [Key]
        public int Id { get; set; }
        [StringLength(60)]
        public String NomeCliente { get; set; }
        [StringLength(60)]
        public String EmailCliente { get; set; }
        [Required]
        public DateTime DataCriacao { get; set; }
        public bool Pago { get; set; }
        public List<ItensPedido> Itens { get; set; } = new List<ItensPedido>();
    }
}
