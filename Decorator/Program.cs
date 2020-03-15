using System;

namespace Decorator
{
    class Program
    {
        //Attach additional responsibilities to an object dynamically. 
        //Decorators provide a flexible alternative to subclassing for extending functionality.
        static void Main(string[] args)
        {
            // Create book
            var book = new Book("Worley", "Inside ASP.NET", 10);
            book.Display();

            var video = new Video("Spielberg", "Jaws", 23, 92);
            video.Display();

            Console.WriteLine("\nMaking video borrowable:");

            var borrowvideo = new Borrowable(video);
            borrowvideo.BorrowItem("Customer #1");
            borrowvideo.BorrowItem("Customer #2");

            borrowvideo.Display();

            Console.WriteLine("\nMaking book borrowable:");

            var borrowbook = new Borrowable(book);
            borrowbook.BorrowItem("Customer #1");

            borrowbook.Display();
        }
    }
}
