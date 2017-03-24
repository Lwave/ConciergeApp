using ConciergeApp.Data;
using ConciergeApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConciergeApp.Infrastructure
{
    public class FriendRepository : GenericRepository<Friend>
    {
        public FriendRepository(ApplicationDbContext db) : base(db) { }

        public Friend GetFriendById(string id, string appUserId)
        {
            return _db.Friends.FirstOrDefault(f => f.FriendId == id && f.ApplicationUserId == appUserId);
        }
    }
}