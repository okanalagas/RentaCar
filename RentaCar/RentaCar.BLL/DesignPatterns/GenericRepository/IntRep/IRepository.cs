using RentaCar.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RentaCar.BLL.DesignPatterns.GenericRepository.IntRep
{
    public interface IRepository<T> where T : BaseEntity // IRepository içine sadece t si baseentitiy olan bir tip alanbilir.
    {
        //List Commands Listeleme Raporlama Komutları

        List<T> GetAll(); // T neyse o listeyi dönderen bir metot
        List<T> GetActive(); // T neyse o t nin aktif olanlarını dönderen bir metot
        List<T> GetModified(); //Güncellenmiş olanları dönderen
        List<T> GetDeleted(); //Silinmiş olanları dönderen metot


        //Modify Commands Ekleme Silme Güncelleme yapacak komutlar

        void Add(T item); // t tipinde ekleme yapar
        void AddRange(List<T> list); // birden fazla t tipinde ekleme yapar.
        void Delete(T item); // Pasife çekme gerçekten silmez.
        void DeleteRange(List<T> list); // list tipinde silme 
        void Update(T item); // Güncelleme
        void UpdateRange(List<T> list); //Liste halinde güncelleme
        void Destroy(T item);// Veri yoketmek için kullanılır.
        void DestroyRange(List<T> list);   // liste halinde yok etmek için


        //Linq Commands (Dile Entegre Edilmiş Sorgular) db.products.Where(x=>x.name.contains("be")).ToList(); gibi.. Bu expression tipindedir.

        List<T> Where(Expression<Func<T, bool>> expression); //Yukardaki açıklamada => kullanıldığı anda x kendisini whereden önceki sınıfa ait bir nesne olarak görmeye başlar yani product olur ve ona ait özelliklere erişir. Yukardaki komuta benzer şekilde t ne ise ona göre işlem yapıyor örn productsa product category ise category; bool kısmı ise contains gibi true false metotları
        bool Any(Expression<Func<T, bool>> expression); //var mı yok mu sorgulaması için
        T FirstOrDefault(Expression<Func<T, bool>> expression);
        object Select(Expression<Func<T, object>> expression);   //db.Product.Select(X=>x new{}) tipi için 
        IQueryable<X> Select<X>(Expression<Func<T, X>> expression); //db.Product.Select(X=>x new ProductDTO{}) dto vb data response model araştır.


        //Find Command

        T Find(int id);
    }
}
