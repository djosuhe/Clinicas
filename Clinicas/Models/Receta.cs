//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Clinicas.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Receta
    {
        public int Id { get; set; }
        public int ConsultaId { get; set; }
        public int MedicamentoId { get; set; }
        public string Indicaciones { get; set; }
    
        public virtual Consulta Consulta { get; set; }
        public virtual Medicamento Medicamento { get; set; }
    }
}
