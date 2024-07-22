using BusinessLayer.Abstract._2_AdminAreaServices;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete._2_AdminArea.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete._2_AdminManagers
{
    public class CourseCategoryManager : ICourseCategoryService
    {
        private readonly ICourseCategoryDal _courseCategoryDal;

        public CourseCategoryManager(ICourseCategoryDal courseCategoryDal)
        {
            _courseCategoryDal = courseCategoryDal;
        }

        public void TDelete(int id)
        {
            _courseCategoryDal.Delete(id);
        }

        public CourseCategory TGetByID(int id)
        {
            return _courseCategoryDal.GetByID(id);
        }

        public List<CourseCategory> TGetList()
        {
            return _courseCategoryDal.GetListAll();
        }

        public void TInsert(CourseCategory entity)
        {
            _courseCategoryDal.Insert(entity);
        }

        public void TUpdate(CourseCategory entity)
        {
            _courseCategoryDal.Update(entity);
        }
    }
}
