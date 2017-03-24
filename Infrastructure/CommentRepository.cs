using ConciergeApp.Data;
using ConciergeApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConciergeApp.Infrastructure
{
    public class CommentRepository : GenericRepository<Comment>
    {
        public CommentRepository(ApplicationDbContext db) : base(db) { }

        public IQueryable<Comment> GetComments()
        {
            return _db.Comments;
        }
        public IQueryable<Comment> GetProfileComments(string userId)
        {
            return _db.Comments.Where(f => f.ApplicationUserId == userId);
        }

        public IQueryable<Comment> GetBusinessComments()
        {
            return _db.Comments;
        }
        public Comment GetCommentById(int id)
        {
            return _db.Comments.FirstOrDefault(c => c.Id == id);
        }
        
    }
}
