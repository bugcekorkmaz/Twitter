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
    public class MediaMap : CoreMap<Media>
    {
        public override void Configure(EntityTypeBuilder<Media> builder)
        {
            builder.ToTable("Medias");
            builder.Property(x => x.MediaUrl).HasMaxLength(250).IsRequired(false);
            builder.Property(x => x.UserID);
            base.Configure(builder);
        }
    }
}
