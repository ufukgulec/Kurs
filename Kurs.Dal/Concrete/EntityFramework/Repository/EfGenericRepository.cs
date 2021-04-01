using Kurs.Dal.Abstract;
using Kurs.Dal.Concrete.EntityFramework.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Linq.Expressions;

namespace Kurs.Dal.Concrete.EntityFramework.Repository
{
    public class EfGenericRepository<T> : IGenericRepository<T> where T : class
    {
        public KursContext _context;
        public EfGenericRepository()
        {
            _context = new KursContext();
        }
        /// <summary>
        /// T varlığını ekleme
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>T</returns>
        public T Add(T entity)
        {
            _context.Set<T>().Add(entity);
            _context.SaveChanges();
            return entity;
        }
        /// <summary>
        /// Id'ye göre varlık silme
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Bool</returns>
        public bool Delete(int id)
        {
            return Delete(Get(id));
        }
        /// <summary>
        /// T varlığını siler
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>Bool</returns>
        public bool Delete(T entity)
        {
            _context.Set<T>().Remove(entity);
            return _context.SaveChanges() > 0;
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
                _context.Dispose();
            }
        }
        /// <summary>
        /// Id'ye göre varlık getir
        /// </summary>
        /// <param name="id"></param>
        /// <returns>T</returns>
        public T Get(int id)
        {
            return _context.Set<T>().Find(id);
        }
        /// <summary>
        /// Tüm T listesi
        /// </summary>
        /// <returns>T List</returns>
        public List<T> GetAll()
        {
            return _context.Set<T>().AsNoTracking().ToList();
        }
        /// <summary>
        /// Include List
        /// </summary>
        /// <param name="TableName">Birleşecek Tablo</param>
        /// <returns>T list</returns>
        public List<T> GetAll(string TableName)
        {
            return _context.Set<T>().Include(TableName).AsNoTracking().ToList();
        }
        /// <summary>
        /// Ara tablolar Include
        /// </summary>
        /// <param name="TableName1">İlişkili Tablo 1</param>
        /// <param name="TableName2">İlişkili Tablo 2</param>
        /// <returns>List T</returns>
        public List<T> GetAll(string TableName1, string TableName2)
        {
            return _context.Set<T>().Include(TableName1).Include(TableName2).ToList();
        }
        /// <summary>
        /// Filter List T
        /// </summary>
        /// <param name="expression"></param>
        /// <returns>T List</returns>
        public List<T> GetAll(Expression<Func<T, bool>> expression)
        {
            return _context.Set<T>().AsNoTracking().Where(expression).ToList();
        }
        /// <summary>
        /// Expression Include List
        /// </summary>
        /// <param name="expression"></param>
        /// <returns>T list</returns>
        public List<T> IncludeGetAll(Expression<Func<T, bool>> expression)
        {
            return _context.Set<T>().Include(expression).AsNoTracking().ToList();
        }
        /// <summary>
        /// T varlığını dönderir
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>T</returns>
        public T Update(T entity)
        {
            _context.Set<T>().AddOrUpdate(entity);
            _context.SaveChanges();
            return entity;
        }
        /// <summary>
        /// List Count
        /// </summary>
        /// <returns>Veri sayısı</returns>
        public int Count()
        {
            return GetAll().Count;
        }
        ///// <summary>
        ///// Filtreye göre artan sıralar
        ///// </summary>
        ///// <param name="expression"></param>
        ///// <returns>T</returns>
        //public T OrderBy(Expression<Func<T, object>> expression)
        //{
        //    return _context.Set<T>().OrderBy(expression).AsNoTracking().ToList().FirstOrDefault();
        //}
        ///// <summary>
        ///// Filtreye göre azalan sıralar
        ///// </summary>
        ///// <param name="expression"></param>
        ///// <returns>T</returns>
        //public T OrderByDescending(Expression<Func<T, object>> expression)
        //{
        //    return _context.Set<T>().OrderByDescending(expression).ToList().FirstOrDefault();
        //}
    }
}
