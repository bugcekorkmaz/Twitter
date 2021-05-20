using System;
using Twitter.Core.Entity;

namespace Twitter.Model.Entities
{
    public class Follower : CoreEntity
    {
        
        public int UserID { get; set; }
        public virtual User User { get; set; }
    }
}
