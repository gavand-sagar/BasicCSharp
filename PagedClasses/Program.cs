using PagedClasses.Pages;
using PagedClasses.Utilities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagedClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter Price: ");
            string input = Console.ReadLine();



            authenticate("Sagar","123")





            Console.ReadLine();
        }


        public static bool authenticate(string usename,string password)
        {
            string connectionString = "Data Source=desktop-5vqtp5k;Initial Catalog=Northwind;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand sqlCommand = new SqlCommand($"SELECT * FROM PRODUCTS WHERE UnitPrice<={input}", connection);
                var reader = sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    int productId = reader.GetInt32(0);
                    string productName = reader.GetString(1);
                    decimal price = reader.GetDecimal(5);

                    Console.WriteLine($"Id: {productId} \t price: {price}");

                }


            }

        }
    }
}
