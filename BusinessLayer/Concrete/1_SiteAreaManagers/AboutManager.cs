using BusinessLayer.Abstract._1_SiteAreaServices;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete.Fronthand.LandingPage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete._1_SiteAreaManagers
{
    public class AboutManager : IAboutService
    {
        private readonly IAboutDal _aboutDal;

        public AboutManager(IAboutDal aboutDal)
        {
            _aboutDal = aboutDal;
        }
        public void TInsert(About entity)
        {
            _aboutDal.Insert(entity);
        }

        public void TDelete(int id)
        {
            _aboutDal.Delete(id);
        }

        public void TUpdate(About entity)
        {
            _aboutDal.Update(entity);
        }

        public List<About> TGetList()
        {
            return _aboutDal.GetListAll();
        }

        public About TGetByID(int id)
        {
            return _aboutDal.GetByID(id);
        }
    }
}
