using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment
{
    internal class Mobile
    {
        public string Name { get; set; }
        public string Model { get; set; }
        public int Price { get; set; }
        public string Company { get; set; }

        public void Read()
        {
            Console.Write("Name: ");
            Name = Console.ReadLine();
            Console.Write("Model: ");
            Model = Console.ReadLine();
            Console.Write("Price: ");
            Price= int.Parse(Console.ReadLine());
            Console.Write("Company: ");
            Company = Console.ReadLine();
        }
        public void Read (string name, string model, int price ,string company)
        {  
            Name = name;
            Model = model;
            Price = price;
            Company = company;
        }
        public void Read(string name, string model, int price)
        {
            Name = name;
            Model = model;
            Price = price;
            Company = "Ariyilla";
        }
      public void ShowData()
        {
            Console.WriteLine("");
            Console.WriteLine(Name);
            Console.WriteLine(Model);
            Console.WriteLine(Price);
            Console.WriteLine(Company);

        }
    }
}
