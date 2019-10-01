using System.ComponentModel.DataAnnotations;

namespace BugTracker.Core.Domains
{
    public enum Status
    {
        Open,
        [Display(Name="In Progress")]
        InProgress,
        Resolved,
        Closed
    }
}