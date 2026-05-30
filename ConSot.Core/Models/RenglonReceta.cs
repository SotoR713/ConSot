namespace ConSot.Core.Models
{
    public class RenglonReceta
    {
        public int RenglonRecetaId { get; set; }
        public int RecetaId { get; set; }
        public int MedicamentoId { get; set; }
        public decimal CantidadRecetada { get; set; }
        public decimal CantidadSurtida { get; set; }

        public RenglonReceta(int id, int recetaId, int medicamentoId, decimal cantidadRecetada, decimal cantidadSurtida)
        {
            RenglonRecetaId = id;
            RecetaId = recetaId;
            MedicamentoId = medicamentoId;
            CantidadRecetada = cantidadRecetada;
            CantidadSurtida = cantidadSurtida;
        }
    }

}
