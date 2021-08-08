namespace Assets.Scripts
{
    interface Subject
    {
        void registerObserver(Observer observer);
        void removeObserver(Observer observer);
        void notifyObserver();
    }
}
