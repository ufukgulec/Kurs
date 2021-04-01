using Kurs.Business;
using Kurs.Dal.Concrete.EntityFramework.Repository;
using Kurs.Entities.Models;
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
        IGenericService<veliler> parentService = new GenericManager<veliler>(new EfGenericRepository<veliler>());
        IGenericService<dersSecimleri> lessonSelectionService = new GenericManager<dersSecimleri>(new EfGenericRepository<dersSecimleri>());
        public ActionResult Index()
        {
            ViewBag.StudentCount = studentService.Count();
            ViewBag.TeacherCount = teacherService.Count();
            ViewBag.LessonCount = lessonService.Count();
            ViewBag.ParentCount = parentService.Count();
            ViewBag.LastStudent = studentService.GetAll().OrderByDescending(s => s.kayitTarihi).FirstOrDefault().ogrenciAdi;


            ViewBag.MostExpensiveLesson = lessonService.GetAll().OrderByDescending(x => x.ücret).FirstOrDefault().dersAdi;
            ViewBag.MostCheapLesson = lessonService.GetAll().OrderBy(x => x.ücret).FirstOrDefault().dersAdi;
            ViewBag.MostSelectionStudent = studentService.GetAll().OrderByDescending(x => x.dersSecimleri.Count).FirstOrDefault().ogrenciAdi;
            ViewBag.MostSelectionLesson = lessonService.GetAll().OrderByDescending(x => x.dersSecimleri.Count).FirstOrDefault().dersAdi;
            return View();
        }
    }
}