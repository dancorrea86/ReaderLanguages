using System.ComponentModel.DataAnnotations;

namespace ReadeLanguage.Data.Negocio
{
    public class PalavraFrances
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(200)]
        public string PalavraFr { get; set; }
    }
}
