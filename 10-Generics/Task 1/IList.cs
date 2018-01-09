namespace _10_Generics
{
    public interface IList<T>
    {
        void AddItem(T itam);
        T this [int index] { get; }
        int Count { get; }
        //bool Contain(T item);

    }
}