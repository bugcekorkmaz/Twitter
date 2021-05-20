using System;
using Twitter.Core.Entity;

namespace Twitter.Model.Entities
{
    public class Tweet : CoreEntity
    {
        public string TweetText { get; set; }
        public DateTime SendTime { get; set; }
        public int LikeCount { get; set; }
        public int ReTweetCount { get; set; }
        public int CommentCount { get; set; }
        public int? UserID { get; set; }
        public virtual User User { get; set; }
    }
}
