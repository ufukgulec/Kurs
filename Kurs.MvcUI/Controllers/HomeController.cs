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
    public class HomeController : Controller
    {
        ILessonService lessonService = new LessonManager(new EfLessonRepository());
        IStudentService studentService = new StudentManager(new EfStudentRepository());
        ITeacherService teacherService = new TeacherManager(new EfTeacherRepository());
        public ActionResult Index()
        {
            ViewBag.StudentCount = studentService.GetAll().Count;
            ViewBag.TeacherCount = teacherService.GetAll().Count;
            ViewBag.LessonCount = lessonService.GetAll().Count;

            ViewBag.LastStudent = studentService.GetAll().OrderByDescending(s => s.kayitTarihi).FirstOrDefault().ogrenciAdi;
            return View();
        }
    }
}