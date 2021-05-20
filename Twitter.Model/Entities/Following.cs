using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twitter.Core.Entity;

namespace Twitter.Model.Entities
{
    public class Following : CoreEntity
    {
        public int? UserID { get; set; }
        public virtual User User { get; set; }
    }
}
