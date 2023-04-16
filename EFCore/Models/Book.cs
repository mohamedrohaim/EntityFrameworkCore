using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.Models
{
    public class Book
    {
        //[Key]
        public int Id { get; set; }
        public String  Name { get; set;  }
        public String  Author { get; set; }

    }
}
