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
    
    public partial class PosOrderPromo
    {
        public long PosOrderPromoId { get; set; }
        public long PosOrderId { get; set; }
        public int PromoTypeId { get; set; }
        public int PromoEntryId { get; set; }
        public string EntriesIdsSelected { get; set; }
    
        public virtual PosOrder PosOrder { get; set; }
    }
}