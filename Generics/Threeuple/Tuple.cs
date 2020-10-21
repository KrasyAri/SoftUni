using System;
using System.Collections.Generic;
using System.Text;

namespace Threeuple
{
    public class Tuple<TFirst, TSecond, TThird>
    {

        public Tuple(TFirst firstItem, TSecond secondItem, TThird thirdItem)
        {
            FirstItem = firstItem;
            SecondItem = secondItem;
            ThirdItem = thirdItem;
        }

        public TFirst FirstItem { get; set; }
        public TSecond SecondItem { get; set; }
        public TThird ThirdItem { get; set; }

        public override string ToString()
        {
            return $"{FirstItem} -> {SecondItem} -> {ThirdItem}";
        }
    }
}
