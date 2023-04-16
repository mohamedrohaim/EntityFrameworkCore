using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.Models
{
    // *change name and  schema
    //[Table("Posts",Schema ="blogging")]
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        
        
        //navigation property 
        public Blog Blog { get; set; }
    }
}
