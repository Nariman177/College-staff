using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Ado_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string connectionString = @"Data Source=LAPTOP-2CSQKGGH\SQLEXPRESS;Initial Catalog=Inerka;Integrated Security=True";
            string sqlExpression = "SELECT * FROM Stocks";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(sqlExpression, connection);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    Console.WriteLine("{0}\t{1}\t", reader.GetName(0), reader.GetName(1));

                    while (reader.Read())
                    {
                        object id = reader.GetValue(0);
                        object name = reader.GetValue(1);
                        //object age = reader.GetValue(2);
                        Console.WriteLine("{0} \t{1} \t",id, name);
                    }
                }
                reader.Close();
            }
        }
    }
}
