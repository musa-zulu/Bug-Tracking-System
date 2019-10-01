using System;

namespace BugTracker.Web.Models
{
    public class BaseViewModel
    {
        public DateTime? DateCreated { get; set; }
        public string CreatedUsername { get; set; }
        public DateTime? DateLastModified { get; set; }
        public string LastModifiedUsername { get; set; }
    }
}