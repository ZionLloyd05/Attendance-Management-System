//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AMS.DAL.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class Student
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Student()
        {
            this.StdAttendances = new HashSet<StdAttendance>();
        }
    
        public byte matricNo { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public byte currentLevel { get; set; }
        public string email { get; set; }
        public decimal phone { get; set; }
        public byte[] fingerprint { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StdAttendance> StdAttendances { get; set; }
    }
}