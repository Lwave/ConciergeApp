using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ConciergeApp.Infrastructure;
using ConciergeApp.Models;
using ConciergeApp.ViewModels;

namespace ConciergeApp.Services
{
    public class CommentsService
    {
        private CommentRepository _repo;

        public CommentsService(CommentRepository repo)
        {
            _repo = repo;
        }
        public IEnumerable<CommentDTO> Get()
        {
            return from c in _repo.GetComments()
                   select new CommentDTO
                   {
                       Id = c.Id,
                       Message = c.Message,
                       TimePosted = c.TimePosted
                   };
        }
        public IEnumerable<CommentDTO> GetProfileComment(string userId)
        {
            return from c in _repo.GetProfileComments(userId)
                   where c.ApplicationUserId == userId
                   select new CommentDTO
                   {
                       Id = c.Id,
                       Message = c.Message,
                       TimePosted = c.TimePosted,
                      
                    
                   };
        }
        public void Add(CommentDTO comment, string username, int id)
        {
            Comment newcomment = new Comment
            {
                ApplicationUserId = username,
                Message = comment.Message,
                FeedbackId = id,

            };
            _repo.Add(newcomment);
        }
    }
}
