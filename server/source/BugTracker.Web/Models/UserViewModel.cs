using System;
using System.Collections.Generic;
using BugTracker.Core.Domains;

namespace BugTracker.Web.Models
{
    public class UserViewModel : BaseViewModel
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