using ConciergeApp.Data;
using ConciergeApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ConciergeApp.Infrastructure
{
    public class FeedbackRepository : GenericRepository<Feedback>
    {
        public FeedbackRepository(ApplicationDbContext db) : base(db) { }

        public IQueryable<Feedback> GetProfileFeedbacks(string userId)
        {
            return _db.Feedbacks.Where (f => f.ApplicationUserId == userId);
        }

        public IQueryable<Feedback> GetBusinessFeedbacks()
        {
            return _db.Feedbacks;
        }

        public Feedback GetFeedbackById(int id)
        {
            return _db.Feedbacks.FirstOrDefault(f => f.Id == id);
        }
        //public IQueryable<Feedback> GetFeedbacks()
        //{
        //    return _db.Feedbacks;
        //}

        
    }
}
