using Kurs.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kurs.Dal.Abstract
{
    public interface IStudentRepository : IGenericRepository<ogrenciler>
    {
        /// <summary>
        /// Aktif öğrenciler
        /// </summary>
        /// <returns>List öğrenci</returns>
        List<ogrenciler> ActiveStudentList();
        /// <summary>
        /// Pasif öğrenciler
        /// </summary>
        /// <returns>List öğrenci</returns>
        List<ogrenciler> InactiveStudentList();
    }
}
