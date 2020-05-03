using System;
using Microsoft.EntityFrameworkCore;
namespace LeaderEdu.Models
{
    

    public class LeaderEduContext : DbContext
    {
        

    

        public LeaderEduContext(DbContextOptions<LeaderEduContext> options) : base(options)
        {
        }
       

        // public LeaderEduContext() : base() { }
        public DbSet<User> User { get; set; }
        public DbSet<EduTime> EduTime { get; set; }
        public DbSet<QuestionnaireLeader> QuestionnaireLeader { get; set; }
    }
}
