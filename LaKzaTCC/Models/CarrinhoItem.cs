namespace LaKzaTCC.Models
{
    public class CarrinhoItem
    {
        public int ProdutoId { get; set; }
        public string Nome { get; set; }
        public decimal ValorUnitario { get; set; }
        public int Quantidade { get; set; } = 1;
        public string? Foto { get; set; }

        public decimal Total => ValorUnitario * Quantidade;
    }
}
