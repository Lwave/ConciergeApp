using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConciergeApp.ViewModels
{
    public class CommentDTO
    {
        public int Id { get; set; }
        public string Message { get; set; }
        public DateTime TimePosted { get; set; }
        public string FirstName { get; set; }
        public string Image { get; set; }


    }
}
