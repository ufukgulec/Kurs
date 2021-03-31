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
        /// <summary>
        /// Öğrenci Tablosuyla adı verilen tabloyu birleştirir.
        /// </summary>
        /// <param name="tableName">Tablo adı</param>
        /// <returns>List öğrenci</returns>
        List<ogrenciler> StudentIncludeList(string tableName);
    }
}
