using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class TestimonialManager : ITestimonialService
    {
        ITestimonialDal _testimonialDal;

        public TestimonialManager(ITestimonialDal testimonialDal)
        {
            _testimonialDal = testimonialDal;
        }

        public EntityLayer.Concrete.Testimonial GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<EntityLayer.Concrete.Testimonial> GetList()
        {
            return _testimonialDal.GetList();
        }

        public void TAdd(EntityLayer.Concrete.Testimonial t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(EntityLayer.Concrete.Testimonial t)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(EntityLayer.Concrete.Testimonial t)
        {
            throw new NotImplementedException();
        }
    }
}
