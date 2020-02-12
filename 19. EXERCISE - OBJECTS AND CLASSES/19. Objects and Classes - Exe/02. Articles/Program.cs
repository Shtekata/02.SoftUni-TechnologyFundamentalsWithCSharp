using System;

namespace _02._Articles
{
    class Program
    {
        static void Main(string[] args)
        {
            var article = Console.ReadLine().Split(", ");
            var newArticles = new Articles(article);
            var numberOfArticles = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfArticles; i++)
            {
                var command = Console.ReadLine().Split(": ", StringSplitOptions.RemoveEmptyEntries);
                switch (command[0])
                {
                    case "Rename": newArticles.Rename(command[1]); break;
                    case "Edit": newArticles.Edit(command[1]); break;
                    case "ChangeAuthor": newArticles.ChangeAuthor(command[1]); break;
                }
            }
            Console.WriteLine(newArticles.ToString());
        }
    }
    class Articles
    {
        public Articles(string[] article)
        {
            Title = article[0];
            Content = article[1];
            Author = article[2];
            Article = article;
        }
        public string Title;
        public string Content;
        public string Author;
        public string[] Article;

        public void Rename(string newTitle)
        {
            Article[0] = newTitle;
        }
        public void Edit(string newContent)
        {
            Article[1] = newContent;
        }
        public void ChangeAuthor(string newAuthor)
        {
            Article[2] = newAuthor;
        }
        public override string ToString()
        {
            return Article[0] + " - " + Article[1] + ": " + Article[2];
        }
    }
}
