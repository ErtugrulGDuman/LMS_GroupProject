using BusinessLayer.Abstract._2_AdminAreaServices;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete._2_AdminManagers
{
    public class CoursesManager : ICoursesService
    {
        private readonly ICoursesDal _coursesDal;

        public CoursesManager(ICoursesDal coursesDal)
        {
            _coursesDal = coursesDal;
        }


        public void TInsert(Courses entity)
        {
            _coursesDal.Insert(entity);
            
        }

        public void TDelete(int id)
        {
            _coursesDal.Delete(id);
            
        }

        public void TUpdate(Courses entity)
        {
            _coursesDal.Update(entity);
        }

        public List<Courses> TGetList()
        {
            return _coursesDal.GetListAll();
        }

        public Courses TGetByID(int id)
        {
            return _coursesDal.GetByID(id);
        }
    }
}
