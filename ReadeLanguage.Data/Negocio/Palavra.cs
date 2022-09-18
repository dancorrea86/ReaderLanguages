using System.ComponentModel.DataAnnotations;

namespace ReadeLanguage.Data.Negocio
{
    public class Palavra
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(200)]
        public string PalavraPt { get; set; }

        public int? IdTraducaoFr { get; set; }

        public int? IdTraducaoEn { get; set; }
    }
}
