using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Instructor
    {
        public int InstructorId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
