using System;
using System.Collections.Generic;

namespace Algorithm
{
    public class ShakerSort<T> : AlgorithmBase<T> where T : IComparable
    {
        public ShakerSort(IEnumerable<T> items) : base(items) { }

        public ShakerSort() { }
        protected override void MakeSort()
        {
            for (var i = 0; i < Items.Count / 2; i++)
            {
                var swapFlag = false;
                for (var j = i; j < Items.Count - i - 1; j++)
                {
                    ComparisonCount++;
                    if (Items[j].CompareTo(Items[j + 1]) == 1)
                    {
                        Swop(j, j + 1);
                        swapFlag = true;
                    }
                }
                for (var j = Items.Count- 2 - i; j > i; j--)
                {
                    ComparisonCount++;
                    if (Items[j - 1].CompareTo(Items[j]) == 1)
                    {
                        ComparisonCount++;
                        Swop(j - 1, j);
                        swapFlag = true;
                    }
                }
                if (!swapFlag)
                {
                    break;
                }
            }
            
        }
    }
}
