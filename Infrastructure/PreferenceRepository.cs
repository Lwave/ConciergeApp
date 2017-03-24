using ConciergeApp.Data;
using ConciergeApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConciergeApp.Infrastructure
{
    public class PreferenceRepository: GenericRepository<Preference>
    {
        public PreferenceRepository(ApplicationDbContext db) : base(db) { }
        
        public Preference GetCommentById(int id)
        {
            return _db.Preferences.FirstOrDefault(p => p.Id == id);
        }
    }
}
