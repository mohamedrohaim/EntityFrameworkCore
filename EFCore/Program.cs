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

           var stocksAverage = _contex.Stocks.Average(x => x.Id);
            var stockscount= _contex.Stocks.Count(M=>M.Id>=500);
            var stocksSum = _contex.Stocks.Count();
            Console.WriteLine(stocksSum);

          //  foreach(var stock in stocks)
            //   Console.WriteLine($"ID: {stock.Id} : {stock.Name}");
            

        }
    }
}
