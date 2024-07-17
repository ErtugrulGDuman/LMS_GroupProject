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
    public class EventsManager : IEventsService
    {
        private readonly IEventsDal _eventsDal;

        public EventsManager(IEventsDal eventsDal)
        {
            _eventsDal = eventsDal;
        }

        public void TAdd(Events t)
        {
            _eventsDal.Insert(t);
        }

        public void TDelete(Events t)
        {
            _eventsDal.Delete(t);
        }

        public Events TGetByID(int id)
        {
            return _eventsDal.GetByID(id);
        }

        public List<Events> TGetList()
        {
            return _eventsDal.GetList();
        }

        public void TUpdate(Events t)
        {
            _eventsDal.Update(t);
        }
    }
}
