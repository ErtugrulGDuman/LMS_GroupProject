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
            throw new NotImplementedException();
        }

        public void TDelete(int id)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(RegisterSubject entity)
        {
            throw new NotImplementedException();
        }

        public List<RegisterSubject> TGetList()
        {
            throw new NotImplementedException();
        }

        public RegisterSubject TGetByID(int id)
        {
            throw new NotImplementedException();
        }
    }
}
