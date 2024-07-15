using EntityLayer.Concrete;
using EntityLayer.Concrete._1_SiteArea.LandingPage;
using EntityLayer.Concrete._1_SiteArea.LoginArea;
using EntityLayer.Concrete.Fronthand.LandingPage;
using EntityLayer.Concrete.SiteArea.ContactPage;
using EntityLayer.Concrete.SiteArea.RegisterArea;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=EGD\\SQLEXPRESS;database=LMSGroupProjectDb;integrated security=true;");
        }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Events> Eventses { get; set; }
        public DbSet<Founders> Founderses { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Register> Registers { get; set; }
        public DbSet<RegisterSubject> RegisterSubjects { get; set; }
        public DbSet<Testimonials> Testimonialses { get; set; }
    }
}
