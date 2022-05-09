namespace HashTable.Lib
{
    public interface IHashTable<T> 
        where T : IEquatable<T>
    {
        T Add(T value);
        bool IsPresent(T value);
        void Rebalance();
    }

    public interface SPSStudent
    {
        string Name { get; }
        string Year { get; }
        string Tutor { get; }
    }
}