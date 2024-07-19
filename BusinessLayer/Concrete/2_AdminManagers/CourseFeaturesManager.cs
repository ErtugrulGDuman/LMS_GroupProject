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
    public class CourseFeaturesManager : ICourseFeaturesServices
    {
        private readonly ICourseFeaturesDal _courseFeaturesDal;

        public CourseFeaturesManager(ICourseFeaturesDal courseFeaturesDal)
        {
            _courseFeaturesDal = courseFeaturesDal;
        }

        public void TAdd(CourseFeatures t)
        {
            _courseFeaturesDal.Insert(t);
        }

        public void TDelete(CourseFeatures t)
        {
            _courseFeaturesDal.Delete(t);
        }

        public CourseFeatures TGetByID(int id)
        {
            return _courseFeaturesDal.GetByID(id);
        }

        public List<CourseFeatures> TGetList()
        {
            return _courseFeaturesDal.GetList();
        }

        public void TUpdate(CourseFeatures t)
        {
            _courseFeaturesDal.Update(t);
        }
    }
}
