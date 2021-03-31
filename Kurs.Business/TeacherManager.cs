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
    public class TeacherManager : GenericManager<ogretmenler>, ITeacherService
    {
        ITeacherRepository _teacherRepository;
        public TeacherManager(ITeacherRepository teacherRepository) : base(teacherRepository)
        {
            _teacherRepository = teacherRepository;
        }
        /// <summary>
        /// Aktif öğretmen
        /// </summary>
        /// <returns>List öğretmen</returns>
        public List<ogretmenler> ActiveTeacherList()
        {
            return _teacherRepository.GetAll();
        }
        /// <summary>
        /// Pasif öğretmen
        /// </summary>
        /// <returns>List öğretmen</returns>
        public List<ogretmenler> InactiveTeacherList()
        {
            return _teacherRepository.GetAll();
        }
    }
}
