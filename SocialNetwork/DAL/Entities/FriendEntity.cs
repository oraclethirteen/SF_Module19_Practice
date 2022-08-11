using System;
using System.Text;
using System.Collections.Generic;

namespace SocialNetwork.DAL.Entities
{
    public class FriendEntity
    {
        public int id { get; set; }
        public int user_id { get; set; }
        public int friend_id { get; set; }
    }
}
