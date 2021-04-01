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
    public class TeacherController : Controller
    {
        ITeacherService teacherService;

        public TeacherController(ITeacherService teacherService)
        {
            this.teacherService = teacherService;
        }

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult List()
        {
            var list = teacherService.GetAll();
            return View(list);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(ogretmenler ogretmenler)
        {
            teacherService.Add(ogretmenler);
            return View("List");
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            var model = teacherService.Get(id);
            return View(model);
        }
        [HttpPost]
        public ActionResult Edit(ogretmenler ogretmenler)
        {
            teacherService.Update(ogretmenler);
            return View("List");
        }
        public ActionResult Details(int id)
        {
            var model = teacherService.Get(id);
            return View(model);
        }
    }
}