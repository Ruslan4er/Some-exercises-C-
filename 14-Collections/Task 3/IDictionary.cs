namespace Task_2
{
    public interface IDictionary<TKey,TValue>
    {
        void AddPair(TKey key, TValue value);
        string this [int key] { get; }
        int Count { get; }

    }
}