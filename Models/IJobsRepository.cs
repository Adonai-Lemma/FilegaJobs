using System.Collections.Generic;

namespace FilegaJobs.Models
{
    public interface IJobsRepository
    {
        Jobs GetJobs(int jobId);
        Jobs Add(Jobs job);
        IEnumerable<Jobs> GetAllJobs();
        Jobs Update (Jobs jobEdits);
        Jobs Delete(int id);
    }
}
