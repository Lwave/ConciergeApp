using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ConciergeApp.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public string Message { get; set; }
        public DateTime TimePosted { get; set; }
        public string Image { get; set; }
        public int Likes { get; set; }
        public string ApplicationUserId { get; set; }
        [ForeignKey("ApplicationUserId")]
        public ApplicationUser ApplicationUser { get; set; }
        //double check to confirm we need this foreign key.should be used to link comment to specified feedback
        public int FeedbackId { get; set; }
        [ForeignKey("FeedbackId")]
        public Feedback Feedback { get; set; }
    }
}
