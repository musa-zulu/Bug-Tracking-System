using System;
using System.Collections.Generic;

namespace BugTracker.Core.Domains
{
    public class Comment : BaseEntity
    {
        public Guid CommentId { get; set; }
        public Guid BugId { get; set; }
        public virtual Issue Issue { get; set; }
        public Guid UserId { get; set; }
        public virtual User User { get; set; }
        public Guid CompanyId { get; set; }
        public virtual Company Company { get; set; }
        public Guid ProjectId { get; set; }
        public virtual Project Project { get; set; }
        public string CommentNote { get; set; }
        public List<string> History { get; set; } 
    }
}
