﻿using Kurs.Dal.Abstract;
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
        public EfStudentRepository()
        {
            _context = new Context.KursContext();
        }
    }
}
