using System;
using System.Collections.Generic;

#nullable disable

namespace EFCore
{
    public partial class Blog
    {
        public Blog()
        {
            Posts = new HashSet<Post>();
        }

        public int Id { get; set; }
        public string Url { get; set; }
        public int Rating { get; set; }
        public DateTime AddedOn { get; set; }
        public DateTime CreatedOn { get; set; }

        public virtual ICollection<Post> Posts { get; set; }
    }
}
