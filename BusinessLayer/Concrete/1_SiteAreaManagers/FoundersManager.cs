using BusinessLayer.Abstract._1_SiteAreaServices;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete.Fronthand.LandingPage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete._1_SiteAreaManagers
{
    public class FoundersManager : IFoundersService
    {
        private readonly IFoundersDal _foundersDal;

        public FoundersManager(IFoundersDal foundersDal)
        {
            _foundersDal = foundersDal;
        }

        public void TAdd(Founders t)
        {
            _foundersDal.Insert(t);
        }

        public void TDelete(Founders t)
        {
            _foundersDal.Delete(t);
        }

        public Founders TGetByID(int id)
        {
            return _foundersDal.GetByID(id);
        }

        public List<Founders> TGetList()
        {
            return _foundersDal.GetList();
        }

        public void TUpdate(Founders t)
        {
            _foundersDal.Update(t);
        }
    }
}
