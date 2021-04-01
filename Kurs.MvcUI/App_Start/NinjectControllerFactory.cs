using Kurs.Business;
using Kurs.Dal.Concrete.EntityFramework.Repository;
using Kurs.Interfaces;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Kurs.MvcUI.App_Start
{
    public class NinjectControllerFactory : DefaultControllerFactory
    {
        private readonly IKernel kernel;
        public NinjectControllerFactory()
        {
            kernel = new StandardKernel();
            AddBllBind();
        }

        private void AddBllBind()
        {
            this.kernel.Bind<IStudentService>().To<StudentManager>().WithConstructorArgument("studentRepository", new EfStudentRepository());
            this.kernel.Bind<ILessonService>().To<LessonManager>().WithConstructorArgument("lessonRepository", new EfLessonRepository());
            this.kernel.Bind<ITeacherService>().To<TeacherManager>().WithConstructorArgument("teacherRepository", new EfTeacherRepository());
        }
        protected override IController GetControllerInstance(RequestContext requestContext, Type controllerType)
        {
            return controllerType == null ? null : (IController)kernel.Get(controllerType);
        }
    }
}