using ConciergeApp.Data;
using ConciergeApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConciergeApp.Infrastructure
{
    public class BusinessRepository : GenericRepository<Business>
    {
        public BusinessRepository(ApplicationDbContext db) : base(db) { }

        public IQueryable<Business> GetBusinesses()
        {
            return _db.Businesses;
        }

        public Business GetBusinessById(int id)
        {
            return _db.Businesses.FirstOrDefault(b => b.Id == id);
        }
    }
}
