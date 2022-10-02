using System.Collections.Generic;

namespace FilegaJobs.Models
{
    public interface IUsersRepository
    {
        UserProfiles GetUsers(int UserId);
        UserProfiles Add(UserProfiles user);
        IEnumerable<UserProfiles> GetAllUsers();
        UserProfiles Update(UserProfiles UserEdits);
        UserProfiles Delete(int id);
    }
}
