﻿using DataAccessLayer.Repository;
using EntityLayer.Concrete.SiteArea.RegisterArea;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Concrete;

namespace DataAccessLayer.EntityFramework
{
    public class EfRegisterSubject : GenericRepository<RegisterSubject>
    {
        public EfRegisterSubject(Context context) : base(context)
        {
        }
    }
}

