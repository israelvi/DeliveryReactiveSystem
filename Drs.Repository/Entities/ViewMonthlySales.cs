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
    
    public partial class ViewMonthlySales
    {
        public int Key { get; set; }
        public int OrderYear { get; set; }
        public int OrderMonth { get; set; }
        public Nullable<int> SalesPerMonth { get; set; }
        public Nullable<decimal> TotalPerMonth { get; set; }
        public string Franchise { get; set; }
        public int FranchiseStoreId { get; set; }
        public string FranchiseStore { get; set; }
    }
}
