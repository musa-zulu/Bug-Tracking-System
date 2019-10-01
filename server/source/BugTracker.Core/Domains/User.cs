using System;
using System.Collections.Generic;

namespace BugTracker.Core.Domains
{
    public class User : BaseEntity
    {
        public Guid UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Guid CompanyId { get; set; }
        public virtual Company Company { get; set; }
        public Guid BugId { get; set; }
        public virtual Issue Issue { get; set; }
        public List<Project> Projects { get; set; }
        public List<Comment> Comments { get; set; }
        public UserType UserType { get; set; }
    }
}
