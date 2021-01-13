using System;

namespace SecondProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter Your Age");
            String ob = Console.In.ReadLine();
            int age = int.Parse(ob);
            int birth = 2020 - age;
            Console.WriteLine("Your Birthday : "+birth);
        }
    }
}
