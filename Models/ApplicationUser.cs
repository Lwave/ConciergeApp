using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace ConciergeApp.Models
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Image { get; set; }
        public string Type { get; set; }
        public Preference Preference { get; set; }
//        public string Address { get; set; }
        public ICollection<Friend> Friends { get; set; }
        public ICollection<Friend> TheirFriends { get; set; }
        public ICollection<Feedback> Feedbacks { get; set; }
        public ICollection<Business> Businesses { get; set; }
    }
}
