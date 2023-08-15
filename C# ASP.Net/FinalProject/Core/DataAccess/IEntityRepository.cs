using Core.Entities; // IEntity'i kullanabilmek için ekledik
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

//core katmanı diğer katmanları referans almaz
//Core katmanı evrensel katmandır
namespace Core.DataAccess
{
    // generic constraint
    // class : referans tip
    // IEntity : IEntity olabilir veya IEntity implemente eden bir nesne olabilir
    // new() : new'lenebilir olmalı
    // Burda yaptığımız işlem ile IEntity'i implemente eden nesneyi kısıtlıyoruz
    //Yani T tipinde sadece IEntity'i implemente eden nesneleri yazabiliriz
    //newlenebilir özelliği eklediğimiz için ICategoryDal yazamayız
    //Çünkü ICategoryDal interface'dir ve newlenemez
    public interface IEntityRepository<T> where T: class, IEntity,new()
        
    {
        List<T> GetAll(Expression<Func<T,bool>> filter = null);
        T Get(Expression<Func<T, bool>> filter); // Tek bir data getirecek
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);



    }
}
