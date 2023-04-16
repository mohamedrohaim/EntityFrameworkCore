using System;
using System.Collections.Generic;

#nullable disable

namespace EFCore
{
    public partial class Stock
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public string Industry { get; set; }
        public string Symbol { get; set; }
        public string Sector { get; set; }
    }
}
