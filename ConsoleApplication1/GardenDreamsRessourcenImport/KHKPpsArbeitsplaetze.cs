//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GardenDreamsRessourcenImport
{
    using System;
    using System.Collections.Generic;
    
    public partial class KHKPpsArbeitsplaetze
    {
        public string Arbeitsplatznummer { get; set; }
        public short Mandant { get; set; }
        public string Bezeichnung1 { get; set; }
        public string Bezeichnung2 { get; set; }
        public string Matchcode { get; set; }
        public string Memo { get; set; }
        public string Schichtplannummer { get; set; }
        public string Wartezeittext { get; set; }
        public Nullable<decimal> Wartezeit { get; set; }
        public Nullable<decimal> Leistungsgrad { get; set; }
        public Nullable<decimal> LohnkostenBetrieb { get; set; }
        public Nullable<decimal> ArbeitsplatzkostenBetrieb { get; set; }
        public Nullable<decimal> LohnkostenRuesten { get; set; }
        public Nullable<decimal> ArbeitsplatzkostenRuesten { get; set; }
        public Nullable<decimal> Zusatzkosten { get; set; }
        public string Kostenstelle { get; set; }
        public string Kostentraeger { get; set; }
        public short Pausenabzug { get; set; }
        public Nullable<decimal> Fertigungsgemeinkostenzuschlag { get; set; }
        public string NurBarcode { get; set; }
        public short Aktiv { get; set; }
        public string BdeTerminalId { get; set; }
        public byte[] Timestamp { get; set; }
    }
}
