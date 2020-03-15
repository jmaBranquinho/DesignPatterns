namespace ObserverPattern
{
    //this will be the object to be observed. One obervable may have 0..* observers
    public interface IObservable
    {
        //it must be able to add new oberserver...
        void Attach(IObserver observer);

        //...and to remove observers
        void Detach(IObserver observer);

        //should be able to notify all observers that something as changed (i.e. an event)
        void Notify();
    }
}