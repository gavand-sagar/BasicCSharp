using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamithBasicCSharp
{
    public class Product
    {
        private double _price;
        public double Price
        {
            get { return _price; }
            set
            {
                if (value >= 0)
                {
                    _price = value;
                }
            }
        }

        public string ModelName { get; set; }
        public string BrandName { get; set; }


        public string PriceLabel
        {
            get
            {
                if (_price > 1000)
                {
                    return "Expensive";
                }
                else
                {
                    return "Cheap";
                }
            }
        }


        private DateTime _dob; // variable  / field 
        public DateTime DOB { get { return _dob; } set { _dob = value; } }
              
        public int Age
        {
            get { return DateTime.Now.Year - DOB.Year; }
        }


        public void InitializeData()
        {
            Console.WriteLine("Enter Brand Name");
            BrandName = Console.ReadLine();

            Console.WriteLine("Enter Model Name");
            ModelName = Console.ReadLine();

            Console.WriteLine("Enter Price");
            Price = double.Parse(Console.ReadLine());
        }

        public void InitializeData(string Brand)
        {
            BrandName = Brand;
            Console.WriteLine("Enter Model Name");
            ModelName = Console.ReadLine();
            Console.WriteLine("Enter Price");
            Price = double.Parse(Console.ReadLine());
        }

        public void InitializeData(string Brand,string Model)
        {
            BrandName = Brand;
            ModelName = Model;

            Console.WriteLine("Enter Price");
            Price = double.Parse(Console.ReadLine());
        }


        public Product()
        {
            // this is enough to call it as constructor
            // this will get called automatically at new();

            Console.WriteLine("Enter Brand Name");
            BrandName = Console.ReadLine();

            Console.WriteLine("Enter Model Name");
            ModelName = Console.ReadLine();

            Console.WriteLine("Enter Price");
            Price = double.Parse(Console.ReadLine());
        }
        public Product(string b,string m,double p)
        {
            BrandName = b;
            ModelName = m;
            Price = p;
        }

        public Product(string b)
        {
            BrandName = b;
            
            Console.WriteLine("Enter Model Name");
            ModelName = Console.ReadLine();

            Console.WriteLine("Enter Price");
            Price = double.Parse(Console.ReadLine());
        }


    }
}
