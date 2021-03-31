using Kurs.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kurs.Interfaces
{
    public interface ITeacherService : IGenericService<ogretmenler>
    {
        /// <summary>
        /// Ders Veren öğretmen listesi
        /// </summary>
        /// <returns>List Öğretmen</returns>
        List<ogretmenler> ActiveTeacherList();
        /// <summary>
        /// Ders Vermeyen öğretmen listesi
        /// </summary>
        /// <returns>List Öğretmen</returns>
        List<ogretmenler> InactiveTeacherList();
    }
}
