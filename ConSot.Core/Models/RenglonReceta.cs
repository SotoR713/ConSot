using System;
using System.Collections.Generic;
using System.Text;

namespace ConSot.Core.Models
{
    internal class RenglonReceta
    {
        public int RenglonRecetaId { get; set; }
        public int Recetaid { get; set; }
        public int MedicamentoId { get; set; }
        public decimal CantidadRecetada { get; set; }
        public decimal CantidadSurtida { get; set; }

        public RenglonReceta( int id, int recetaid, int medicamentoId, decimal cantidadRecetada, decimal cantidadSurtida)
        {
            RenglonRecetaId = id;
            Recetaid = recetaid;
            MedicamentoId = medicamentoId;
            CantidadRecetada = cantidadRecetada;
            CantidadSurtida = cantidadSurtida;
        }} 

    }
}
