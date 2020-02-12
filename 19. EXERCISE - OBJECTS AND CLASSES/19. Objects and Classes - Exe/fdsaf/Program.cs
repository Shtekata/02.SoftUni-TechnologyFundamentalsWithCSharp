using System;
using System.Collections.Generic;

namespace _01._Adv_Mess
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberOfMessages = int.Parse(Console.ReadLine());
            var phrases = new List<string>() { "Excellent product.", "Such a great product", "I always use that product.", "Best product of its category.", "Exceptional product.", "I can't live without this product." };
            var events = new List<string>() { "Now i feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!" };
            var authors = new List<string>() { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };
            var cities = new List<string>() { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };
            var newMessage = new fakeMessage(phrases, events, authors, cities);

            for (int i = 0; i < numberOfMessages; i++)
            {
                newMessage.Message();
            }

        }
    }
    class fakeMessage
    {
        public fakeMessage()
        {
            Phrases = new List<string>();
            Events = new List<string>();
            Authors = new List<string>();
            Cities = new List<string>();
        }
        public fakeMessage(List<string> phrases, List<string> events, List<string> authors, List<string> cities)
        {
            Phrases = phrases;
            Events = events;
            Authors = authors;
            Cities = cities;
        }
        public List<string> Phrases;
        public List<string> Events;
        public List<string> Authors;
        public List<string> Cities;

        public void Message()
        {
            var rnd = new Random();
            var message = new List<string>();
            message.Add(Phrases[rnd.Next(Phrases.Count)]);
            message.Add(Events[rnd.Next(Events.Count)]);
            message.Add(Authors[rnd.Next(Authors.Count)]);
            message.Add("- " + Cities[rnd.Next(Cities.Count)]);
            Console.WriteLine(string.Join(' ', message));
        }
    }
}
