using System.Collections.Generic;

namespace FilegaJobs.Models
{
    public class SqlJobsRepository : IJobsRepository
    {
        private readonly FilegaDbContext context;
        public SqlJobsRepository(FilegaDbContext context)
        {
            this.context = context;
        }
        public Jobs Add(Jobs job)
        {
            context.Job.Add(job);
            context.SaveChanges();
            return job;
        }

        public Jobs Delete(int id)
        {
            Jobs job = context.Job.Find(id);
            if (job != null)
            {
                context.Job.Remove(job);
                context.SaveChanges();
            }
            return job;

        }

        public IEnumerable<Jobs> GetAllJobs()
        {
            return context.Job;
        }

        public Jobs GetJobs(int jobId)
        {
            return context.Job.Find(jobId);
        }

        public Jobs Update(Jobs jobEdits)
        {
            var j = context.Job.Attach(jobEdits);
            j.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();

            return jobEdits;
        }
    }
}
