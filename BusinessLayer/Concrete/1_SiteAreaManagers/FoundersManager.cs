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

        public void TInsert(Founders entity)
        {
            _foundersDal.Insert(entity);
        }

        public void TDelete(int id)
        {
            _foundersDal.Delete(id);
        }

        public void TUpdate(Founders entity)
        {
            _foundersDal.Update(entity);
        }

        public List<Founders> TGetList()
        {
            return _foundersDal.GetListAll();
        }

        public Founders TGetByID(int id)
        {
            return _foundersDal.GetByID(id);
        }
    }
}
