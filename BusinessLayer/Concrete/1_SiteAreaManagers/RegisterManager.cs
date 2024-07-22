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
            _registerDal.Insert(entity);
        }

        public void TDelete(int id)
        {
            _registerDal.Delete(id);
        }

        public void TUpdate(Register entity)
        {
            _registerDal.Update(entity);    
        }

        public List<Register> TGetList()
        {
            return _registerDal.GetListAll();
        }

        public Register TGetByID(int id)
        {
            return _registerDal.GetByID(id);
        }
    }
}
