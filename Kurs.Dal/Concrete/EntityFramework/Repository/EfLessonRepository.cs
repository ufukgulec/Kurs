using Kurs.Dal.Abstract;
using Kurs.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kurs.Dal.Concrete.EntityFramework.Repository
{
    public class EfLessonRepository : EfGenericRepository<dersler>, ILessonRepository
    {
        public EfLessonRepository()
        {
            _context = new Context.KursContext();
        }
        /// <summary>
        /// Öğrencisi olan dersler
        /// </summary>
        /// <returns>List ders</returns>
        public List<dersler> ActiveLessonList()
        {
            return _context.dersler.ToList();
        }
    }
}
