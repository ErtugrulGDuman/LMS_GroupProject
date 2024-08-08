using EntityLayer.Concrete;
using EntityLayer.Concrete._1_SiteArea.LandingPage;
using EntityLayer.Concrete._1_SiteArea.LoginArea;
using EntityLayer.Concrete._2_AdminArea.General;

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
            //optionsBuilder.UseSqlServer("server=EGD\\SQLEXPRESS;database=LMSGroupProjectDb;integrated security=true;"); // Ertugrul Server Bilgileri 
            //optionsBuilder.UseSqlServer("Data Source=ISTPC0307\\SQLEXPRESS;Initial Catalog=GroupProjectDB;User ID=sa;Password=Destek.1453;Trust Server Certificate=True"); //Emin Server Bilgileri
            optionsBuilder.UseSqlServer("server=DESKTOP-E4NV9FV;database=GroupProjectDB;integrated security=true;"); //Tuba Server Bilgileri
        }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Events> Events { get; set; } // Emin "ingilizce grammer plural hatası düzeltildi"
        public DbSet<Founders> Founders { get; set; } // Emin "ingilizce grammer plural hatası düzeltildi"
        public DbSet<Image> Images { get; set; }
        public DbSet<Register> Registers { get; set; } // Emin "ingilizce grammer plural hatası düzeltildi"
        public DbSet<RegisterSubject> RegisterSubjects { get; set; }
        public DbSet<Testimonials> Testimonials { get; set; } // Emin "ingilizce grammer plural hatası düzeltildi"


        // Emin'in ekledikleri
        public DbSet<Courses> Courses { get; set; }
        public DbSet<CourseCategory> CourseCategories { get; set; }
        public DbSet<CourseFeatures> CourseFeatures { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
    }
}
