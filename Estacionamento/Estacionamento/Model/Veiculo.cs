//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Estacionamento.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Veiculo
    {
        public int Id { get; set; }
        public string Modelo { get; set; }
        public string Cor { get; set; }
        public int ClienteId { get; set; }
    
        public virtual Cliente Cliente { get; set; }
    }
}
