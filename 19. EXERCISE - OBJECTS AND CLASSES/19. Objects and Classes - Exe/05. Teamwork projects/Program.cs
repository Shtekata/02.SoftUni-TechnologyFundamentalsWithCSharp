using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Teamwork_projects
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberOfTeams = int.Parse(Console.ReadLine());
            var teams = new List<Teams>();
            for (int i = 0; i < numberOfTeams; i++)
            {
                var teamIn = Console.ReadLine().Split('-');
                var team = new Teams(teamIn[0], teamIn[1]);
                if (teams.Select(x => x.Creator).Contains(team.Creator))
                {
                    Console.WriteLine($"{teamIn[0]} cannot create another team!");
                }
                else if (teams.Select(x => x.TeamName).Contains(team.TeamName))
                {
                    Console.WriteLine($"Team {teamIn[1]} was already created!");
                }
                else
                {
                    Console.WriteLine($"Team {teamIn[1]} has been created by {teamIn[0]}!");
                    teams.Add(team);
                }
            }
            var command = Console.ReadLine();
            while (command != "end of assignment")
            {
                var commandSp = command.Split("->");
                if (!teams.Select(x=>x.TeamName).Contains(commandSp[1])) Console.WriteLine($"Team {commandSp[1]} does not exist!");
                else if (teams.Select(x=>x.Creator).Contains(commandSp[0])
                    ||teams.Select(x=>x.Users).Any(x=>x.Contains(commandSp[0])))
                    Console.WriteLine($"Member {commandSp[0]} cannot join team {commandSp[1]}!");
                else
                {
                    int index = teams.FindIndex(x => x.TeamName == commandSp[1]);
                    teams[index].Users.Add(commandSp[0]);
                }
                command = Console.ReadLine();
            }
            var restTeams = teams.OrderByDescending(x => x.Users.Count).ThenBy(x => x.TeamName).Where(x => x.Users.Count > 0);
            var teamsToDisband = teams.OrderBy(x => x.TeamName).Where(x => x.Users.Count == 0);
            foreach (var item in restTeams)
            {
                Console.WriteLine(item.TeamName);
                Console.WriteLine($"- {item.Creator}");
                foreach (var newItem in item.Users.OrderBy(x => x))
                {
                    Console.WriteLine($"-- {newItem}");
                }
            }
            Console.WriteLine($"Teams to disband:");
            foreach (var item in teamsToDisband)
            {
                Console.WriteLine(item.TeamName);
            }
        }
    }
    class Teams
    {
        public Teams()
        {
            Creator = "";
            TeamName = "";
            Users = new List<string>();
        }
        public Teams(string creator, string teamName)
        {
            Creator = creator;
            TeamName = teamName;
            Users = new List<string>();
        }
        public Teams(string user)
        {
            Users.Add(user);
        }
        public string Creator;
        public string TeamName;
        public List<string> Users;
    }
}
