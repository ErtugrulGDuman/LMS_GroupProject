﻿using DataAccessLayer.Concrete;
using GroupProject.DataAccessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository
{


    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        Context _context = new Context();


        public void Insert(T entity)
        {
            _context.Set<T>().Add(entity);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var value = _context.Set<T>().Find(id);
            _context.Set<T>().Remove(value);
            _context.SaveChanges();
        }

        public void Update(T entity)
        {
            _context.Set<T>().Update(entity);
            _context.SaveChanges();
        }

        public List<T> GetListAll()
        {
            return _context.Set<T>().ToList();
        }


        public T GetByID(int id)
        {
            return _context.Set<T>().Find(id);
        }
    }
}
