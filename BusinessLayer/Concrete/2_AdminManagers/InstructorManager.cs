using BusinessLayer.Abstract._2_AdminAreaServices;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete._2_AdminManagers
{
    public class InstructorManager : IInstructorService
    {
        private readonly IInstructorDal _ınstructorDal;

        public InstructorManager(IInstructorDal ınstructorDal)
        {
            _ınstructorDal = ınstructorDal;
        }

        public void TDelete(int id)
        {
            _ınstructorDal.Delete(id);  
        }

        public Instructor TGetByID(int id)
        {
            return _ınstructorDal.GetByID(id);
        }

        public List<Instructor> TGetList()
        {
            return _ınstructorDal.GetListAll();
        }

        public void TInsert(Instructor entity)
        {
            _ınstructorDal.Insert(entity);
        }

        public void TUpdate(Instructor entity)
        {
            _ınstructorDal.Update(entity);
        }
    }
}
