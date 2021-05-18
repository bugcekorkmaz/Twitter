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
    public class FollowingMap : CoreMap<Following>
    {
        public override void Configure(EntityTypeBuilder<Following> builder)
        {
            builder.ToTable("Followings");
            base.Configure(builder);
        }
    }
}
