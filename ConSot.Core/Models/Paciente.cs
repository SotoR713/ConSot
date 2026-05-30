namespace ConSot.Core.Models
{
    public class Paciente
    {

        public int Id { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }

        public Paciente(int id, string nombres, string apellidos)
        {
            Id = id;
            Nombres = nombres;
            Apellidos = apellidos;
        }
    }
}