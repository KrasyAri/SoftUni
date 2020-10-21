using System;
using System.Collections.Generic;
using System.Text;

namespace GenericSwapMethodInteger
{
    public class Box<T>
    {
        public List<T> Value { get; set; } = new List<T>();

        public Box(List<T> value)
        {
            Value = value;
        }

        public void Swap(int firstIndex, int secondIndex)
        {
            T temporaryValue = Value[firstIndex];
            this.Value[firstIndex] = this.Value[secondIndex];
            this.Value[secondIndex] = temporaryValue;
        }
    }
}
