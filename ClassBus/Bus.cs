using System;
using System.Security.Policy;

namespace ClassBus
{
    public class Bus : ICloneable, IComparable, ICar, ITransport
    {
        private int _capacity;
        private int _lenght;
        private int _countSitting;

        public Bus(int capacity, int lenght, int countSitting)
        {
            _capacity = capacity;
            _lenght = lenght;
            _countSitting = countSitting;
        }

        public int Capacity { get { return _capacity; } }
        public int Lenght { get { return _lenght; } }
        public int CountSitting { get { return _countSitting; } }

        public object Clone()
        {
            return (Bus)this.MemberwiseClone();
        }

        public int CompareTo(object obj)
        {
            Bus temp = (Bus)obj;
            return this.CountSitting.CompareTo(temp.CountSitting);
        }

        public string Drive(ICar car)
        {
            return "Едет";
        }

        public string Transportating(ITransport transport)
        {
            return "Перевеозит";     
        }

        public override string ToString()
        {
            return $" {Capacity}, {Lenght}, {CountSitting}"; ;
        }
    }
}
