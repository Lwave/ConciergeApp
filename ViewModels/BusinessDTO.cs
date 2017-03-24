using ConciergeApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConciergeApp.ViewModels
{
    public class BusinessDTO
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string Phone { get; set; }
        public string Description { get; set; }
        public string Url { get; set; }
        public string Image { get; set; }
        public string AvgRating { get; set; }
        public decimal PriceMin { get; set; }
        public decimal PriceMax { get; set; }
        public string Address { get; set; }
        public string HoursOpen { get; set; }
        public ICollection<Feedback> Feedbacks { get; set; }
    }
}
