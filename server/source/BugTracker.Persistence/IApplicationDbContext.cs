using System.Threading.Tasks;

namespace BugTracker.Persistence
{
    public interface IApplicationDbContext
    {       
        Task<int> SaveChangesAsync();
    }
}
