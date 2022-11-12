using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment;

internal class Furniture
{
    public string Type { get; set; }
    public string Wood { get; set; }
    public int Price { get; set; }

    public Furniture(string type, string wood, int price)
    {
        Type = type;
        Wood = wood;
        Price = price;
    }
    public Furniture()
    {
     Console.WriteLine("Enter the type");
     Type = Console.ReadLine();
     Console.WriteLine("Enter the price");
     Price = int.Parse(Console.ReadLine());
     Console.WriteLine("Wood");
     Wood = Console.ReadLine();

    }
    public void ShowData()
    {
     Console.WriteLine("");
     Console.WriteLine($"Type = {Type}");
     Console.WriteLine($"Price= {Price}");
     Console.WriteLine($"Wood = {Wood}");
    }


}
