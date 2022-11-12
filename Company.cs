using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Assesment
{
    internal class Company
    {
        public string Cname { get; set; }
        public string Type { get; set; }
    }
    class Employees : Company
    {
        public string Name { get; set; }
        public string Designation { get; set; }


        public void ReadData()
        {
            Console.Write("Name ");
            Name = Console.ReadLine();
            Console.Write("Designation");
            Designation = Console.ReadLine();
            Console.Write("Cname");
            Cname = Console.ReadLine();
            Console.Write("Type");
            Type = Console.ReadLine();

        }
        public void ShowData()
        {
            Console.WriteLine($"Name={Name}");
            Console.WriteLine($"Designation={Designation}");
            Console.WriteLine($"CompanyName={Cname}");
            Console.WriteLine($"CompanyType={Type}");
        }
    }
}
