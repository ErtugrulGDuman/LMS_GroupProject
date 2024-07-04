using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete.Fronthand.LandingPage
{
    public class Founders
    {
        public int FoundersId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public string ImageUrl { get; set; }

        public string FacebookUrl { get; set; }

        public string TwitterUrl { get; set; }

        public string Instagram { get; set; }

        public string LinkedinUrl
        {
            get; set;


        }
    }
}
