using System;
using System.Collections.Generic;

namespace Decorator
{
    public class Borrowable : Decorator
    {
        protected List<string> borrowers = new List<string>();

        // Constructor

        public Borrowable(LibraryItem libraryItem)
          : base(libraryItem)
        {
        }

        public void BorrowItem(string name)
        {
            borrowers.Add(name);
            _libraryItem.NumberOfCopies--;
        }

        public void ReturnItem(string name)
        {
            borrowers.Remove(name);
            _libraryItem.NumberOfCopies++;
        }

        public override void Display()
        {
            base.Display();

            foreach (string borrower in borrowers)
            {
                Console.WriteLine(" borrower: " + borrower);
            }
        }
    }
}