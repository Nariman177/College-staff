using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Ado_4
{
    internal class Program
    {
        static string connectionString = @"Data Source=LAPTOP-2CSQKGGH\SQLEXPRESS;Initial Catalog=usersdb;Integrated Security=True";
        static void Main(string[] args)
        {
            Console.Write("Введите имя пользователя: ");
            string name = Console.ReadLine();
            Console.Write("Введите возраст пользователя: ");
            int age = Int32.Parse(Console.ReadLine());

            AddUser(name, age);
            Console.WriteLine();
            GetUsers();
        }

        private static void AddUser(string name, int age)
        {
            string sqlExpression = "sp_InsertUser";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand command = new SqlCommand(sqlExpression, conn);

                command.CommandType = System.Data.CommandType.StoredProcedure;

                SqlParameter nameParam = new SqlParameter
                {
                    ParameterName = "@name",
                    Value = name

                };

                command.Parameters.Add(nameParam);

                SqlParameter ageParam = new SqlParameter
                {
                    ParameterName = "@age",
                    Value = age
                };

                command.Parameters.Add(ageParam);

                var result = command.ExecuteNonQuery();

                Console.WriteLine("Id добавленного обьекта: {0}", result);
            }
        }

        private static void GetUsers()
        {
            string sqlExpression = "sp_GetUser";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sqlExpression, conn);

                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                var reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    Console.WriteLine("{0}\t{1}", reader.GetName(0), reader.GetName(1));

                    while (reader.Read())
                    {
                        string name = reader.GetString(0);
                        int age = reader.GetInt32(1);
                        Console.WriteLine("{0}\t{1}", name, age);
                    }
                    reader.Close();
                }
            }

        }
    }
}
