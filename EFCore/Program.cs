using EFCore.Context;
using EFCore.Models;
using Microsoft.EntityFrameworkCore.Query.Internal;
using System;
using System.Linq;

namespace EFCore
{
    internal class Program
    {
        static void Main(string[] args)
        {

          var _contex = new EFCoreContext();

           var Maxstock = _contex.Stocks.Max(x => x.Id);
           var MaxByName= _contex.Stocks.Max(x => x.Name);
           var MinByName= _contex.Stocks.Min(x => x.Name);
           var Minstock = _contex.Stocks.Min(x => x.Id);
            Console.WriteLine(MaxByName);
            Console.WriteLine(MinByName);
            Console.WriteLine(Maxstock);
            Console.WriteLine(Minstock);
            

        }
    }
}
