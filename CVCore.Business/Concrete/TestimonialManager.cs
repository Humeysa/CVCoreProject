using CVCore.Business.Abstract;
using CVCore.DataAccsess.Abstract;
using CVCore.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVCore.Business.Concrete
{
    public class TestimonialManager : ITestimonialService
    {
        ITestimonialRepository _testimonialRepository;

        public TestimonialManager(ITestimonialRepository testimonialRepository)
        {
            _testimonialRepository = testimonialRepository;
        }

        public void TAdd(Testimonial t)
        {
            _testimonialRepository.Insert(t);
        }

        public void TDelete(Testimonial t)
        {
            _testimonialRepository.Delete(t);
        }

        public Testimonial TGetByID(int id)
        {
            return _testimonialRepository.GetByID(id);
        }

        public List<Testimonial> TGetList()
        {
            return _testimonialRepository.GetList();
        }

        public void TUpdate(Testimonial t)
        {
            _testimonialRepository.Update(t);
        }
    }
}
