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
    public class LessonController : Controller
    {
        ILessonService lessonService;

        public LessonController(ILessonService lessonService)
        {
            this.lessonService = lessonService;
        }

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult List()
        {
            var list = lessonService.GetAll();
            return View(list);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(dersler dersler)
        {
            lessonService.Add(dersler);
            return View("List");
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            var model = lessonService.Get(id);
            return View(model);
        }
        [HttpPost]
        public ActionResult Edit(dersler dersler)
        {
            lessonService.Update(dersler);
            return View("List");
        }
        public ActionResult Details(int id)
        {
            var model = lessonService.Get(id);
            return View(model);
        }
    }
}