using Kurs.Dal.Abstract;
using Kurs.Entities.Models;
using Kurs.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kurs.Business
{
    class LessonManager : GenericManager<dersler>, ILessonService
    {
        ILessonRepository _lessonRepository;

        public LessonManager(ILessonRepository lessonRepository) : base(lessonRepository)
        {
            _lessonRepository = lessonRepository;
        }

        public List<dersler> ActiveLessonList()
        {
            return _lessonRepository.ActiveLessonList();
        }
    }
}
