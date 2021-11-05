using System;

namespace _05112021
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(User.StaticTotalCount);

            User user1 = new User();
            user1.UserName = "test1";
            user1.Password = "test123";
            Console.WriteLine(User.StaticTotalCount);


            User user2 = new User();
            user2.UserName = "test2";
            user2.Password = "test321";
            Console.WriteLine(User.StaticTotalCount);


            Console.WriteLine(User.StaticTotalCount);
            Console.WriteLine(user2.UserName);

            User user3 = new User();

            Console.WriteLine("Orders:");
            Console.WriteLine(user1.Order);
            Console.WriteLine(user2.Order);
            Console.WriteLine(user3.Order);


            string username;
            do
            {
                Console.WriteLine("UserName daxil edin:");
                username = Console.ReadLine();
            } while (string.IsNullOrWhiteSpace(username));

            string password;
            do
            {
                Console.WriteLine("Password daxil edin:");
                password = Console.ReadLine();

            } while (!User.CheckPass(password));
        }
    }
}
