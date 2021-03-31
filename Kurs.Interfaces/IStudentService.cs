using Kurs.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kurs.Interfaces
{
    public interface IStudentService : IGenericService<ogrenciler>
    {
        /// <summary>
        /// Ders Alan öğrenci listesi
        /// </summary>
        /// <returns>List öğrenci</returns>
        List<ogrenciler> ActiveStudentList();
        /// <summary>
        /// Ders Almayan öğrenci listesi
        /// </summary>
        /// <returns>List öğrenci</returns>
        List<ogrenciler> InactiveStudentList();
    }
}
