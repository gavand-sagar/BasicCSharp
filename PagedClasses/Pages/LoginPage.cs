using PagedClasses.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagedClasses.Pages
{
    internal class LoginPage : BasePage
    {
        public override void Show()
        {
            Console.WriteLine("=========================");
            Console.WriteLine("Login");
            Console.WriteLine("=========================");
            Console.WriteLine("Logged in Successfully.");

            PromptMainPage();
        }
        public override void PromptMainPage()
        {
            Console.WriteLine("#########################");
            Console.WriteLine("Do you want to go to main page? (y/n)");
            string input = Console.ReadLine();
            if (input == "y" || input == "Y")
            {
                Navigator.NavigateTo(PageType.Main);
            }
        }

    }
}
