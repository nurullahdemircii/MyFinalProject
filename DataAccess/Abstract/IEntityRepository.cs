using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    //  public interface IEntityRepository<T> where T:class,IEntity, new()
    //  Kod Açıklaması:
    //  <T> Sınırlandırılması: Sadece Veritabanı nesneleri tanımlanabilsin.
    //  Bunun İsmi Generic Constraint'tir.
    //  class: Referans tip olabilir demektir.
    //  IEntity: IEntity olabilir ya da IEntity implemente edebilen bir nesne olabilir.
    //  new(): New'lenebilir olmalıdır.
    public interface IEntityRepository<T> where T:class,IEntity, new()
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        List<T> GetAllByCategory(int categoryId);
    }
}
//  ->  Expression:
//      *   Fonksiyonumuzun içerisine LINQ kodu ile istenilen filtreye göre veritabanından sonuç döndürmesidir.
//      *   filter = null ile istenilirse bir filtre tanımlanmayabilir özelliği kazanmıştır.
//      *   filter ile filtre vermek zorunludur özelliği kazanmıştır.
//  ->  T Get(Expression<Func<T, bool>> filter); method'u ile istenilen tek bir veri çekilebilir.















































