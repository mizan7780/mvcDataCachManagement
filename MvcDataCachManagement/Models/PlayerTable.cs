//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MvcDataCachManagement.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class PlayerTable
    {
        public int Id { get; set; }
        public string playerName { get; set; }
        public string playerCountry { get; set; }
        public int matchPlayed { get; set; }
        public Nullable<int> totalRun { get; set; }
        public Nullable<int> totalWicket { get; set; }
    }
}
