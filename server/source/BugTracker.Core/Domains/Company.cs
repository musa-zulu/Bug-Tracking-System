using System;
using System.Collections.Generic;

namespace BugTracker.Core.Domains
{
    public class Company : BaseEntity
    {
        public Guid CompanyId { get; set; } 
        public List<User> Users { get; set; } 
        public List<Comment> Comments { get; set; } 
        public List<Project> Projects { get; set; } 
        public string Email { get; set; }
        public string CompanyName { get; set; }
        public long HomePhone { get; set; }
        public long MobilePhone { get; set; }
        public long Fax { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int Zip { get; set; }
        public string Country { get; set; }
    }
}