using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SamithBasicCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Product product1 = new Product();

            Product product2 = new Product("Apple","14",1000);

            Product product3 = new Product("Samung");

            product1.InitializeData();
            product1.InitializeData("Apple");

            Console.WriteLine($"Product 1 Branch Name is : {product1.BrandName}");
            Console.WriteLine($"Product 1 Price is : {product1.Price}");
            Console.WriteLine($"Product 1 is : {product1.PriceLabel}");


            Console.ReadLine();
        }
    }
}
