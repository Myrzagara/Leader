using System;
using System.Collections.Generic;

namespace LeaderEdu.Models
{
    public class ModelMixForCoach
    {
        public IEnumerable<EduTime> EduTimeList { get; set; }
        public List<string> disableTimes { get; set; }
        public bool AddTime { get; set; }
        public QuestionnaireLeader questionnaireLeader { get; set; }
        public User user { get; set; }

    }
}
