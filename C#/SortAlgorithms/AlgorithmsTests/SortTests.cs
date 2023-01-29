using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

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
            var bubble = new AlgorithmBase<int>(Items);
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
            var bubble = new TreeSort<int>(Items);
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
            var bubble = new HeapSort<int>(Items);
            //act
            bubble.Sort();

            //assert
            for (int i = 0; i < Items.Count; i++)
            {
                Assert.AreEqual(bubble.Items[i], Sorted[i]);
            }
        }

        [TestMethod()]
        public void SelectionSortTest()
        {
            //arrange
            var bubble = new SelectionSort<int>();
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
        public void GnomeSortTest()
        {
            //arrange
            var gnome = new GnomeSort<int>(Items);
            //act
            gnome.Sort();

            //assert
            for (int i = 0; i < Items.Count; i++)
            {
                Assert.AreEqual(gnome.Items[i], Sorted[i]);
            }
        }

        [TestMethod()]
        public void LsdRadixSortTest()
        {
            //arrange
            var radix = new LsdRadixSort<int>(Items);
            //act
            radix.Sort();

            //assert
            for (int i = 0; i < Items.Count; i++)
            {
                Assert.AreEqual(radix.Items[i], Sorted[i]);
            }
        }

        [TestMethod()]
        public void MsdRadixSortTest()
        {
            //arrange
            var radix = new MsdRadixSort<int>(Items);
            //act
            radix.Sort();

            //assert
            for (int i = 0; i < Items.Count; i++)
            {
                Assert.AreEqual(radix.Items[i], Sorted[i]);
            }
        }

        [TestMethod()]
        public void MargeSortTest()
        {
            //arrange
            var marge = new MergeSort<int>(Items);
            //act
            marge.Sort();

            //assert
            for (int i = 0; i < Items.Count; i++)
            {
                Assert.AreEqual(marge.Items[i], Sorted[i]);
            }
        }

        [TestMethod()]
        public void QuickSortTest()
        {
            //arrange
            var quick = new QuickSort<int>(Items);
            //act
            quick.Sort();

            //assert
            for (int i = 0; i < Items.Count; i++)
            {
                Assert.AreEqual(quick.Items[i], Sorted[i]);
            }
        }
    }
}