using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiPoj.Models;

namespace WebApiPoj.Controllers
{
    [RoutePrefix("books")]
    public class WebApiController : ApiController
    {
        [HttpGet, Route("getall")]
        public IEnumerable<book> get1()
        {
            return Repo.DataBooks;
        }

        [HttpGet, Route("getById/{id}")]
        public book getById(int id)
        {
            return Repo.DataBooks.FirstOrDefault(f => f.Id == id);
        }

        [HttpGet, Route("removeById/{id}")]
        public HttpStatusCode removeById(int id)
        {
            var book = Repo.DataBooks.FirstOrDefault(f => f.Id == id);
            if (book is null) return HttpStatusCode.BadRequest;

            Repo.DataBooks.Remove(book); 
            return HttpStatusCode.OK;
        }

        [HttpPost, Route("addBook")]
        public void addBook(book book)
        {
            Repo.DataBooks.Add(book);
        }

        [HttpPost, Route("edit2")]
        public book edit2(book book)
        {
            var res = Repo.DataBooks.FirstOrDefault(f=>f.Id == book.Id);

            if (res is null) return null;

            res.Name = book.Name;
            res.Author = book.Author;
            res.Year = book.Year;

            Repo.DataBooks.Add(book);
            return res;
        }

        [HttpPost, Route("edit/{id}")]
        public string edit([FromBody]book book, [FromUri] int id)
        {
            var b = Repo.DataBooks.FirstOrDefault(f=>f.Id == id);

            if (book is null) return null;

            b.Name = book.Name;
            b.Author = book.Author;
            b.Year = book.Year;

            return b.Name;
        }

        //[HttpGet]
        //public string get1(string name)
        //{
        //    return $"hello {name}";
        //}
        //[HttpGet]
        //[Route("get2/{name}")]
        //public string get2(string name)
        //{
        //    return $"hello {name}";
        //}
        //[HttpGet, Route("get3")]
        //public string get3(string name)
        //{
        //    return $"hello {name}";
        //}


    }
}