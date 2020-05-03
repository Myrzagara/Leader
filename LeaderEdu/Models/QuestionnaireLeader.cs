using System;
using System.ComponentModel.DataAnnotations;

namespace LeaderEdu.Models
{
    public class QuestionnaireLeader
    {
        public int Id { get; set; }
        public string guid { get; set; }
        public string answer1 { get; set; }
        public string answer2 { get; set; }
    }
}
