using ApiRotina.Models.Enuns;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace ApiRotina.Models
{
    public class Treino
    {
        [Key]
        [Column("IdTreino")]
        public int IdTreino { get; set; }
        public string Exercicios { get; set; }
        public TreinoEnum TreinoClass { get; set; }
    }
}