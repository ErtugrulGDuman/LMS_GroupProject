using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOLayer._2_AdminAreaDto.GeneralDto.CourseFeaturesDto
{
    public class ResultCourseFeaturesDto
    {
        public int CourseFeaturesId { get; set; }
        public string Language { get; set; }
        public TimeSpan Duration { get; set; }
        public string Level { get; set; }
        public int ResgisteredPerson { get; set; }
    }
}
