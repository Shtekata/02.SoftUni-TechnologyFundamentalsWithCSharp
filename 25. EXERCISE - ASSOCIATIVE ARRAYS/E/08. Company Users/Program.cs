using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._Company_Users
{
    class Program
    {
        static void Main(string[] args)
        {
            var companyUsers = new Dictionary<string, List<string>>();
            var input = Console.ReadLine();
            while (input.ToLower() != "end")
            {
                var user = input.Split(" -> ");
                if (!companyUsers.ContainsKey(user[0])) companyUsers[user[0]] = new List<string>();
                if (!companyUsers[user[0]].Contains(user[1])) companyUsers[user[0]].Add(user[1]);
                input = Console.ReadLine();
            }
            var orderedUsers = companyUsers.OrderBy(x => x.Key);
            foreach (var item in orderedUsers)
            {
                Console.WriteLine(item.Key);
                foreach (var employee in item.Value)
                {
                    Console.WriteLine($"-- {employee}");
                }
            }
        }
    }
}
