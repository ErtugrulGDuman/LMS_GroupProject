using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer.Concrete._2_AdminArea.General;

namespace EntityLayer.Concrete
{
    public class Courses
    {
        public int CoursesId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        public TimeSpan Duration { get; set; }

        public int CourseCategoryId { get; set; }
        public virtual CourseCategory  CourseCategory { get; set; }
        public int InstructorId { get; set; }
        public virtual Instructor Instructor { get; set; }
    }
}
