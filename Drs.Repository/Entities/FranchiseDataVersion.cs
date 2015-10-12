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
    
    public partial class FranchiseDataVersion
    {
        public FranchiseDataVersion()
        {
            this.FranchiseDataFile = new HashSet<FranchiseDataFile>();
        }
    
        public int FranchiseDataVersionId { get; set; }
        public System.Guid FranchiseDataVersionUid { get; set; }
        public int FranchiseId { get; set; }
        public string Version { get; set; }
        public System.DateTime Timestamp { get; set; }
        public int TotalNumberOfFiles { get; set; }
        public int NumberOfFilesDownloaded { get; set; }
        public bool IsCompleted { get; set; }
        public bool IsListOfFilesReceived { get; set; }
        public string UserInsId { get; set; }
        public Nullable<System.DateTime> TimestampComplete { get; set; }
        public Nullable<bool> IsObsolete { get; set; }
        public string UserUpdId { get; set; }
    
        public virtual AspNetUsers AspNetUsers { get; set; }
        public virtual AspNetUsers AspNetUsers1 { get; set; }
        public virtual Franchise Franchise { get; set; }
        public virtual ICollection<FranchiseDataFile> FranchiseDataFile { get; set; }
    }
}
