using System;

namespace T05_Login
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            string username = Console.ReadLine();

            //action
            //reverse the username
            string password = string.Empty;
            for (int i = username.Length - 1; i >= 0; i--)
            {
                password += username[i];
            }

            //Input password
            for (int i = 0; i < 4; i++)
            {
                string input = Console.ReadLine();

                if (i == 3 && input != password)
                {
                    Console.WriteLine($"User {username} blocked!");
                    break;
                }
                if (input != password)
                {
                    Console.WriteLine("Incorrect password. Try again.");
                }
                else if (input == password)
                {
                    Console.WriteLine($"User {username} logged in.");
                    break;
                }
                
                
            }

            //output

            
        }
    }
}
