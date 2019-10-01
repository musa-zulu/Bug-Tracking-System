using System;
using System.Collections.Generic;

namespace BugTracker.Core.Domains
{
    public class Project : BaseEntity
    {
        public Guid ProjectId { get; set; }
        public string ProjectName { get; set; }
        public Guid CompanyId { get; set; }
        public virtual Company Company { get; set; }
        public List<Issue> Bugs { get; set; }
        public List<Comment> Comments { get; set; }
        public Guid UserId { get; set; } 
        public virtual User User { get; set; }
    }
}