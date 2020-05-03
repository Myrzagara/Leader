using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LeaderEdu.Models
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string guid { get; set; }
        public string email { get; set; }
        public string Password { get; set; }
        public string Iin { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public DateTime BirthDate { get; set; }
        public int Sex { get; set; }
        public string Phone { get; set; }
        public string Skype { get; set; }
        public int Branch { get; set; } // Отрасль
        public int Type { get; set; } // 
        public int LeaderType { get; set; }
        public int CoachType { get; set; }
        public bool CoachICF { get; set; } // 
        public int CoachEducation { get; set; }
        public int CoachBranch { get; set; }
        public int CoachStatus { get; set; }//Status7
        public int City { get; set; }
        public string Job { get; set; }
    }
}
