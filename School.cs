using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;

namespace Assesment
{
    internal class School
    {
        public string SchoolName { get; set; }
        public int Fee { get; set; }
    }

    class Student : School
    {
        public string StudentName { get; set; }
        public int Class { get; set; }
        public int Age { get; set; }

    }
    class Sport : Student
    {
        public string Item1 { get; set; }
        public string Item2 { get; set; }
        public string Item3 { get; set; }
        public string Item4 { get; set; }


        public void ReadData()
        {
            Console.Write("School Name ");
            SchoolName = Console.ReadLine();
            Console.Write("Fees ");
            Fee = int.Parse(Console.ReadLine());
            Console.WriteLine("Student Name");
            StudentName = Console.ReadLine();
            Console.Write("Class ");
            Class = int.Parse(Console.ReadLine());
            Console.Write("Age ");
            Age = int.Parse(Console.ReadLine());
            Console.Write("Item1 ");
            Item1 = Console.ReadLine();
            Console.Write("Item2 ");
            Item2 = Console.ReadLine();
            if (Age > 12)
            {
                Console.Write("Item3 ");
                Item3 = Console.ReadLine();
                Console.Write("Item4 ");
                Item4 = Console.ReadLine();
            }
        }
        public void ShowData()
        {
            Console.WriteLine("");
            Console.WriteLine($"School name = {SchoolName}");
            Console.WriteLine($"Fees = {Fee}");
            Console.WriteLine($"Student name ={StudentName}");
            Console.WriteLine($"Class ={Class}");
            Console.WriteLine($"Age ={Age}");
            Console.WriteLine($"Item1 ={Item1}");
            Console.WriteLine($"Item2 ={Item2}");
            if (Age > 12)
            {
                Console.WriteLine($"Item3 ={Item3}");
                Console.WriteLine($"Item4 ={Item4}");
            }
        }
    }
}
