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
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    public partial class tb_class
    {
        public int ID { get; set; }
        [DisplayName("Tarikh")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public System.DateTime Date { get; set; }
        [DisplayName("Tempoh (minit)")]
        public int Duration { get; set; }
        public int Package { get; set; }
        public Nullable<int> TutorID { get; set; }
        public Nullable<int> StudentID { get; set; }
        public string Description { get; set; }
        [DisplayName("Waktu Masuk")]
        public Nullable<System.DateTime> CheckIn { get; set; }
        [DisplayName("Waktu Keluar")]
        public Nullable<System.DateTime> CheckOut { get; set; }
        [DisplayName("Waktu Mula")]
        public Nullable<System.TimeSpan> StartTime { get; set; }
        [DisplayName("Penilaian Pelajar")]
        public Nullable<int> RatingTutor { get; set; }
        [DisplayName("Verifikasi")]
        public Nullable<int> verifyStatus { get; set; }
    
        public virtual tb_package tb_package { get; set; }
        public virtual tb_student tb_student { get; set; }
        public virtual tb_user tb_user { get; set; }
    }
}
