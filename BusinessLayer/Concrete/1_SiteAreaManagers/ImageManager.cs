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
        private readonly IImageDal _imageDal;

        public ImageManager(IImageDal imageDal)
        {
            _imageDal = imageDal;
        }


        public void TInsert(Image entity)
        {
            _imageDal.Insert(entity);
        }

        public void TDelete(int id)
        {
            _imageDal.Delete(id);
        }

        public void TUpdate(Image entity)
        {
            _imageDal.Update(entity);
        }

        public List<Image> TGetList()
        {
            return _imageDal.GetListAll();
        }

        public Image TGetByID(int id)
        {
            return _imageDal.GetByID(id);
        }
    }
}
