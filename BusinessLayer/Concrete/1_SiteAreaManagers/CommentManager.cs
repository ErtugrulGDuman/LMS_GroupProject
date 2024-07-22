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
    public class CommentManager : ICommentService
    {
        private readonly ICommentDal _commentDal;

        public CommentManager(ICommentDal commentDal)
        {
            _commentDal = commentDal;
        }


        public void TInsert(Comment entity)
        {
            _commentDal.Insert(entity);
        }

        public void TDelete(int id)
        {
            _commentDal.Delete(id);
        }

        public void TUpdate(Comment entity)
        {
            _commentDal.Update(entity);
        }

        public List<Comment> TGetList()
        {
            return _commentDal.GetListAll();
        }

        public Comment TGetByID(int id)
        {
            return _commentDal.GetByID(id);
        }
    }
}
