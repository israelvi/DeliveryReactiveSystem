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
    
    public partial class FranchiseDataFile
    {
        public int FranchiseDataFileId { get; set; }
        public int FranchiseDataVersionId { get; set; }
        public string FileName { get; set; }
        public string CheckSum { get; set; }
        public bool IsSync { get; set; }
    
        public virtual FranchiseDataVersion FranchiseDataVersion { get; set; }
    }
}
