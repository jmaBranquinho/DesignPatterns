using System;

namespace Decorator
{
    public class Book : LibraryItem
    {
        private string _author;
        private string _title;

        public Book(string author, string title, int numberOfCopies)
        {
            _author = author;
            _title = title;
            NumberOfCopies = numberOfCopies;
        }

        public override void Display()
        {
            Console.WriteLine("\nBook ------ ");
            Console.WriteLine(" Author: {0}", _author);
            Console.WriteLine(" Title: {0}", _title);
            Console.WriteLine(" # Copies: {0}", NumberOfCopies);
        }
    }
}