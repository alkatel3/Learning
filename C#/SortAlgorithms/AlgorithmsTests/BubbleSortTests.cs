using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algorithm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.Tests
{
    [TestClass()]
    public class BubbleSortTests
    {
        [TestMethod()]
        public void SortTest()
        {
            //arrange
            var bubble = new BubbleSort<int>();
            var rnd = new Random();
            var testlist = new List<int>();

            for (int i = 0; i < 1000; i++)
            {
                testlist.Add(rnd.Next(-10, 10));
            }
            bubble.Items.AddRange(testlist);
            testlist.Sort();
            //act
            bubble.Sort();

            //assert
            for (int i = 0; i < testlist.Count; i++)
            {
                Assert.AreEqual(bubble.Items[i], testlist[i]);
            }
        }
    }
}