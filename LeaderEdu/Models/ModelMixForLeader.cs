using System;
using System.Collections.Generic;

namespace LeaderEdu.Models
{
   
        public class ModelMixForLeader
        {
            public IEnumerable<EduTime> EduTimeList { get; set; }
        public List<string> disableDates { get; set; }
        public List<string> disableTimes { get; set; }
        public bool AddTime { get; set; }
    }
    
}
