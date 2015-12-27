using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3book
{
    class Book
    {
        string info;

        public string Info
        {
            get { return info; }
            set { info = value; }
        }
        public void Add(string title, string author, string content)
        {
            Info = "Book info1: " + title + "\nBook info2: " + author + "\nBook info3: " + content;
        }
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(Info);
            Console.ForegroundColor = ConsoleColor.White;
        }

    }
    public class Title
    {
        string title;

        public string Title1
        {
            get { return title; }
            set { title = value; }
        }
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(Title1);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
    public class Author
    {
        string author;

        public string Author1
        {
            get { return author; }
            set { author = value; }
        }
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(Author1);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
    public class Content
    {
        string content;

        public string Content1
        {
            get { return content; }
            set { content = value; }
        }
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(Content1);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
