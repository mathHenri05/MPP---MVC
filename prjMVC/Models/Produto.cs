﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace prjMVC.Models
{
    
        [Table("Produtos")]
        public class Produto
        {
            [Key]
            public int ProdutoId { get; set; }

            [Required(ErrorMessage = "O nome do Produto deve ser informado")]
            [Display(Name = "Nome do Produto")]
            [StringLength(80, MinimumLength = 10, ErrorMessage = "O {0} deve ter no mínimo {1} e no máximo {2} caracteres")]
            public string Nome { get; set; }

            [Required(ErrorMessage = "A descrição do Produto deve ser informada")]
            [Display(Name = "Descrição do Produto")]
            [MinLength(20, ErrorMessage = "Descrição deve ter no mínimo {1} caracteres")]
            [MaxLength(200, ErrorMessage = "Descrição pode exceder {1} caracteres")]
            public string DescricaoCurta { get; set; }

            [Required(ErrorMessage = "O descrição detalhada do Produto deve ser informada")]
            [Display(Name = "Descrição detalhada do Lanche")]
            [MinLength(20, ErrorMessage = "Descrição detalhada deve ter no mínimo {1} caracteres")]
            [MaxLength(200, ErrorMessage = "Descrição detalhada pode exceder {1} caracteres")]
            public string DescricaoDetalhada { get; set; }

            [Required(ErrorMessage = "Informe o preço do Produto")]
            [Display(Name = "Preço")]
            [Column(TypeName = "decimal(10,2)")]
            [Range(1, 999.99, ErrorMessage = "O preço deve estar entre 1 e 999,99")]
            public decimal Preco { get; set; }

            [Display(Name = "Caminho Imagem Normal")]
            [StringLength(200, ErrorMessage = "O {0} deve ter no máximo {1} caracteres")]
            public string ImagemUrl { get; set; }

            [Display(Name = "Caminho Imagem Miniatura")]
            [StringLength(200, ErrorMessage = "O {0} deve ter no máximo {1} caracteres")]
            public string ImagemThumbnailUrl { get; set; }

            [Display(Name = "Preferido?")]
            public bool IsLanchePreferido { get; set; }

            [Display(Name = "Estoque")]
            public bool EmEstoque { get; set; }

            // define o relacionamento entre lanche e categoria
            public int CategoriaId { get; set; } // chave estrangeira
            public virtual Categoria Categoria { get; set; } // retorna um objeto Categoria
        }
}