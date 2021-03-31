using Kurs.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kurs.Dal.Abstract
{
    public interface ILessonRepository : IGenericRepository<dersler>
    {
        /// <summary>
        /// Öğrencisi olan dersler
        /// </summary>
        /// <returns>List ders</returns>
        List<dersler> ActiveLessonList();
    }
}
