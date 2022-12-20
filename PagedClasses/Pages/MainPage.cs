using PagedClasses.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagedClasses.Pages
{
    internal class MainPage:BasePage
    {
        public override void Show()
        {
            Console.WriteLine("Welcome");
            Console.WriteLine("1.Login");
            Console.WriteLine("2.Signup");
            Console.WriteLine("Enter Choice");
            string input = Console.ReadLine();

            Navigator.NavigateTo(int.Parse(input));


            //if (input == "1")
            //{
            //}
            //else if (input == "2")
            //{
            //    Navigator.NavigateTo(2);
            //}
        }
    }
}
