using System;
using System.Collections.Generic;

#nullable disable

namespace EFCore
{
    public partial class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int? BlogId { get; set; }

        public virtual Blog Blog { get; set; }
    }
}
