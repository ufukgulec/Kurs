﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Kurs.Interfaces
{
    public interface IGenericService<T> : IDisposable
    {
        /// <summary>
        /// T varlığını ekleme
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>T</returns>
        T Add(T entity);
        /// <summary>
        /// Id'ye göre varlık getir
        /// </summary>
        /// <param name="id"></param>
        /// <returns>T</returns>
        T Get(int id);
        /// <summary>
        /// List Count
        /// </summary>
        /// <returns>Veri sayısı</returns>
        int Count();
        /// <summary>
        /// Tüm T listesi
        /// </summary>
        /// <returns>T List</returns>
        List<T> GetAll();
        /// <summary>
        /// Filter List T
        /// </summary>
        /// <param name="expression"></param>
        /// <returns>T List</returns>
        List<T> GetAll(Expression<Func<T, bool>> expression);
        /// <summary>
        /// Include List
        /// </summary>
        /// <param name="TableName">Birleşecek Tablo</param>
        /// <returns>T list</returns>
        List<T> GetAll(string TableName);
        /// <summary>
        /// Ara tablolar Include
        /// </summary>
        /// <param name="TableName1">İlişkili Tablo 1</param>
        /// <param name="TableName2">İlişkili Tablo 2</param>
        /// <returns>List T</returns>
        List<T> GetAll(string TableName1, string TableName2);
        /// <summary>
        /// Expression Include List
        /// </summary>
        /// <param name="expression"></param>
        /// <returns>List T</returns>
        List<T> IncludeGetAll(Expression<Func<T, bool>> expression);
        /// <summary>
        /// Id'ye göre varlık silme
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Bool</returns>
        bool Delete(int id);
        /// <summary>
        /// T varlığını siler
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>Bool</returns>
        bool Delete(T entity);
        /// <summary>
        /// T varlığını dönderir
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>T</returns>
        T Update(T entity);
        ///// <summary>
        ///// Filtreye göre artan sıralar
        ///// </summary>
        ///// <param name="expression"></param>
        ///// <returns>T</returns>
        //T OrderBy(Expression<Func<T, object>> expression);
        ///// <summary>
        ///// Filtreye göre azalan sıralar
        ///// </summary>
        ///// <param name="expression"></param>
        ///// <returns>T</returns>
        //T OrderByDescending(Expression<Func<T, object>> expression);

    }
}