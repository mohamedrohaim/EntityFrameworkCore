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

            var stocks = _contex.Stocks.Any();
            var stocksIdGreaterThan100 = _contex.Stocks.Any(m=>m.Id>1000);
            var AllStocksGreaterThan100 = _contex.Stocks.All(m=>m.Id>1000);
            Console.WriteLine($"all: {AllStocksGreaterThan100}");
            var posts = _contex.Posts.Any();
            Console.WriteLine(stocksIdGreaterThan100);
            Console.WriteLine(stocks);
            Console.WriteLine(posts);

            //foreach(var stok in stoks)
            //{
            //    Console.WriteLine($"ID: {stok.Id} : {stok.Name}");
            //}

        }
    }
}
