namespace ConSot.Core.Models
{
    public class Medicamento
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Existencia { get; set; }
        public string Presentacion { get; set; }

        public Medicamento(int id, string nombre, int existencia, string presentacion)
        {
            Id = id;
            Nombre = nombre;
            Existencia = existencia;
            Presentacion = presentacion;
        }
    }
}

