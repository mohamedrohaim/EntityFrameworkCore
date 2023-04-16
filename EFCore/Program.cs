using EFCore.Context;
using EFCore.Models;
using Microsoft.EntityFrameworkCore.Query.Internal;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EFCore
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var _contex = new EFCoreContext();

            var stocks = GetData(1,20);
            foreach (var item in stocks)
            {
                Console.WriteLine(item.Id);
            }

        }

        public static List<Stock> GetData(int pageNumber,int PageSize){
            var _contex = new EFCoreContext();
            
            var stocks = _contex.Stocks.Skip((pageNumber-1)*PageSize).Take(PageSize).ToList();
            return stocks;



        }
    }
}
