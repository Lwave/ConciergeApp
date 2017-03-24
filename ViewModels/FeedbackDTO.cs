using ConciergeApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConciergeApp.ViewModels
{
    public class FeedbackDTO
    {
        public int Id { get; set; }
        public string Message { get; set; }
        public string Title { get; set; }
        public DateTime TimePosted { get; set; }
        public int StarRating { get; set; }
        public bool isAnonymous { get; set; }
        public ICollection<CommentDTO> Comments { get; set; }
    }
}
