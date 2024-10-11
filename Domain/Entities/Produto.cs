using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

namespace Domain.Entities
{
    public class Produto
    {
        [Required]
        [Key]
        public int Id { get; set; }
        [StringLength(20)]
        public string NomeProduto { get; set; }
        [Column(TypeName = "decimal(10,2)")]
        public decimal Valor { get; set; }

    }
}
