//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PersianDatePicker_MVC.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    
    public partial class Students
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [UIHint("PersianDate")]
        public Nullable<System.DateTime> EnrollmentDate { get; set; }
    }
}