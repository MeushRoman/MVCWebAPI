using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soap_Cons
{
    class Program
    {
        static void Main(string[] args)
        {
            WS.WSSoapClient wSSoapClient = new WS.WSSoapClient();

            var res = wSSoapClient.First(3);

            foreach (var item in wSSoapClient.Second())
            {
                Console.WriteLine($"{item.BookName}, {item.Publish}, {item.bookLocation.LocationName1}, {item.bookLocation.LocationName2} ");
            }

            Console.Read();
        }
    }
}
