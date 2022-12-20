using PagedClasses.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagedClasses.Utilities
{
    static class Navigator
    {    
        private static BasePage[] pages;
        static Navigator()
        {
            pages = new BasePage[] { new MainPage(), new LoginPage(), new SignupPage() };
        }
        public static void NavigateTo(int pageNumber)
        {
            pages[pageNumber].Show();
        }
    }
}
