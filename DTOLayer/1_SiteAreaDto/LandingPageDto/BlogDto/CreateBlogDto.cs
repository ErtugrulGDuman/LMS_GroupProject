﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOLayer._1_SiteAreaDto.LandingPageDto.BlogDto
{
    public class CreateBlogDto
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public string Writer { get; set; }
        public DateTime Date { get; set; }
    }
}
