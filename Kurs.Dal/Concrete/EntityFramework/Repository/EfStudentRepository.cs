using Kurs.Dal.Abstract;
using Kurs.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kurs.Dal.Concrete.EntityFramework.Repository
{
    public class EfStudentRepository : EfGenericRepository<ogrenciler>, IStudentRepository
    {
        public EfStudentRepository() : base()
        {

        }
        /// <summary>
        /// Aktif öğrenciler
        /// </summary>
        /// <returns>List öğrenci</returns>
        public List<ogrenciler> ActiveStudentList()
        {
            return _context.ogrenciler.ToList();
        }
        /// <summary>
        /// Pasif öğrenciler
        /// </summary>
        /// <returns>List öğrenci</returns>
        public List<ogrenciler> InactiveStudentList()
        {
            return _context.ogrenciler.ToList();
        }
    }
}
