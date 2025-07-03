using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pakuayb.Models
{
    public class Alumno
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public int? Edad { get; set; }
        
        [Column(TypeName = "date")]
        public DateOnly? FechaNacimiento { get; set; }
        
        [Column(TypeName = "date")]
        public DateTime FechaRegistro { get; set; } = DateTime.Now.Date;
    }
}
