using PagedClasses.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagedClasses.Pages
{
    internal class SignupPage : BasePage
    {
        public override void Show()
        {
            Console.WriteLine("=========================");
            Console.WriteLine("Signup");
            Console.WriteLine("=========================");
            Console.WriteLine("Singup Successfully.");

            PromptMainPage();
        }

    }
}
