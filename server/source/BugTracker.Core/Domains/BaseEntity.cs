using System;

namespace BugTracker.Core.Domains
{
    public class BaseEntity 
    {
        public DateTime?  DateCreated { get; set; }
        public string CreatedUsername { get; set; }
        public DateTime? DateLastModified { get; set; }
        public string LastModifiedUsername { get; set; }
    }
}