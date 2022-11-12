using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment
{
    internal class Animal
    {
        public string Name { get; set; }
        public int MaxLyf { get; set; }
        public string Food { get; set; }
        public void ShowData()
        {
            Console.WriteLine(Name);
            Console.WriteLine(MaxLyf);
            Console.WriteLine(Food);

        }
    }
}
