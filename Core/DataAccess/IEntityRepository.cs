using Core.Entites;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess
{   //bu interface genel operasyonları tuttugu için bu katmanda (Core) katmanında tutulur.
    //generic constraint-kısıt
    //class : referans tip olabilir. yanı int olamaz 
    // IEntity : ya IEntity olabilir ya da IEntity ı implemente eden bir nesne olabilir
    // new() : new'lenebilir olmalı 
    public interface IEntityRepository <T> where T : class , IEntity, new ()
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
       
    }
}
