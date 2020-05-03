using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LeaderEdu.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LeaderEdu.Controllers
{
    public class BaseController : Controller
    {

        // GET: /<controller>/
        private readonly LeaderEduContext db;

        public BaseController(LeaderEduContext context)
        {
            db = context;
        }
        [Authorize]
        public IActionResult Leader()
        {
            var eduTimes = db.EduTime.ToList();
            List<string> disDate = new List<string>();
            List<string> disTime = new List<string>();

            int year = DateTime.Now.Year;
            int month = DateTime.Now.Month;
            bool addTime = false;

            for (int i = 1; i <= DateTime.DaysInMonth(year, month); i++)
            {
                DateTime dt = new DateTime(year, month, i);
                if (eduTimes.Where(x => x.BeginDate.Date == dt.Date).Count()==0) {
                    disDate.Add(dt.ToString("yyyy-MM-dd"));
                }
                
            }
            var mixmodelLeader = new ModelMixForLeader
            {
                EduTimeList = eduTimes,
                disableDates = disDate,
                disableTimes = disTime,
                AddTime = addTime
            };

            return View(mixmodelLeader);
        }
        [Authorize]
        public IActionResult Coach()
        {
            var eduTimes = db.EduTime.Where(x => x.CoachGuid == User.Identity.Name).Where(x=>x.BeginDate.Month==DateTime.Now.Month).ToList();

            var user = db.User.Where(x => x.guid == User.Identity.Name).FirstOrDefault();

            List<string> disTime = new List<string>();
            bool addTime = false;
            if (eduTimes.Count > 20) {
                addTime = true;
            }
            QuestionnaireLeader questionnaireLeader = new QuestionnaireLeader();
            if (db.QuestionnaireLeader.Where(x => x.Id == 1).Count()>0) {
                questionnaireLeader = db.QuestionnaireLeader.Where(x => x.Id == 1).FirstOrDefault();
            }
            
            var mixmodelCoach = new ModelMixForCoach
            {
                EduTimeList = eduTimes,
                disableTimes = disTime,
                AddTime= addTime,
                questionnaireLeader = questionnaireLeader,
                user= user

            };
            return View(mixmodelCoach);
        }
        [HttpPost]
        public PartialViewResult AddCoachTime([FromBody] EduTime edutime)
        {
           // string a = User.Identity.Name;

            edutime.CoachGuid= User.Identity.Name;
            edutime.EndDate = edutime.EndDate.AddHours(1);
                db.EduTime.Add(edutime);
                db.SaveChanges();

            var eduTimes = db.EduTime.Where(x=>x.CoachGuid == User.Identity.Name).ToList();

         /*   var disableTime = db.EduTime.Where(x => x.BeginDate.Date == edutime.BeginDate.Date).ToList();

            List<string> dt = new List<string>();

            foreach (var a in disableTime)
            {

                dt.Add(a.BeginDate.ToString("HH:mm"));
            }*/

            var mixmodelCoach = new ModelMixForCoach
            {
                EduTimeList = eduTimes

            };
           // return Json(new { error = dt, message = PartialView("PartialEduTimes", mixmodelCoach) });

            return PartialView("PartialEduTimes", mixmodelCoach);


        }

        [HttpPost]
        public PartialViewResult AddLeaderTime([FromBody] EduTime edutime)
        {

            edutime.LeaderGuid= User.Identity.Name;
            edutime.EndDate = edutime.EndDate.AddHours(1);
            db.EduTime.Add(edutime);
           // db.SaveChanges();

            var eduTimes = db.EduTime.ToList();

            var mixmodelCoach = new ModelMixForCoach
            {
                EduTimeList = eduTimes
            };
            return PartialView("PartialEduTimes", mixmodelCoach);


        }


        [HttpPost]
        public List<string> GetDisableTimesForLeader(DateTime BeginDate) {

            var eduTimes = db.EduTime.Where(x=>x.BeginDate.Date==BeginDate.Date).ToList();

            List<string> dt = new List<string>();

            foreach (var a in eduTimes)
            {

                dt.Add(a.BeginDate.ToString("HH:mm"));
            }
            return dt;
        }

        [HttpPost]
        public List<string> GetDisableTimesForCoach(DateTime BeginDate)
        {

            var eduTimes = db.EduTime.Where(x => x.BeginDate.Date == BeginDate.Date).ToList();

            List<string> dt = new List<string>();

            foreach (var a in eduTimes)
            {

                dt.Add(a.BeginDate.ToString("HH:mm"));
            }
            return dt;
        }

        

    }
}
