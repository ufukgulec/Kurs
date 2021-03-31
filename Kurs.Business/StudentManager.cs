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
    public class StudentManager : GenericManager<ogrenciler>, IStudentService
    {
        IStudentRepository _studentRepository;

        public StudentManager(IStudentRepository studentRepository) : base(studentRepository)
        {
            _studentRepository = studentRepository;
        }
        /// <summary>
        /// Aktif öğrenciler
        /// </summary>
        /// <returns>List öğrenci</returns>
        public List<ogrenciler> ActiveStudentList()
        {
            return _studentRepository.GetAll();
        }
        /// <summary>
        /// Pasif öğrenciler
        /// </summary>
        /// <returns>List öğrenci</returns>
        public List<ogrenciler> InactiveStudentList()
        {
            return _studentRepository.GetAll();
        }

        public List<ogrenciler> StudentIncludeList(string tableName)
        {
            return _studentRepository.StudentIncludeList(tableName);
        }
    }
}
