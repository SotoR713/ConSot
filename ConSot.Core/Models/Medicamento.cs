namespace ConSot.Core.Models
{
    public class Medicamento
    {
        public int MedicamentoId { get; set; }
        public string Nombre { get; set; }
        public decimal Existencia { get; set; }
        public string Presentacion { get; set; }

        public Medicamento(int id, string nombre, decimal existencia, string presentacion)
        {
            MedicamentoId = id;
            Nombre = nombre;
            Existencia = existencia;
            Presentacion = presentacion;
        }
    }
}

