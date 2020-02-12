using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Articles_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            var listOfArticles = new List<Articles>();
            for (int i = 0; i < number; i++)
            {
                var article = Console.ReadLine().Split(", ");
                var newArticle = new Articles(article);
                listOfArticles.Add(newArticle);
            }
            var sort = Console.ReadLine().ToLower();
            if (sort == "title") listOfArticles.Sort((x, y) => string.Compare(x.Title, y.Title));
            else if (sort == "content") listOfArticles.Sort((x, y) => string.Compare(x.Content, y.Content));
            else if (sort == "author") listOfArticles.Sort((x, y) => string.Compare(x.Author, y.Author));
            foreach (var item in listOfArticles)
            {
                Console.WriteLine(item);
            }
        }
    }
    class Articles
    {
        public Articles()
        {
            Title = "";
            Content = "";
            Author = "";
        }
        public Articles(string[] article)
        {
            Title = article[0];
            Content = article[1];
            Author = article[2];
        }
        public string Title;
        public string Content;
        public string Author;

        public override string ToString()
        {
            return Title + " - " + Content + ": " + Author;
        }
    }
}
