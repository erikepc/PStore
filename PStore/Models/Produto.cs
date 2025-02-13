using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PStore.Models
{
    public class Produto
    {
        [Key] // Indica que esta é a chave primária
        public int Id { get; set; }

        [ForeignKey("Categoria")] // Define a chave estrangeira para Categoria
        public int CategoriaId { get; set; }

        public Categoria Categoria { get; set; }

        [Required(ErrorMessage = "Por favor, informe o nome")]
        [StringLength(30, ErrorMessage = "O nome deve possuir no máximo 30 caracteres")]
        public string Nome { get; set; }

        [StringLength(500)] // Define um limite para a descrição
        public string Descricao { get; set; }

        [Range(0, int.MaxValue)] // Garante que a quantidade não seja negativa
        public int Qtde { get; set; }

        [Column(TypeName = "decimal(18,2)")] // Define a precisão do campo no banco de dados
        [Range(0.01, double.MaxValue)] // Evita valores negativos ou zero
        public decimal ValorCusto { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        [Range(0.01, double.MaxValue)]
        public decimal ValorVenda { get; set; }
    }
}
