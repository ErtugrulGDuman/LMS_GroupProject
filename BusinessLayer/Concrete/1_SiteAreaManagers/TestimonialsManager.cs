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
            throw new NotImplementedException();
        }

        public void TDelete(int id)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Testimonials entity)
        {
            throw new NotImplementedException();
        }

        public List<Testimonials> TGetList()
        {
            throw new NotImplementedException();
        }

        public Testimonials TGetByID(int id)
        {
            throw new NotImplementedException();
        }
    }
}
