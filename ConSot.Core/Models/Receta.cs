namespace ConSot.Core.Models
{
    public class Receta
    {
        public int RecetaId { get; set; }
        public DateOnly Fecha { get; set; }

        public int PacienteId { get; set; }
        public string Diagnostico { get; set; }
        public string Recomendaciones { get; set; }

        public Receta(int id, DateOnly fecha, int pacienteId, string diagnostico, string recomendaciones)
        {
            RecetaId = id;
            Fecha = fecha;
            PacienteId = pacienteId;
            Diagnostico = diagnostico;
            Recomendaciones = recomendaciones;
        }
    }
}
