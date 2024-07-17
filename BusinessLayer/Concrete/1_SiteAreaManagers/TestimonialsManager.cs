using BusinessLayer.Abstract._1_SiteAreaServices;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete.Fronthand.LandingPage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete._1_SiteAreaManagers
{
    public class TestimonialsManager : ITestimonialsService
    {
        private readonly ITestimonialsDal _testimonialsDal;

        public TestimonialsManager(ITestimonialsDal testimonialsDal)
        {
            _testimonialsDal = testimonialsDal;
        }

        public void TAdd(Testimonials t)
        {
            _testimonialsDal.Insert(t);
        }

        public void TDelete(Testimonials t)
        {
            _testimonialsDal.Delete(t);
        }

        public Testimonials TGetByID(int id)
        {
           return _testimonialsDal.GetByID(id);
        }

        public List<Testimonials> TGetList()
        {
            return _testimonialsDal.GetList();
        }

        public void TUpdate(Testimonials t)
        {
            _testimonialsDal.Update(t);
        }
    }
}
