using Kurs.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kurs.Dal.Abstract
{
    public interface ITeacherRepository : IGenericRepository<ogretmenler>
    {
        /// <summary>
        /// Aktif öğretmen
        /// </summary>
        /// <returns>List Öğretmen</returns>
        List<ogretmenler> ActiveTeacherList();
        /// <summary>
        /// Pasif öğretmen
        /// </summary>
        /// <returns>List Öğretmen</returns>
        List<ogretmenler> InactiveTeacherList();
    }
}
