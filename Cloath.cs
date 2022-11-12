using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment
{
    internal class cloath
    {
        public string Stock { get; set; }
        public int Price { get; set; }
        public string Category { get; set; }
        public string Sale { get; set; }


        public void Total()
        {
            if (Stock == "New")
            {
                Sale = "discount";
                Price = Price - ((Price * 20) / 100);
            }
         Console.WriteLine(Price);
         Console.WriteLine(Category);
         Console.WriteLine(Sale);
         Console.WriteLine("");
        }
    }
}
