using ConciergeApp.Data;
using ConciergeApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ConciergeApp.Infrastructure
{
    public class GenericRepository<T> where T : class
    {
        protected ApplicationDbContext _db;
        public GenericRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        //Get
        public IQueryable<T> List()
        {
            return _db.Set<T>();
        }
        //Get {id}
        public ApplicationUser GetUserById(string id)
        {
            return _db.Users.FirstOrDefault(u => u.Id == id);
        }
        //Get {userName}
        public ApplicationUser GetUserByUserName(string userName)
        {
            return _db.Users.FirstOrDefault(u => u.UserName == userName);
        }
        //Post
        public void Add(T value)
        {
            _db.Set<T>().Add(value);
            _db.SaveChanges();
        }
        //Delete
        public void Delete(T value)
        {
            _db.Set<T>().Remove(value);
            _db.SaveChanges();
        }
        //Save Changes
        public void SaveChanges()
        {
            _db.SaveChanges();
        }
    }
}