using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
    public class InsertSort<T> : AlgorithmBase<T> where T: IComparable
    {
        public InsertSort(IEnumerable<T> items) : base(items) { }

        public InsertSort() { }

        protected override void MakeSort()
        {
            for (var i = 1; i < Items.Count; i++)
            {
                var key = Items[i];
                var j = i;
                while ((j >= 1) && (Items[j - 1].CompareTo(key) == 1))
                {
                    Swop(j - 1, j);
                    j--;
                }
                Items[j] = key;
                ComparisonCount++;
            }
        }
    }
}
