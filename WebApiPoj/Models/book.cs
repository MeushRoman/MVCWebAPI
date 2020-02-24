using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiPoj.Models
{
    public class book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public string Year { get; set; }
    }

    public class Repo
    {
        public static List<book> DataBooks;

        public Repo()
        {
            DataBooks = new List<book>
            {
                new book {Id = 1, Name = "book1", Author="author1", Year = "1856"},
                new book {Id = 2, Name = "book2", Author="author2", Year = "1857"},
                new book {Id = 3, Name = "book3", Author="author3", Year = "1858"},
                new book {Id = 4, Name = "book4", Author="author4", Year = "1859"},
                new book {Id = 5, Name = "book5", Author="author5", Year = "1860"}
            };
        }
    }
}