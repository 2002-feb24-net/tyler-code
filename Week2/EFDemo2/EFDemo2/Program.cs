using System;
using System.Data.SqlClient;

namespace EFDemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            string conString = "";
            using (var comn = new SqlConnection(conString))
            {
                using (var command = comn.CreateCommand())
                {
                    command.CommandText + @"SELECT c.Customer.ID";

                    comn.Open();

                    using ( var reader = command.ExecuteReader())
                    {
                        while(reader.Read())
                        {
                            Console.WriteLine($"")
                        }
                    }
                }
            }
        }
    }
}
