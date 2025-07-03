namespace Pakuayb.Dtos
{
    public class AlumnoUpdateDto
    {
        public int id {  get; set; }
        public string? Nombre { get; set; }
        public int? Edad { get; set; }
        public DateOnly? FechaNacimiento { get; set; }
    }
}
