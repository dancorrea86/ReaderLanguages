using System.ComponentModel.DataAnnotations;

namespace ReadeLanguage.Data.Negocio
{
    public class PalavraIngles
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(200)]
        public string PalavraEn { get; set; }

    }
}
