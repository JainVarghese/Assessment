using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment
{
    internal class Food
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public int Discount { get; set; }

        public void Total()
        {
            if (Price >= 150)
            {
                Discount = 10;
            }
                Price = Price - ((Price * Discount) / 100);
                Console.WriteLine($"Price= {Price}");
        }
      
    }
}
