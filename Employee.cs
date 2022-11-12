using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Assesment
{
    internal class Employee
    {
        public string Name { get; set; }    
        public string Description { get; set; }
        public string Designation { get; set; }
        private int _sal;

        public int Salary
        {
            get { return _sal; }
            set { if (Designation == "Trainee")
                {
                    _sal = 5000; 
                    return;
                }
                 _sal = value;
                }
        }
         public void ShowData()
        {
            Console.WriteLine(Name);
            Console.WriteLine(Description);
            Console.WriteLine(Designation);
            Console.WriteLine(Salary);


        }

    }
}
