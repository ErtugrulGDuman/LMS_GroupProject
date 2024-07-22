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
            throw new NotImplementedException();
        }

        public void TDelete(int id)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Image entity)
        {
            throw new NotImplementedException();
        }

        public List<Image> TGetList()
        {
            throw new NotImplementedException();
        }

        public Image TGetByID(int id)
        {
            throw new NotImplementedException();
        }
    }
}
