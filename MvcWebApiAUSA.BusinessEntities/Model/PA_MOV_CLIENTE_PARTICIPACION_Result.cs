//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MvcWebApiAUSA.Entities.Model
{
    using System;
    
    public partial class PA_MOV_CLIENTE_PARTICIPACION_Result
    {
        public int ClienteID { get; set; }
        public string ClienteRazonSocial { get; set; }
        public Nullable<decimal> IPDmesVigente { get; set; }
        public Nullable<decimal> IPDMesAnterior { get; set; }
        public Nullable<decimal> IPDUltimos3Meses { get; set; }
        public Nullable<decimal> AduanaIngresoMesVigente { get; set; }
        public Nullable<decimal> AduanaIngresoMesAnterior { get; set; }
        public Nullable<decimal> AduanaIngresoUltimos3Meses { get; set; }
        public Nullable<decimal> HitsAOL { get; set; }
    }
}
