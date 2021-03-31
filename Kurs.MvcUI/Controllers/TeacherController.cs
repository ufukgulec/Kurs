using Kurs.Business;
using Kurs.Dal.Concrete.EntityFramework.Repository;
using Kurs.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Kurs.MvcUI.Controllers
{
    public class TeacherController : Controller
    {
        ITeacherService teacherService = new TeacherManager(new EfTeacherRepository());
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult List()
        {
            var list = teacherService.GetAll();
            return View(list);
        }
    }
}