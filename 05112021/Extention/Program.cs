using System;

namespace Extention
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 45;
            string text = "heLLo";

            int num2 = num1.Add(10);

            Console.WriteLine(num2);
            Console.WriteLine(num2.Add(45));


            string text2 = text.ToName();
            Console.WriteLine(text2);

            Console.WriteLine(text.ToName().IsName());
            Console.WriteLine(text2.IsName());

            User user = new User("Abbas", "Hikmet", 34,"Male");
            Console.WriteLine(user.Name);

            Car car = new Car();
            car.Brand = "Mercedes";
            car.Model = "E200";

            Console.WriteLine(car);
            
        }
    }
}
