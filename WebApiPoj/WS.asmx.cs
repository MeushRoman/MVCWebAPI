using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using WebApiPoj.Models;

namespace WebApiPoj
{
    /// <summary>
    /// Сводное описание для WS
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Чтобы разрешить вызывать веб-службу из скрипта с помощью ASP.NET AJAX, раскомментируйте следующую строку. 
    // [System.Web.Script.Services.ScriptService]
    public class WS : System.Web.Services.WebService
    {
        [WebMethod]
        public book First(int id)
        {          
            return Repo.DataBooks.Where(z => z.Id == id).FirstOrDefault();
        }

        [WebMethod]
        public List<book> Second()
        {
            return Repo.DataBooks;
        }

        [WebMethod]
        public List<book> getBooks(int startYear, int lastYear)
        {
            var b = Repo.DataBooks.Where(w => Int32.Parse(w.Year) >= startYear && Int32.Parse(w.Year) <= lastYear).ToList();
            return b;
        }

        [WebMethod]
        public int getCountBooks()
        {          
            return Repo.DataBooks.Count;
        }
    }
}
