using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamithBasicCSharp
{
    public class Arrays
    {

        public static void MainMethod()
        {
            //Array
            string filePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\Config.txt";

            Console.WriteLine("How many Items you want to add?");
            string input = Console.ReadLine();
            int limit = int.Parse(input); 

            for (int i = 0; i < limit; i++)
            {
                Console.WriteLine("Enter Value to Add: ");
                string value = Console.ReadLine();
                File.AppendAllText(filePath, "\n" + value);
            }



            //int[] numbers= { 23,42,43,41,23,34,35,534,41,23,34,89 };

            //for(int i = 0; i < numbers.Length - 1; i++)
            //{
            //    int current = numbers[i];
            //    int next = numbers[i+1];

            //    if(current == next - 1)
            //    {
            //        Console.WriteLine(current + " , " + next);
            //    }
            //    ///    
            //}


            //foreach (var current in numbers)
            //{
            //    int currentIndex = numbers.IndexOf(current);
            //    Console.WriteLine(current);
            //}

            //Console.WriteLine("Enter Value");

            //string[] args = { "" };
            //File.AppendAllLines("path", args);

            //string filePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\Config.txt";
            //string[] Employees = File.ReadAllLines(filePath);

            //foreach (string item in Employees)
            //{
            //    //this one line will get executed for 
            //    // every sigle item in the collection
            //    // that item you can refer through the {item} variable
            //        Console.WriteLine(item);

            //}           



            //List           
            //List<string> EmployeNames = new List<string>();
            //EmployeNames.Add("Sagar");
            //EmployeNames.Add("Samith");
            //EmployeNames.Add("Tony");
            //EmployeNames.Add("Mike");
            //EmployeNames.Add("Anton");
            ////
            //EmployeNames.Remove("Tony");

            //EmployeNames.Reverse();

            //EmployeNames.ElementAt(2);

        }
    }
}
