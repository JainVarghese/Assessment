using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment
{
    internal class Parent
    {
        public string FamilyName { get; set; }

    }
    class Child : Parent
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Occupation { get; set; }

        public void ReadData()
        {
            Console.Write("Name ");
            Name = Console.ReadLine();
            Console.Write("Familyname ");
            FamilyName = Console.ReadLine();
            Console.Write("Age ");
            Age= int.Parse(Console.ReadLine());
            Console.Write("Occupation ");
            Occupation = Console.ReadLine();

        }
        public void ShowData()
        {
            Console.WriteLine($"Name={Name}");
            Console.WriteLine($"Familyname={FamilyName}");
            Console.WriteLine($"Age={Age}");
            Console.WriteLine($"Occupation={Occupation}");
        }

    }
    

}
