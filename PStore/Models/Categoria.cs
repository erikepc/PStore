using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PStore.Models;

[Table("categoria")]
 public class Categoria
{
    [Key]
    ///[DatabaseGenerated(DatabaseGeneratedOption.none)] comando para não gerar o id automatico
    public int Id { get; set; }

    [Required(ErrorMessage = "Por favor, informe o nome")]
    [StringLength(30, ErrorMessage = "O nome deve possuir no máximo 30 caracteres")]
    public string Nome { get; set; }

    [StringLength(300)]
    public string Foto { get; set; }
}
