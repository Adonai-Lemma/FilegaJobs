using Microsoft.EntityFrameworkCore;

namespace FilegaJobs.Models
{
    public class FilegaDbContext : DbContext 
    {
        public FilegaDbContext(DbContextOptions<FilegaDbContext> options) : base(options)
        {

        }

        public DbSet<Jobs> Job { get; set; }
        public DbSet<UserProfiles> User { get; set; }
        public DbSet<applicants> applicant { get; set; }    
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Jobs>().HasData(
                new Jobs
                {
                    ID = 1,
                    Name = "Accountant",
                    Description = "xxxxxxx",
                    salary = 1000
                },
                new Jobs
                {
                    ID = 2,
                    Name = "Sectretary",
                    Description = "xxxxxxx",
                    salary = 100
                },
                new Jobs
                {
                    ID = 3,
                    Name = "Manager",
                    Description = "xxxxxxx",
                    salary = 10000
                }
                );

            modelBuilder.Entity<UserProfiles>().HasData(
                new UserProfiles
                {
                    ID = 1,
                    Name = "Abebe",
                    email = "ab@gmail.com",
                    resume = "xxxxxxxxx"
                },
                new UserProfiles
                {
                    ID = 2,
                    Name = "Shimelis",
                    email = "sh@gmail.com",
                    resume = "xxxxxxxxx"
                },
                new UserProfiles
                {
                    ID = 3,
                    Name = "Abigia",
                    email = "abg@gmail.com",
                    resume = "xxxxxxxxx"
                },
                new UserProfiles
                {
                    ID = 4,
                    Name = "Abel",
                    email = "abe@gmail.com",
                    resume = "xxxxxxxxx"
                },
                new UserProfiles
                {
                    ID = 5,
                    Name = "Adonai",
                    email = "ad@gmail.com",
                    resume = "xxxxxxxxx"
                }
                );

            modelBuilder.Entity<applicants>().HasData(
               new applicants
               {
                   ID = 101,
                   name = "Abigia",
                   profileID = 3,
                   jobID = 1
               },
               new applicants
               {
                   ID = 102,
                   name = "Abel",
                   profileID = 4,
                   jobID = 2
               },
               new applicants
               {
                   ID = 103,
                   name = "Adonai",
                   profileID = 5,
                   jobID = 3
               }
               );
        }

    }
}
