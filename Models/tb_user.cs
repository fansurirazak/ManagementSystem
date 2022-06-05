//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ManagementSystem.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tb_user
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tb_user()
        {
            this.tb_class = new HashSet<tb_class>();
            this.tb_salary = new HashSet<tb_salary>();
        }
    
        public int ID { get; set; }
        public string IC { get; set; }
        public string Name { get; set; }
        public Nullable<int> Role { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Contact { get; set; }
        public Nullable<int> Status { get; set; }
        public Nullable<int> BatchID { get; set; }

        public string LoginErrorMessage { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_class> tb_class { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_salary> tb_salary { get; set; }
        public virtual tb_status tb_status { get; set; }
    }
}
