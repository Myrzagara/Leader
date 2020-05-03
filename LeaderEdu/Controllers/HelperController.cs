using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LeaderEdu.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LeaderEdu.Controllers
{
    public class HelperController : Controller
    {
        private readonly LeaderEduContext db;

        public HelperController(LeaderEduContext context)
        {
            db = context;
        }

        [HttpPost]
        public IActionResult Add(QuestionnaireLeader questionnaireLeader)
        {
            
            db.QuestionnaireLeader.Add(questionnaireLeader);
            db.SaveChanges();

            return View(questionnaireLeader);

        }
    }
}
