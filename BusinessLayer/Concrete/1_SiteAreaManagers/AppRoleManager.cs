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
    public class AppRoleManager : IAppRoleService
    {
        private readonly IAppRoleDal _appRoleDal;

        public AppRoleManager(IAppRoleDal appRoleDal)
        {
            _appRoleDal = appRoleDal;
        }

        public void TInsert(AppRole entity)
        {
            _appRoleDal.Insert(entity);
        }

        public void TDelete(int id)
        {
            _appRoleDal.Delete(id);
        }

        public void TUpdate(AppRole entity)
        {
            _appRoleDal.Update(entity);
        }

        public List<AppRole> TGetList()
        {
            return _appRoleDal.GetListAll();
        }

        public AppRole TGetByID(int id)
        {
            return _appRoleDal.GetByID(id);
        }
    }
}
