using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete._2_AdminArea.General
{
    public class CourseFeatures
    {
        public int CourseFeaturesId { get; set; }
        public string Language { get; set; }
        public TimeSpan Duration { get; set; }
        public string Level { get; set; }
        public int ResgisteredPerson { get; set; }
    }
}
