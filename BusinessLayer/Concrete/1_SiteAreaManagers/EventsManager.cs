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
        
        public void TInsert(Events entity)
        {
            _eventsDal.Insert(entity);
        }

        public void TDelete(int id)
        {
            _eventsDal.Delete(id);
        }

        public void TUpdate(Events entity)
        {
            _eventsDal.Update(entity);
        }

        public List<Events> TGetList()
        {
           return _eventsDal.GetListAll();
        }

        public Events TGetByID(int id)
        {
            return _eventsDal.GetByID(id);
        }
    }
}
