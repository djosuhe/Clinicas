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
    
    public partial class DiagnosticoCIE10
    {
        public int Id { get; set; }
        public int ConsultaId { get; set; }
        public int TipoDiagnosticoId { get; set; }
        public int CIE10Id { get; set; }
    
        public virtual CIE10 CIE10 { get; set; }
        public virtual Consulta Consulta { get; set; }
        public virtual TipoDiagnostico TipoDiagnostico { get; set; }
    }
}
