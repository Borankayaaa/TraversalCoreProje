using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IGenericService<T> // Business'e gelmeden önce business tarafından tanımlanacak  bütün metodlar buradan geçip business ve concrete ye geçecek
    {
        void TAdd(T t);
        void TDelete(T t);
        void TUpdate(T t);
        List<T> GetList();
        T GetById(int id);




    }
}
