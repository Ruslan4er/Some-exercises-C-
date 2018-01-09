using System;

namespace _11_Generics_part_2_
{
    public interface ICarColletion
    {
        void AddCar(string carName, DateTime carYear);
        string this[int index] { get; }
        int Count { get; }
    }
}