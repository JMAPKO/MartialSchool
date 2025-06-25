namespace Pakuayb.Dtos
{
    public class AlumnoDto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public DateOnly FechaNacimiento { get; set; }
        public DateTime FechaRegistro { get; set; }
    }
}
