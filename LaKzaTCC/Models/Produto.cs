using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LaKzaTCC.Models;

[Table("produto")]
public class Produto
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Por favor, informe a Categoria")]
    public int CategoriaId { get; set; }
    [ForeignKey("CategoriaId")]
    public Categoria Categoria { get; set; }

    [Required(ErrorMessage = "Por favor, informe o Nome")]
    [StringLength(60, ErrorMessage = "O nome deve possuir no máximo 60 caracteres")]
    public string Nome { get; set; }

    [Display(Name = "Quantidade em Estoque")]
    [Range(0, int.MaxValue)]
    [Required(ErrorMessage = "Por favor, informe a Quantidade em Estoque")]
    public int QtdeEstoque { get; set; }

    [Display(Name = "Valor de Custo")]
    [Range(0, double.MaxValue)]
    [Column(TypeName = "numeric(10,2)")]
    public decimal ValorCusto { get; set; }

    [Display(Name = "Valor de Venda")]
    [Range(0, double.MaxValue)]
    [Column(TypeName = "numeric(10,2)")]
    public decimal ValorVenda { get; set; }

    public bool Destaque { get; set; }

    [StringLength(200)]
    [Display(Name ="Foto")]
    public string ArquivoFoto { get; set; }
}
