using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public abstract class Decorator : LibraryItem
    {
        protected LibraryItem _libraryItem;

        public Decorator(LibraryItem libraryItem)
        {
            _libraryItem = libraryItem;
        }

        public override void Display()
        {
            _libraryItem.Display();
        }
    }
}
