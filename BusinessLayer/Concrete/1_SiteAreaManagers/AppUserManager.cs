using BusinessLayer.Abstract._1_SiteAreaServices;
using EntityLayer.Concrete._1_SiteArea.LoginArea;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Abstract;

namespace BusinessLayer.Concrete._1_SiteAreaManagers
{
    public class AppUserManager : IAppUserService
    {
        private readonly IAppUserDal _appUserDal;

        public AppUserManager(IAppUserDal appUserDal)
        {
            _appUserDal = appUserDal;
        }

        public void TInsert(AppUser entity)
        {
            _appUserDal.Insert(entity);
        }

        public void TDelete(int id)
        {
            _appUserDal.Delete(id);
        }

        public void TUpdate(AppUser entity)
        {
            _appUserDal.Update(entity);
        }

        public List<AppUser> TGetList()
        {
            return _appUserDal.GetListAll();
        }

        public AppUser TGetByID(int id)
        {
            return _appUserDal.GetByID(id);
        }
    }
}
