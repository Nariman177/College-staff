using System;
using System.Linq;
using System.Data.SqlClient;

namespace Ado_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string connectionString = @"Data Source=LAPTOP-2CSQKGGH\SQLEXPRESS;Initial Catalog=usersdb;Integrated Security=True";
            Console.WriteLine("Введите имя:");

            string name = Console.ReadLine();

            Console.WriteLine("Введите возраст:");
            int age = Int32.Parse(Console.ReadLine());

            string sqlExpression = String.Format("INSERT INTO Users (Name, Age) VALUES ('{0}', {1})", name, age);
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                // добавление
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                int number = command.ExecuteNonQuery();
                Console.WriteLine("Добавлено объектов: {0}", number);

                // обновление ранее добавленного объекта
                Console.WriteLine("Введите новое имя:");
                name = Console.ReadLine();
                sqlExpression = String.Format("UPDATE Users SET Name='{0}' WHERE Age={1}", name, age);
                command.CommandText = sqlExpression;
                number = command.ExecuteNonQuery();
                Console.WriteLine("Обновлено объектов: {0}", number);


            }
        }
    }
}
