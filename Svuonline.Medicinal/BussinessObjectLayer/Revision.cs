//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Svuonline.Medicinal.BussinessObjectLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class Revision
    {
        public int RevisionID { get; set; }
        public bool Cough { get; set; }
        public bool Cold { get; set; }
        public bool Sorethroat { get; set; }
        public bool BodyPain { get; set; }
        public bool Headache { get; set; }
        public bool Heat { get; set; }
        public bool Fatigue { get; set; }
        public int PatientID { get; set; }
    
        public virtual Patient Patient { get; set; }
    }
}
