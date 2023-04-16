using EFCore.Models;
using System;

namespace EFCore
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var _contex = new ApplicationDbContext();
            //var Blog = new Blog()
            //{
            //    Url = "test.com",
            //    Rating= 5,
            //};
            //_contex.Blogs.Add(Blog);

            var author=new Author() { 
            FirstName="mohamed",
            LastName="rohiem"
            };
            // _contex.Authors.Add(author);

            // var auth = _contex.Authors.Find(2);
            var category = new Categoty()
            {
                
                Name = "Science"
            };
           // _contex.Categoties.Add(category);
          //  _contex.SaveChanges();

           Console.WriteLine();
        }
    }
}
