using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Twitter.Core.Map;
using Twitter.Model.Entities;

namespace Twitter.Model.Maps
{
    public class FollowerMap : CoreMap<Follower>
    {
        public override void Configure(EntityTypeBuilder<Follower> builder)
        {
            builder.ToTable("Followers");
            base.Configure(builder);
        }
    }
}
