using DataAccessLayer.Abstract;
using DataAccessLayer.Repository;
using EntityLayer.Concrete.Fronthand.LandingPage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Concrete;

namespace DataAccessLayer.EntityFramework
{
    public class EfTestimonialsDal : GenericRepository<Testimonials>, ITestimonialsDal
    {
        public EfTestimonialsDal(Context context) : base(context)
        {
        }
    }
}

