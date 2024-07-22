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
        
        public void TInsert(Testimonials entity)
        {
            _testimonialsDal.Insert(entity);
        }

        public void TDelete(int id)
        {
            _testimonialsDal.Delete(id);
        }

        public void TUpdate(Testimonials entity)
        {
            _testimonialsDal.Update(entity);
        }

        public List<Testimonials> TGetList()
        {
            return _testimonialsDal.GetListAll();   
        }

        public Testimonials TGetByID(int id)
        {
            return _testimonialsDal.GetByID(id);
        }
    }
}
