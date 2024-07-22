using BusinessLayer.Abstract._1_SiteAreaServices;
using EntityLayer.Concrete.SiteArea.RegisterArea;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Abstract;

namespace BusinessLayer.Concrete._1_SiteAreaManagers
{
    public class RegisterSubjectManager : IRegisterSubjectService
    {
        private readonly IRegisterSubjectDal _registerSubjectDal;

        public RegisterSubjectManager(IRegisterSubjectDal registerSubjectDal)
        {
            _registerSubjectDal = registerSubjectDal;
        }

        public void TInsert(RegisterSubject entity)
        {
            _registerSubjectDal.Insert(entity);
        }

        public void TDelete(int id)
        {
            _registerSubjectDal.Delete(id);
        }

        public void TUpdate(RegisterSubject entity)
        {
            _registerSubjectDal.Update(entity);
        }

        public List<RegisterSubject> TGetList()
        {
            return _registerSubjectDal.GetListAll();
        }

        public RegisterSubject TGetByID(int id)
        {
           return _registerSubjectDal.GetByID(id);
        }
    }
}
