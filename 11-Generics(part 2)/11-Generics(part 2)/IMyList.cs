namespace _11_Generics_part_2_
{
    public interface IMyList<T> //Параметризированный интерфейс IMyList
    {
        void Add(T a);
        T this[int index] { get; }
        int Count { get; }
        void Clear();
        bool Contains(T item);
    }
}
