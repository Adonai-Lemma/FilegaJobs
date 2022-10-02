using System.Collections.Generic;
using System.Linq;

namespace FilegaJobs.Models
{
    public class JobsRepository : IJobsRepository
    {
        private List<Jobs> _jobList;
        
        public JobsRepository()
        {
            _jobList = new List<Jobs>()
            {
                new Jobs() { ID = 1,Name = "Accountant", Description = "xxxxxx", salary = 1000 },
                new Jobs() { ID = 2,Name = "Secretary", Description = "xxxxxx", salary = 100 },
                new Jobs() { ID = 3,Name = "Manager", Description = "xxxxxx", salary = 10000 }
            };
        }
        public Jobs Add(Jobs job)
        {
            job.ID = _jobList.Max(e => e.ID)+1;
            _jobList.Add(job);
            return job;
        }

        public Jobs Delete(int id)
        {
            Jobs job = _jobList.FirstOrDefault(e => e.ID == id);
            if(job != null)
            {
                _jobList.Remove(job);
            }
            return job;
        }

        public IEnumerable<Jobs> GetAllJobs()
        {
            return _jobList;
        }

        public Jobs GetJobs(int jobId)
        {
            return _jobList.FirstOrDefault(e => e.ID == jobId);
        }

        public Jobs Update(Jobs jobEdits)
        {
            Jobs job = _jobList.FirstOrDefault(e => e.ID == jobEdits.ID);
            if (job != null)
            {
                job.Name = jobEdits.Name;
                job.Description = jobEdits.Description;
                job.salary = jobEdits.salary;
            }
            return job;
        }
    }
}
