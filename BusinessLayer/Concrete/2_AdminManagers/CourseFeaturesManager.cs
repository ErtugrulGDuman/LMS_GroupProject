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

        public void TInsert(CourseFeatures entity)
        {
            _courseFeaturesDal.Insert(entity);
        }

        public void TDelete(int id)
        {
            _courseFeaturesDal.Delete(id);
        }

        public void TUpdate(CourseFeatures entity)
        {
            _courseFeaturesDal.Update(entity);
        }

        public List<CourseFeatures> TGetList()
        {
            return _courseFeaturesDal.GetListAll();
        }

        public CourseFeatures TGetByID(int id)
        {
            return _courseFeaturesDal.GetByID(id);
        }
    }
}