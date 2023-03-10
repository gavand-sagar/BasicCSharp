using PagedClasses.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagedClasses.Pages
{
    public abstract class BasePage
    {
        public abstract void Show();
        public virtual void PromptMainPage()
        {
            Console.WriteLine("========BasePage============");
            Console.WriteLine("Do you want to go to main page? (y/n)");
            string input = Console.ReadLine();
            if (input == "y" || input == "Y")
            {
                Navigator.NavigateTo(PageType.Main);
            }
        }
    }

    //public interface BasePage
    //{        
    //    void Show();
    //    void PromptMainPage();
    //}
}
