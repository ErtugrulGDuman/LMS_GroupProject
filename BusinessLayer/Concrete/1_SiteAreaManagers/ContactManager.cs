using BusinessLayer.Abstract._1_SiteAreaServices;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete.SiteArea.ContactPage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete._1_SiteAreaManagers
{
    public class ContactManager : IContactService
    {
        private readonly IContactDal _contactDal;

        public ContactManager(IContactDal contactDal)
        {
            _contactDal = contactDal;
        }

        public void TInsert(Contact entity)
        {
            _contactDal.Insert(entity);
        }

        public void TDelete(int id)
        {
            _contactDal.Delete(id);
        }

        public void TUpdate(Contact entity)
        {
            _contactDal.Update(entity);
        }

        public List<Contact> TGetList()
        {
            return _contactDal.GetListAll();
        }

        public Contact TGetByID(int id)
        {
            return _contactDal.GetByID(id);
        }
    }
}
