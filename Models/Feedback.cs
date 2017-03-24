using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ConciergeApp.Models
{
    public class Feedback
    {
        public int Id { get; set; }
        public string Message { get; set; }
        public string Title { get; set; }
        public DateTime TimePosted { get; set; }
        public int StarRating { get; set; }
        public bool isAnonymous { get; set; }
        public int Likes { get; set; }
        public ICollection<Comment> Comments { get; set; }
        public string ApplicationUserId { get; set; }
        [ForeignKey("ApplicationUserId")]
        public ApplicationUser ApplicationUser { get; set; }
        public int BusinessId { get; set; }
        [ForeignKey("BusinessId")]
        public Business Business { get; set; }
    }
}
