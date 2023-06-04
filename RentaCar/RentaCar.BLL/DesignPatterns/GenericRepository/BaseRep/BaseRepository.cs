using RentaCar.BLL.DesignPatterns.GenericRepository.IntRep;
using RentaCar.BLL.DesignPatterns.SingletonPattern;
using RentaCar.DAL.Context;
using RentaCar.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RentaCar.BLL.DesignPatterns.GenericRepository.BaseRep
{
    public abstract class BaseRepository<T> : IRepository<T> where T : BaseEntity
    {
        MyContext _db;
        public BaseRepository()
        {
            _db = DBTool.DbInstance;  //single pattern desteği alınır.
        }

        void Save() //Sürekli db savechanges yazmamk için böyle bir metot açtık 
        {
            _db.SaveChanges();
        }
        public void Add(T item)
        {
            _db.Set<T>().Add(item); // db yi kendini t ye göre set et ve add metodunu kullan dedik
            Save();
        }

        public void AddRange(List<T> list)
        {
            _db.Set<T>().AddRange(list); //bu metotlar entity frameworkun kendi içersinde var 
            Save();
        }

        public bool Any(Expression<Func<T, bool>> expression)
        {
            return _db.Set<T>().Any(expression);
        }

        public void Delete(T item)
        {
            item.Status = Entities.Enums.DataStatus.Deleted;   //bu entitiy frameworkte yok biz custom yazdık 
            item.DeletedDate = DateTime.Now;
            Save();
        }

        public void DeleteRange(List<T> list)
        {
            foreach (T item in list) //Döndürdüğün tüm itemler T tipindedir
            {                
                Delete(item); // bizim delete metodumuz 
            }
        }

        public void Destroy(T item)
        {
            _db.Set<T>().Remove(item); //Entity frameworkun kendi metodu veriyi direkt yok eder. 
            Save();
        }

        public void DestroyRange(List<T> list)
        {
            _db.Set<T>().RemoveRange(list);
            Save();
        }

        public T Find(int id)
        {
            return _db.Set<T>().Find(id);
        }

        public T FirstOrDefault(Expression<Func<T, bool>> expression)
        {
            return _db.Set<T>().FirstOrDefault(expression);
        }

        public List<T> GetActive()
        {
            return Where(x => x.Status != Entities.Enums.DataStatus.Deleted); //bizim metodumuz aracılığıyla silinmemişleri yani aktifleri getiririz. 
        }

        public List<T> GetAll()
        {
            return _db.Set<T>().ToList(); //tüm itemleri getirir.
        }

        public List<T> GetDeleted()
        {
            return Where(x => x.Status == Entities.Enums.DataStatus.Deleted); // Bizim metodumuz aracılığıyla silinmişleri getirir.
        }

        public List<T> GetModified()
        {
            return Where(x => x.Status == Entities.Enums.DataStatus.Updated);
        }

        public object Select(Expression<Func<T, object>> expression)
        {
            return _db.Set<T>().Select(expression);
        }

        public IQueryable<X> Select<X>(Expression<Func<T, X>> expression)
        {
            return _db.Set<T>().Where(x => x.Status != Entities.Enums.DataStatus.Deleted).Select(expression); // listeleme yaparken sorgulama yaparken kullanacağımız metot oldugu için silinmiş öğeleri listelememek adına where şartı ekledik...    
        }

        public void Update(T item)
        {
            item.Status = Entities.Enums.DataStatus.Updated; // itemin statusu updateda çekilir.
            item.ModifiedDate = DateTime.Now;
            T unchangedEntity = Find(item.Id);  // kendi find metodumuzla değiştirmek istediğimiz nesneyi yakalarız.
            _db.Entry(unchangedEntity).CurrentValues.SetValues(item); //databaseye git bir entry sağla yapacağımız değişiklik için bir hazırlık yapıyoruz. ardından o nesnenin mevcut değerlerini yeni değerlerle değiştir diyoruz.
            Save();
        }

        public void UpdateRange(List<T> list)
        {
            foreach (T item in list)
            {
                Update(item); // kendi metodumuz aracılığıyla güncelleme yapıyoruz.
            }
        }

        public List<T> Where(Expression<Func<T, bool>> expression)
        {
            return _db.Set<T>().Where(expression).ToList();
        }
    }
}
