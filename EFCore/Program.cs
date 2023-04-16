using EFCore.Context;
using EFCore.Models;
using System;
using System.Linq;

namespace EFCore
{
    internal class Program
    {
        static void Main(string[] args)
        {

          var _contex = new EFCoreContext();

            var stoks = _contex.Stocks.Where(m => m.Id >= 500 && m.Name.StartsWith("Z"));

            foreach(var stok in stoks)
            {
                Console.WriteLine($"ID: {stok.Id} : {stok.Name}");
            }

        }
    }
}
