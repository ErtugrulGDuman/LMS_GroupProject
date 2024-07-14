using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOLayer._1_SiteAreaDto.LandingPageDto.EventsDto
{
    public class CreateEventsDto
    {

        public string ImageUrl { get; set; }
        public DateTime Date { get; set; }
        public string Title { get; set; }
        public TimeSpan Time { get; set; }
        public string Location { get; set; }
        public string Description { get; set; }
    }
}
