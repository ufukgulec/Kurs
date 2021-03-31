using Kurs.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Kurs.Business
{
    public abstract class GenericManager<T> : IGenericService<T>
    {
        /// <summary>
        /// T varlığını ekleme
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>T</returns>
        public T Add(T entity)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Id'ye göre varlık silme
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Bool</returns>
        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// T varlığını siler
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>Bool</returns>
        public bool Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Id'ye göre varlık getir
        /// </summary>
        /// <param name="id"></param>
        /// <returns>T</returns>
        public T Get(int id)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Tüm T listesi
        /// </summary>
        /// <returns>T List</returns>
        public List<T> GetAll()
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Filter List T
        /// </summary>
        /// <param name="expression"></param>
        /// <returns>T List</returns>
        public List<T> GetAll(Expression<Func<T, bool>> expression)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// T varlığını dönderir
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>T</returns>
        public T Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
