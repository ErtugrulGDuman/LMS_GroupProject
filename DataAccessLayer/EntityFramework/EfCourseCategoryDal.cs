using DataAccessLayer.Abstract;
using DataAccessLayer.Repository;
using EntityLayer.Concrete._2_AdminArea.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Concrete;

namespace DataAccessLayer.EntityFramework
{
    public class EfCourseCategoryDal: GenericRepository<CourseCategory>, ICourseCategoryDal
    {
        public EfCourseCategoryDal(Context context) : base(context)
        {
        }
    }
}
