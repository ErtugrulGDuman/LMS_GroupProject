using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOLayer._2_AdminAreaDto.GeneralDto.CourseCategoryDto
{
    public class UpdateCourseCategoryDto
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string ImageUrl { get; set; }
        public string IconUrl { get; set; }
    }
}
