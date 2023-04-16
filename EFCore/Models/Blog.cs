using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.Models
{
    public class Blog
    {
        //[Key]
        public int Id { get; set; }

        // * change column name
        // [Column("BlogUrl")]
        //[MaxLength(100)]
        public string Url { get; set; }
        public int Rating { get; set; }

        // * Exclude AddedOnly from migration
       // [NotMapped] 
        public DateTime AddedOn { get; set; }
        public DateTime CreatedOn { get; set; }

        // [NotMapped]
        public List<Post> Posts { get; set; }
        public List<Book> Books { get; set; }

     
    }
}
