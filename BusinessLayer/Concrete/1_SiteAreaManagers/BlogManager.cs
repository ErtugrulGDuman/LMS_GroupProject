using BusinessLayer.Abstract._1_SiteAreaServices;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete.Fronthand.LandingPage;
using GroupProject.DataAccessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete._1_SiteAreaManagers
{
    public class BlogManager : IBlogService
    {
        private readonly IBlogDal _blogDal;

        public BlogManager(IBlogDal blogDal)
        {
            _blogDal = blogDal;
        }


        public void TInsert(Blog entity)
        {
            _blogDal.Insert(entity);
        }

        public void TDelete(int id)
        {
            _blogDal.Delete(id);
        }

        public void TUpdate(Blog entity)
        {
            _blogDal.Update(entity);
        }

        public List<Blog> TGetList()
        {
            return _blogDal.GetListAll();
        }

        public Blog TGetByID(int id)
        {
            return _blogDal.GetByID(id);
        }
    }
}
