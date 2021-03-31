using Kurs.Dal.Abstract;
using Kurs.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Kurs.Business
{
    public class GenericManager<T> : IGenericService<T>
    {
        private readonly IGenericRepository<T> _genericRepository;

        public GenericManager(IGenericRepository<T> genericRepository)
        {
            _genericRepository = genericRepository;
        }

        /// <summary>
        /// T varlığını ekleme
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>T</returns>
        public T Add(T entity)
        {
            return _genericRepository.Add(entity);
        }
        /// <summary>
        /// Id'ye göre varlık silme
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Bool</returns>
        public bool Delete(int id)
        {
            return _genericRepository.Delete(id);
        }
        /// <summary>
        /// T varlığını siler
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>Bool</returns>
        public bool Delete(T entity)
        {
            return _genericRepository.Delete(entity);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                _genericRepository.Dispose();
            }
        }
        /// <summary>
        /// Id'ye göre varlık getir
        /// </summary>
        /// <param name="id"></param>
        /// <returns>T</returns>
        public T Get(int id)
        {
            return _genericRepository.Get(id);
        }
        /// <summary>
        /// Tüm T listesi
        /// </summary>
        /// <returns>T List</returns>
        public List<T> GetAll()
        {
            return _genericRepository.GetAll();
        }
        /// <summary>
        /// Filter List T
        /// </summary>
        /// <param name="expression"></param>
        /// <returns>T List</returns>
        public List<T> GetAll(Expression<Func<T, bool>> expression)
        {
            return _genericRepository.GetAll(expression);
        }
        /// <summary>
        /// T varlığını dönderir
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>T</returns>
        public T Update(T entity)
        {
            return _genericRepository.Update(entity);
        }
    }
}
