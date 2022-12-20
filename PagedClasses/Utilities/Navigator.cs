using PagedClasses.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PagedClasses.Utilities
{
    static class Navigator
    {    
        // this is a container 
        private static BasePage[] pages;
        static Navigator()
        {
            pages = new BasePage[] { new MainPage(), new LoginPage(), new SignupPage() };
        }
        public static void NavigateTo(PageType pageNumber)
        {
            pages[(int)pageNumber].Show();
        }
    }
}
