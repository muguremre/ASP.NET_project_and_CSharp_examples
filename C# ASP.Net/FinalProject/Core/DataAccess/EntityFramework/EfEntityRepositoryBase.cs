using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess.EntityFramework
{
    public class EfEntityRepositoryBase<TEntity,TContext>: IEntityRepository<TEntity>
        where TEntity : class , IEntity, new()
        where TContext : DbContext, new()
    {
        public void Add(TEntity entity)
        {
            // IDisposable pattern implementation of c#
            using (TContext context = new TContext()) // using içerisinde yazılan nesneler using bitince garbage collector tarafından bellekten atılır
            {
                var addedEntity = context.Entry(entity); // referansı yakala
                addedEntity.State = EntityState.Added; // ekle
                context.SaveChanges(); // değişiklikleri kaydet
            }
        }

        public void Delete(TEntity entity)
        {
            // IDisposable pattern implementation of c#
            using (TContext context = new TContext()) // using içerisinde yazılan nesneler using bitince garbage collector tarafından bellekten atılır
            {
                var deletedEntity = context.Entry(entity); // referansı yakala
                deletedEntity.State = EntityState.Deleted; //sil
                context.SaveChanges(); // değişiklikleri kaydet
            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            using (TContext context = new TContext()) // using içerisinde yazılan nesneler using bitince garbage collector tarafından bellekten atılır
            {
                return context.Set<TEntity>().SingleOrDefault(filter); // tek bir data getir
            }
        }



        public List<TEntity> GetAll(Expression<Func<TEntity, bool>>? filter = null)
        {
            using (TContext context = new TContext())
            {
                // filter null ise tüm datayı getir, değilse filtreleyerek getir
                return filter == null ? context.Set<TEntity>().ToList() :
                    context.Set<TEntity>().Where(filter).ToList();
            }
        }

        public void Update(TEntity entity)
        {
            // IDisposable pattern implementation of c#
            using (TContext context = new TContext()) // using içerisinde yazılan nesneler using bitince garbage collector tarafından bellekten atılır
            {
                var updatedEntity = context.Entry(entity); // referansı yakala
                updatedEntity.State = EntityState.Modified; //güncelle
                context.SaveChanges(); // değişiklikleri kaydet
            }
        }
    }
}
