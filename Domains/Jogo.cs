using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
// Caminho de em que a classe jogo esta
namespace Projeto_Jogos.Domains
{
    [Table("Jogos")]
    // O Index faz com o que o NomeDoJogo nao se repita
    [Index(nameof(NomeDoJogo), IsUnique = true)]
    //Public class -> Criar uma classe publica
    public class Jogo
    {
        //Preencher as atributos
        [Key]
        public Guid JogoId { get; set; }
        [Column(TypeName = "varchar(50)")]
        // O required faz com que o NomeDoJogo seja obrigatorio preencher o campo de NomeDoJogo
        [Required(ErrorMessage = "O campo Nome do Jogo é obrigatório")]
        public string? NomeDoJogo { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string? Plataforma { get; set; }
    }
}
