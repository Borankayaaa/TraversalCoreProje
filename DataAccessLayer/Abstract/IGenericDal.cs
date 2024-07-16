using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IGenericDal<T> // new Item oluşturarak uzun uzun hepsine crud işlemleri yazmak yerine Generic sınıfı kullanarak tüm sınıflara miras vereceğiz...
    {
        void Insert(T t);
        void Delete(T t);
        void Update(T t);
        List<T> GetList();

    }
}
