using BusinessLayer.Abstract._1_SiteAreaServices;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete._1_SiteArea.LandingPage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete._1_SiteAreaManagers
{
    public class ImageManager : IImageServices
    {
        private readonly IImageDal _ımageDal;

        public ImageManager(IImageDal ımageDal)
        {
            _ımageDal = ımageDal;
        }

        public void TAdd(Image t)
        {
            _ımageDal.Insert(t);
        }

        public void TDelete(Image t)
        {
            _ımageDal.Delete(t);
        }

        public Image TGetByID(int id)
        {
            return _ımageDal.GetByID(id);
        }

        public List<Image> TGetList()
        {
            return _ımageDal.GetList();
        }

        public void TUpdate(Image t)
        {
            _ımageDal.Update(t);
        }
    }
}
