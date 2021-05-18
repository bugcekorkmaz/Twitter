using System;
using System.Collections.Generic;
using Twitter.Core.Entity;

namespace Twitter.Model.Entities
{
    public class User : CoreEntity
    {
        public string Username { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string PersonalInformation { get; set; }
        public string Location { get; set; }
        public string WebPage { get; set; }
        public string ProfileImage { get; set; }
        public string BannerImage { get; set; }
        public DateTime BirthDate { get; set; }
        public string Email { get; set; }
        public bool IsFollowing { get; set; }
        public DateTime? LastLogin { get; set; }
        public DateTime? LastIPAddress { get; set; }
        public virtual List<Tweet> Tweets { get; set; }
        public virtual List<Follower> Followers { get; set; }
        public virtual List<Following> Followings { get; set; }
        public virtual List<Like> Likes { get; set; }
        public virtual List<Media> Medias { get; set; }
    }
}
