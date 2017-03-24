using ConciergeApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConciergeApp.ViewModels
{
    public class ApplicationUserDTO
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Image { get; set; }
        public string Type { get; set; }
//        public string Address { get; set; }
        public ICollection<Friend> Friends { get; set; }
        public ICollection<Friend> TheirFriends { get; set; }
        public ICollection<Feedback> Feedbacks { get; set; }
        public ICollection<Business> Businesses { get; set; }
    }
}
