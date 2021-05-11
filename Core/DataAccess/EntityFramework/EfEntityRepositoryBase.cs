using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess.EntityFramework
{
   public class EfEntityRepositoryBase<TEntity, TContex> :IEntityRepository<TEntity> 
        where TEntity : class, IEntity, new()
        where TContex : DbContext, new()
    {
        public void Add(TEntity entity)
        {   //Idisposable pattern  implementation of C#
            using (TContex context = new TContex())//Using bitince garbageCollector belleği temizler
            {
                var addedEntity = context.Entry(entity);//referansı yakala
                addedEntity.State = EntityState.Added;//nesneyi ekle
                context.SaveChanges();// değişiklikleri kaydet


            }
        }

        public void Delete(TEntity entity)
        {
            using (TContex context = new TContex())//Using bitince garbageCollector belleği temizler
            {

                var deletedEntity = context.Entry(entity);//referansı yakala
                deletedEntity.State = EntityState.Deleted;//nesneyi sil
                context.SaveChanges();// değişiklikleri kaydet

            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            using (TContex context = new TContex())
            {
                return context.Set<TEntity>().SingleOrDefault(filter);// product tablosunu alıyor listeye dönüştürüyor
            }
        }

    

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            using (TContex context = new TContex())
            {
                return filter == null ? context.Set<TEntity>().ToList() : context.Set<TEntity>().Where(filter).ToList();
                // filtre null ise ilk kısım değise 2 ksıım çalışırfilitre verilmişse uygula ona göre geetir

            }
        }


        public void Update(TEntity entity)
        {
            using (TContex context = new TContex())//Using bitince garbageCollector belleği temizler
            {
                var UpdatedEntity = context.Entry(entity);//referansı yakala
                UpdatedEntity.State = EntityState.Modified;//nesneyi güncelle
                context.SaveChanges();// değişiklikleri kaydet


            }
        }
    }
}
