using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twitter.Core.Map;
using Twitter.Model.Entities;

namespace Twitter.Model.Maps
{
    public class TweetMap : CoreMap<Tweet>
    {
        public override void Configure(EntityTypeBuilder<Tweet> builder)
        {
            builder.ToTable("Tweets");
            builder.Property(x => x.UserID);
            builder.Property(x => x.TweetText).HasMaxLength(2000).IsRequired(true);
            builder.Property(x => x.SendTime).IsRequired(true);
            builder.Property(x => x.LikeCount).IsRequired(true);
            builder.Property(x => x.ReTweetCount).IsRequired(true);
            builder.Property(x => x.CommentCount).IsRequired(true);
            base.Configure(builder);
        }
    }
}
