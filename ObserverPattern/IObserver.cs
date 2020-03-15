namespace ObserverPattern
{
    public interface IObserver
    {
        // receive an update from the observable
        void Update(IObservable subject);
    }
}
