using System.Collections.Generic;

namespace FilegaJobs.Models
{
    public class SqlApplicantsRepository : IApplicantsRepository
    {
        private readonly FilegaDbContext context;
        public SqlApplicantsRepository(FilegaDbContext context)
        {
            this.context = context;
        }

        public applicants Add(applicants applicant)
        {
            context.applicant.Add(applicant);
            context.SaveChanges();
            return applicant;
        }

        public applicants Delete(int id)
        {
            applicants applicant = context.applicant.Find(id);
            if (applicant != null)
            {
                context.applicant.Remove(applicant);
                context.SaveChanges();
            }
            return applicant;

        }

        public IEnumerable<applicants> GetAllApplicants()
        {
            return context.applicant;
        }

        public applicants GetApplicants(int ApplicantId)
        {
            return context.applicant.Find(ApplicantId);
        }

        public applicants Update(applicants ApplicantEdits)
        {
            var j = context.applicant.Attach(ApplicantEdits);
            j.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();

            return ApplicantEdits;
        }
    }
}
