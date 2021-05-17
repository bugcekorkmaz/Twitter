using System;

namespace Twitter.Model.Entities
{
    public class Follower
    {
        public Guid UserId { get; set; }
        public User User { get; set; }
    }
}
