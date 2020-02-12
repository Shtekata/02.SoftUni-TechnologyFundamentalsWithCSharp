using System;

namespace Login
{
    class Program
    {
        static void Main(string[] args)
        {
            var username = Console.ReadLine();
            var password = string.Empty;
            for (int i = username.Length-1; i >= 0; i--)
            {
                password += username[i];
            }
            for (int i = 0; i <= 3; i++)
            {
                var pass = Console.ReadLine();
                if (pass == password) { Console.WriteLine($"User {username} logged in."); break; }
                if (i == 3) { Console.WriteLine($"User {username} blocked!"); break; }
                else Console.WriteLine($"Incorrect password. Try again.");
            }
        }
    }
}
