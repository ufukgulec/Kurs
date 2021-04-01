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
    public class StudentController : Controller
    {
        IStudentService studentService;

        public StudentController(IStudentService studentService)
        {
            this.studentService = studentService;
        }

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult List()
        {
            var list = studentService.GetAll();
            return View(list);
        }
        [HttpGet]
        public ActionResult Create()
        {

            return View();
        }
        [HttpPost]
        public ActionResult Create(ogrenciler ogrenciler)
        {
            studentService.Add(ogrenciler);
            return View("List");
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            var model = studentService.Get(id);
            return View(model);
        }
        [HttpPost]
        public ActionResult Edit(ogrenciler ogrenciler)
        {
            studentService.Update(ogrenciler);
            return View("List");
        }
        public ActionResult Details(int id)
        {
            var model = studentService.Get(id);
            return View(model);
        }
    }
}