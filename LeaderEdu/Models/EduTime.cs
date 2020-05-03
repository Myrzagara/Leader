using System;
namespace LeaderEdu.Models
{
    public class EduTime
    {
        public int Id { get; set; }
        public string CoachGuid { get; set; }
        public DateTime BeginDate { get; set; }
        public DateTime EndDate { get; set; }
        public string LeaderGuid { get; set; }
        public int Status { get; set; }
    }
}
