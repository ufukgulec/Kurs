using Kurs.Dal.Abstract;
using Kurs.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kurs.Dal.Concrete.EntityFramework.Repository
{
    public class EfTeacherRepository : EfGenericRepository<ogretmenler>, ITeacherRepository
    {
        public EfTeacherRepository() : base()
        {

        }
        /// <summary>
        /// Aktif Öğretmenler
        /// </summary>
        /// <returns>List öğretmen</returns>
        public List<ogretmenler> ActiveTeacherList()
        {
            return _context.ogretmenler.ToList();
        }
        /// <summary>
        /// Pasif Öğretmenler
        /// </summary>
        /// <returns>List öğretmen</returns>
        public List<ogretmenler> InactiveTeacherList()
        {
            return _context.ogretmenler.ToList();
        }
    }
}
