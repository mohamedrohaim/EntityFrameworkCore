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

            var Industry = _contex.Stocks.Select(m => new {m.Industry}).Distinct().ToList();
            foreach(var industry in Industry)
            {
                Console.WriteLine(industry.Industry);
            }

        }
    }
}
