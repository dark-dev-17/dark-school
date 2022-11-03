using System.ComponentModel.DataAnnotations;

namespace Forms.Models.Libro
{
    public class LibroCreateModel
    {
        [Required(ErrorMessage = "No te olvides del Nombre")]
        [StringLength(5, ErrorMessage = "solo se aceptan 5 letras")]
        public string Nombre { get; set; } = null!;
        public string Editorial { get; set; } = null!;
        public string NoCopias { get; set; } = null!;
    }
}
