namespace Decorator
{
    public abstract class LibraryItem
    {
        private int _numberOfCopies;

        // Property

        public int NumberOfCopies
        {
            get { return _numberOfCopies; }
            set { _numberOfCopies = value; }
        }

        public abstract void Display();
    }
}