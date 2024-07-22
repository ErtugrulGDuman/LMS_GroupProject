using DataAccessLayer.Abstract;
using DataAccessLayer.Repository;
using EntityLayer.Concrete._1_SiteArea.LandingPage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Concrete;

namespace DataAccessLayer.EntityFramework
{
    public class EfCommentDal : GenericRepository<Comment>, ICommentDal
    {
        public EfCommentDal(Context context) : base(context)
        {
        }
    }
}

