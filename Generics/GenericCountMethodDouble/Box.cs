using System;
using System.Collections.Generic;
using System.Text;

namespace GenericCountMethodDouble
{
    public class Box<T> where T: IComparable
    {
        public List<T> Value { get; set; } = new List<T>();

        public Box(List<T> value)
        {
            Value = value;
        }

        public int Compare(double compareDouble)
        {
            int count = 0;
            foreach (var item in Value)
            {
                if (item.CompareTo(compareDouble) == 1)
                {
                    count++;
                }
            }

            return count;
        }
    }
}
