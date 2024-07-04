using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete.Fronthand.LandingPage
{
    public class Events
    {
        public int EventsId { get; set; }
        public string ImageUrl { get; set; }
        public DateTime Date { get; set; }
        public string Title { get; set; }
        public TimeSpan Time { get; set; }
        public string Konum { get; set; }
        public string Description { get; set; }
    }
}
