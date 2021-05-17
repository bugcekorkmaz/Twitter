using System;
using Twitter.Core.Entity;

namespace Twitter.Model.Entities
{
    public class Media : CoreEntity
    {
        public string MediaUrl { get; set; }
        public Guid UserID { get; set; }
        public virtual User User { get; set; }
    }
}
