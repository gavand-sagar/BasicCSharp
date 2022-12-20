using PagedClasses.Pages;
using PagedClasses.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagedClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter number : ");
            int a = 0;
            try
            {
                int c = 56 / a;
                int input = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Square = " + (input * input));
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }



            Console.ReadLine();

            //Navigator.NavigateTo(0);
            
        }
    }
}
