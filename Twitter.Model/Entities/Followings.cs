using System;

namespace Twitter.Model.Entities
{
    public class Followings
    {
        public Guid UserId { get; set; }
        public User User { get; set; }
    }
}
