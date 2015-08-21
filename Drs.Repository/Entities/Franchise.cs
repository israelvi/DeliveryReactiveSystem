//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Drs.Repository.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class Franchise
    {
        public Franchise()
        {
            this.OrderToStore = new HashSet<OrderToStore>();
            this.FranchiseStore = new HashSet<FranchiseStore>();
        }
    
        public int FranchiseId { get; set; }
        public string ShortName { get; set; }
        public string Name { get; set; }
        public string UserIdIns { get; set; }
        public string UserIdUpd { get; set; }
        public System.DateTime DatetimeIns { get; set; }
        public Nullable<System.DateTime> DatetimeUpd { get; set; }
        public string Code { get; set; }
        public bool IsObsolete { get; set; }
    
        public virtual AspNetUsers AspNetUsers { get; set; }
        public virtual AspNetUsers AspNetUsers1 { get; set; }
        public virtual FranchiseButton FranchiseButton { get; set; }
        public virtual FranchiseData FranchiseData { get; set; }
        public virtual ICollection<OrderToStore> OrderToStore { get; set; }
        public virtual ICollection<FranchiseStore> FranchiseStore { get; set; }
    }
}
