using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PStore.Models
{   
    [Table("produto")]
    public class Produto
    {
        [Key] // Indica que esta é a chave primária
        public int Id { get; set; }

        [Required(ErrorMessage = "Por favor, informe a Categoria")]
        public int CategoriaId { get; set; }

        [ForeignKey(nameof(CategoriaId))] // Define a chave estrangeira para Categoria utilizar nameof para forçar pegar a categoria sem errar a digitação
        public Categoria Categoria { get; set; }

        [Required(ErrorMessage = "Por favor, informe o nome")]
        [StringLength(60, ErrorMessage = "O nome deve possuir no máximo 60 caracteres")]
        public string Nome { get; set; }

        [Display(Name = "Descrição", Prompt = "Digite aqui sua descrição")]
        [StringLength(1000, ErrorMessage = "A Descrição deve possuir no máximo 1000 caracteres")] // Define um limite para a descrição
        public string Descricao { get; set; }


        [Required(ErrorMessage = "Por favor digite a quantidade do item")]
        [Range(0, int.MaxValue)] // Garante que a quantidade não seja negativa
        public int Qtde { get; set; } = 0;

        [Column(TypeName = "decimal(10,2)")] // Define a precisão do campo no banco de dados usar numeric() é o caso mais padrão
        [Range(0.01, double.MaxValue)] // Evita valores negativos ou zero
        public decimal ValorCusto { get; set; } = 0;

        [Column(TypeName = "decimal(10,2)")]
        [Range(0.01, double.MaxValue)]
        public decimal ValorVenda { get; set; }
    }
}
