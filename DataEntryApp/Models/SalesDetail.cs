//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataEntryApp.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class SalesDetail
    {
        public int Id { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public string CustomerName { get; set; }
        public string Item { get; set; }
        public string SetDetails { get; set; }
        public Nullable<decimal> Weight { get; set; }
        public Nullable<decimal> Rate { get; set; }
        public Nullable<decimal> TotalAmount { get; set; }
        public string DRCR { get; set; }
        public string Notes { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public bool IsActive { get; set; }
    }
}
