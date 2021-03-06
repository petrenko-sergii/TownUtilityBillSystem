//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TownUtilityBillSystem
{
    using System;
    using System.Collections.Generic;
    
    public partial class ADDRESS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ADDRESS()
        {
            this.CUSTOMERs = new HashSet<CUSTOMER>();
            this.METERs = new HashSet<METER>();
        }
    
        public int ID { get; set; }
        public int INDEX_ID { get; set; }
        public int TOWN_ID { get; set; }
        public int STREET_ID { get; set; }
        public int BUILDING_ID { get; set; }
        public Nullable<int> FLAT_PART_ID { get; set; }
    
        public virtual BUILDING BUILDING { get; set; }
        public virtual FLAT_PART FLAT_PART { get; set; }
        public virtual INDEX INDEX { get; set; }
        public virtual STREET STREET { get; set; }
        public virtual TOWN TOWN { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CUSTOMER> CUSTOMERs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<METER> METERs { get; set; }
    }
}
