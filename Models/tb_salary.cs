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
    
    public partial class tb_salary
    {
        public int ID { get; set; }
        public Nullable<double> Amount { get; set; }
        public int TutorID { get; set; }
        public Nullable<int> month { get; set; }
        public string Status { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
    
        public virtual tb_user tb_user { get; set; }
    }
}
