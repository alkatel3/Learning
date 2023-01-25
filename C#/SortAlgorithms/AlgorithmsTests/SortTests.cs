using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algorithms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Tests
{
    [TestClass()]
    public class SortTests
    {
        Random rnd = new Random();
        List<int> Items = new List<int>();
        List<int> Sorted = new List<int>();

        [TestInitialize]
        public void Init()
        {
            Items.Clear();
            for (int i = 0; i < 10000; i++)
            {
                Items.Add(rnd.Next(0, 10000));
            }
            Sorted.Clear();
            Sorted.AddRange(Items.OrderBy(x => x).ToArray());
        }

        [TestMethod()]
        public void BubbleSortTest()
        {
            //arrange
            var bubble = new BubbleSort<int>();
            bubble.Items.AddRange(Items);
            //act
            bubble.Sort();

            //assert
            for (int i = 0; i < Items.Count; i++)
            {
                Assert.AreEqual(bubble.Items[i], Sorted[i]);
            }
        }

        [TestMethod()]
        public void CocktailSortTest()
        {
            //arrange
            var Cocktail = new CocktailSort<int>();
            Cocktail.Items.AddRange(Items);
            //act
            Cocktail.Sort();

            //assert
            for (int i = 0; i < Items.Count; i++)
            {
                Assert.AreEqual(Cocktail.Items[i], Sorted[i]);
            }
        }

        [TestMethod()]
        public void InsertionSortTest()
        {
            //arrange
            var Insertion = new InsertionSort<int>();
            Insertion.Items.AddRange(Items);
            //act
            Insertion.Sort();

            //assert
            for (int i = 0; i < Items.Count; i++)
            {
                Assert.AreEqual(Insertion.Items[i], Sorted[i]);
            }
        }

        [TestMethod()]
        public void ShellSortTest()
        {
            //arrange
            var Insertion = new ShellSort<int>();
            Insertion.Items.AddRange(Items);
            //act
            Insertion.Sort();

            //assert
            for (int i = 0; i < Items.Count; i++)
            {
                Assert.AreEqual(Insertion.Items[i], Sorted[i]);
            }
        }

        [TestMethod()]
        public void BaseSortTest()
        {
            //arrange
            var bubble = new AlgorithmBase<int>();
            bubble.Items.AddRange(Items);
            //act
            bubble.Sort();

            //assert
            for (int i = 0; i < Items.Count; i++)
            {
                Assert.AreEqual(bubble.Items[i], Sorted[i]);
            }
        }

        [TestMethod()]
        public void TreeSortTest()
        {
            //arrange
            var bubble = new TreeSort<int>();
            bubble.Items.AddRange(Items);
            //act
            bubble.Sort();

            //assert
            for (int i = 0; i < Items.Count; i++)
            {
                Assert.AreEqual(bubble.Items[i], Sorted[i]);
            }
        }

        [TestMethod()]
        public void HeapSortTest()
        {
            //arrange
            var bubble = new HeapSort<int>();
            bubble.Items.AddRange(Items);
            //act
            bubble.Sort();

            //assert
            for (int i = 0; i < Items.Count; i++)
            {
                Assert.AreEqual(bubble.Items[i], Sorted[i]);
            }
        }
    }
}