//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Model.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Medic
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Medic()
        {
            this.Entry = new HashSet<Entry>();
            this.Exit = new HashSet<Exit>();
        }
    
        public long id { get; set; }
        public string documentId { get; set; }
        public string name { get; set; }
        public string firstLastName { get; set; }
        public string secondLastName { get; set; }
        public bool isSpecialist { get; set; }
        public bool enabled { get; set; }
        public bool deleted { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Entry> Entry { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Exit> Exit { get; set; }
    }
}