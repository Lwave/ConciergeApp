using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ConciergeApp.Models
{
    public class Friend
    {
        public int Id { get; set; }
        public string ApplicationUserId { get; set; }
        [ForeignKey("ApplicationUserId"), InverseProperty("Friends")]
        public ApplicationUser ApplicationUser { get; set; }
        public string FriendId { get; set; }
        [ForeignKey("FriendId"), InverseProperty("TheirFriends")]
        public ApplicationUser AppUserFriend { get; set; }
    }
}
