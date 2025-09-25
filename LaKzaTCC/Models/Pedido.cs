using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LaKzaTCC.Models
{
    [Table("pedido")]
    public class Pedido
    {
        public int Id { get; set; }

        [Required]
        public DateTime DataPedido { get; set; } = DateTime.Now;

        public List<PedidoItem> Itens { get; set; } = new();
    }

    [Table("pedido_item")]
    public class PedidoItem
    {
        public int Id { get; set; }

        [Required]
        public int PedidoId { get; set; }

        [ForeignKey("PedidoId")]
        public Pedido Pedido { get; set; }

        [Required]
        public int ProdutoId { get; set; }

        [ForeignKey("ProdutoId")]
        public Produto Produto { get; set; }

        [Required]
        public int Quantidade { get; set; } = 1;

        [Column(TypeName = "numeric(10,2)")]
        public decimal ValorUnitario { get; set; }
    }
}
