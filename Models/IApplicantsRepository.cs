using System.Collections.Generic;

namespace FilegaJobs.Models
{
    public interface IApplicantsRepository
    {
        applicants GetApplicants(int ApplicantId);
        applicants Add(applicants applicant);
        IEnumerable<applicants> GetAllApplicants();
        applicants Update(applicants ApplicantEdits);
        applicants Delete(int id);
    }
}
