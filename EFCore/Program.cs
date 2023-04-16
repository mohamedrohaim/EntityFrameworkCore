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

           // var stocks = _contex.Stocks.Where(m=>m.Id>900).ToList().Append(new Stock { Id=1001,Name="Test"});
            var stocks = _contex.Stocks.Where(m=>m.Id>900).ToList().Prepend(new Stock { Id=1001,Name="Test"});

            foreach(var stock in stocks)
               Console.WriteLine($"ID: {stock.Id} : {stock.Name}");
            

        }
    }
}
