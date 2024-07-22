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
    public class RegisterManager : IRegisterService
    {
        private readonly IRegisterDal _registerDal;

        public RegisterManager(IRegisterDal registerDal)
        {
            _registerDal = registerDal;
        }

        public void TInsert(Register entity)
        {
            throw new NotImplementedException();
        }

        public void TDelete(int id)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Register entity)
        {
            throw new NotImplementedException();
        }

        public List<Register> TGetList()
        {
            throw new NotImplementedException();
        }

        public Register TGetByID(int id)
        {
            throw new NotImplementedException();
        }
    }
}
