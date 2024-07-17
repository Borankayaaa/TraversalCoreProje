using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class AboutManager : IAboutService
    {
        IAboutDal _aboutDal;

        public AboutManager(IAboutDal   aboutDal) //Bu Yapının Adı dependency injection
        {
                _aboutDal = aboutDal;       //Bu sayede DataAccess içerisindeki verilere erişim sağlayabildik //_aboutDal'ı çağırdığımda crud işlemlerini almalıyım amacım bu(IGenericDal'ın içerisinde olanlar)
        }
        public About GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<About> GetList()
        {
           return _aboutDal.GetList();
        }

        public void TAdd(About t)
        {
           _aboutDal.Insert(t);
        }

        public void TDelete(About t)
        {
           _aboutDal.Delete(t);
        }

        public void TUpdate(About t)
        {
            _aboutDal.Update(t);
        }
    }
}
