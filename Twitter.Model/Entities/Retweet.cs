using System;
using Twitter.Core.Entity;

namespace Twitter.Model.Entities
{
    public class Retweet : CoreEntity
    {
        public Guid UserId { get; set; }
        public User User { get; set; }
        public int TweetId { get; set; }
        public Tweet Tweet { get; set; }
    }
}
