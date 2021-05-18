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
    public class UserMap : CoreMap<User>
    {
        public override void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("Users");
            builder.Property(x => x.Username).HasMaxLength(100).IsRequired();
            builder.Property(x => x.Name).HasMaxLength(100).IsRequired();
            builder.Property(x => x.Password).HasMaxLength(1000).IsRequired(true);
            builder.Property(x => x.PersonalInformation).HasMaxLength(2000).IsRequired(false);
            builder.Property(x => x.Location).HasMaxLength(100).IsRequired(false);
            builder.Property(x => x.WebPage).HasMaxLength(500).IsRequired(false);
            builder.Property(x => x.ProfileImage).HasMaxLength(250).IsRequired(false);
            builder.Property(x => x.BannerImage).HasMaxLength(250).IsRequired(false);
            builder.Property(x => x.BirthDate).HasMaxLength(250).IsRequired(true);
            builder.Property(x => x.Email).HasMaxLength(250).IsRequired(true);
            builder.Property(x => x.IsFollowing).IsRequired(true);
            builder.Property(x => x.LastLogin).IsRequired(false);
            builder.Property(x => x.LastIPAddress).HasMaxLength(24).IsRequired(false);
            base.Configure(builder);
        }
    }
}
