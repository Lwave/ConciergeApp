using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ConciergeApp.Infrastructure;
using ConciergeApp.Models;
using ConciergeApp.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace ConciergeApp.Services
{
    public class FeedbacksService
    {
        private FeedbackRepository _repo;

        public FeedbacksService(FeedbackRepository repo)
        {
            _repo = repo;            
        }
        
        public ICollection<FeedbackDTO> GetProfileFeedback(string userId)
        {
            return (from f in _repo.GetProfileFeedbacks(userId)
                    
                    select new FeedbackDTO
                    {
                        Id = f.Id,
                        Title = f.Title,
                        Message = f.Message,
                        TimePosted = f.TimePosted,
                        StarRating = f.StarRating,
                        isAnonymous = f.isAnonymous,
                        Comments = (from c in f.Comments
                                    select new CommentDTO
                                    {
                                        Id = c.Id,
                                        Message = c.Message,
                                        TimePosted = c.TimePosted,
                                        FirstName = c.ApplicationUser.FirstName,
                                        Image = c.ApplicationUser.Image
                                    }).ToList()
                    }).ToList();
        }
        public IEnumerable<FeedbackDTO> GetBusinessFeedback(int id)
        {
            return from f in _repo.GetBusinessFeedbacks()
                   where f.BusinessId == id
                   select new FeedbackDTO
                   {
                       Id = f.Id,
                       Title = f.Title,
                       Message = f.Message,
                       TimePosted = f.TimePosted,
                       StarRating = f.StarRating,
                       isAnonymous = f.isAnonymous,
                       Comments = (from c in f.Comments
                                   select new CommentDTO
                                   {
                                       Id = c.Id,
                                       Message = c.Message,
                                       TimePosted = c.TimePosted
                                   }).ToList()
                   };
        }
        //public IEnumerable<FeedbackDTO> GetFeedbackById(int id)
        //{
        //    return from f in _repo.GetFeedbackById()
        //           where f.BusinessId == id
        //           select new FeedbackDTO
        //           {
        //               Id = f.Id,
        //               Title = f.Title,
        //               Message = f.Message,
        //               TimePosted = f.TimePosted,
        //               StarRating = f.StarRating,
        //               isAnonymous = f.isAnonymous,
        //               Comments = (from c in f.Comments
        //                           select new CommentDTO
        //                           {
        //                               Id = c.Id,
        //                               Message = c.Message,
        //                               TimePosted = c.TimePosted
        //                           }).ToList()
        //           };
        //}

        public void Add(FeedbackDTO feedbackDTO, string username, int id)
        {

            Feedback newfeedback = new Feedback
            {
                Message = feedbackDTO.Message,
                Title = feedbackDTO.Title,
                ApplicationUserId = username,
                BusinessId = id
            };
            _repo.Add(newfeedback);
        }
    }
}


