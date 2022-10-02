using System.Collections.Generic;

namespace FilegaJobs.Models
{
    public class SqlUsersRepository : IUsersRepository
    {
        private readonly FilegaDbContext context;
        public SqlUsersRepository(FilegaDbContext context)
        {
            this.context = context;
        }

        public UserProfiles Add(UserProfiles user)
        {
            context.User.Add(user);
            context.SaveChanges();
            return user;
        }

        public UserProfiles Delete(int id)
        {
            UserProfiles user = context.User.Find(id);
            if (user != null)
            {
                context.User.Remove(user);
                context.SaveChanges();
            }
            return user;

        }

        public IEnumerable<UserProfiles> GetAllUsers()
        {
            return context.User;
        }

        public UserProfiles GetUsers(int UserId)
        {
            return context.User.Find(UserId);
        }

        public UserProfiles Update(UserProfiles UserEdits)
        {
            var j = context.User.Attach(UserEdits);
            j.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();

            return UserEdits;
        }
    }


}
