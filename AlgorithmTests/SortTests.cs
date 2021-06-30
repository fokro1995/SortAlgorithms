using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithm.Tests
{
    [TestClass()]
    public class SortTests
    {
        int count = 1000;
        int randRange = 100;
        Random rnd = new Random();
        List<int> Items = new List<int>();
        List<int> Sorted = new List<int>();

        [TestInitialize]
        public void Init()
        {
            Items.Clear();
            for (int i = 0; i < count; i++)
            {
                Items.Add(rnd.Next(0, randRange));
            }

            Sorted.Clear();
            Sorted.AddRange(Items.OrderBy(x => x).ToArray());
        }
        [TestMethod()]
        public void BubbleSortTest()
        {

            var bubble = new BubbleSort<int>();

            bubble.Items.AddRange(Items);

            bubble.Sort();

            bubble.Sort();
            for (int i = 0; i < Items.Count; i++)
            {
                Assert.AreEqual(Sorted[i], bubble.Items[i]);
            }
        }

        [TestMethod()]
        public void InsertSortTest()
        {

            var insert = new InsertSort<int>();

            insert.Items.AddRange(Items);

            insert.Sort();

            insert.Sort();
            for (int i = 0; i < Items.Count; i++)
            {
                Assert.AreEqual(Sorted[i], insert.Items[i]);
            }
        }
    }
}