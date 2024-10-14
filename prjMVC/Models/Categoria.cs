using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace prjMVC.Models
{
    [Table("Categoria")]
    public class Categoria
    {

        [Key]
        public int CategoriaId { get; set; }
        [Required(ErrorMessage = "O nome da Categoria deve ser informado")]
        [Display(Name = "Nome da Categoria")]
        [StringLength(80, MinimumLength = 10, ErrorMessage = "O {0} deve ter no mínimo {1} e no máximo {2} caracteres")]
        public string NomeCategoria { get; set; }

        [Required(ErrorMessage = "A descrição da Categoria deve ser informada")]
        [Display(Name = "Descrição da Categoria")]
        [MinLength(20, ErrorMessage = "Descrição deve ter no mínimo {1} caracteres")]
        [MaxLength(200, ErrorMessage = "Descrição pode exceder {1} caracteres")]
        public string Descricao { get; set; }
        public List<Produto> Produtos { get; set; }

    }
}
