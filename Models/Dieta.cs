using ApiRotina.Models.Enuns;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
namespace ApiRotina.Models
{
    public class Dieta
    {
        [Key]
        [Column("IdDieta")]
        public int IdDieta { get; set; }
        public string Dia { get; set; }
        public string Alimentos { get; set; }
        public int Refeicoes { get; set; }
        public string Nutrientes { get; set; }
        public DietaEnum DietaClass { get; set; }
    }
}
