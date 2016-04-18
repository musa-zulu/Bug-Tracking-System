using System;
using System.Collections.Generic;

namespace BugTracker.Core.Domains
{
    public class Issue : BaseEntity
    {
        public Guid BugId { get; set; }
        public Guid UserId { get; set; }
        public virtual User User { get; set; }
        public Guid CompanyId { get; set; }
        public virtual Company Company { get; set; }
        public string Priority { get; set; }
        public Guid ProjectId { get; set; }
        public virtual Project Project { get; set; }
        public Category Category { get; set; }
        public Status Status { get; set; }
        public string OpenedBy { get; set; }
        public DateTime DateLogged { get; set; }
        public DateTime DueDate { get; set; }
        public string Summary { get; set; }
        public string Resolution { get; set; }
        public List<Comment> Comments { get; set; } 
    }
}
