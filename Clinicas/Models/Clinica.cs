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
    
    public partial class Clinica
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Nit { get; set; }
        public string Direccion { get; set; }
        public Nullable<int> CodigoPostal { get; set; }
        public string Referencia { get; set; }
        public int Telefono { get; set; }
        public string Logo { get; set; }
        public int CuentaId { get; set; }
    
        public virtual Cuenta Cuenta { get; set; }
    }
}