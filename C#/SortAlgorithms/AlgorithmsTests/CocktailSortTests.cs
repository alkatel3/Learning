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
    public class CocktailSortTests
    {
        [TestMethod()]
        public void SortTest()
        {
            //arrange
            var cocktail = new CocktailSort<int>();
            var rnd = new Random();
            var testlist = new List<int>();

            for (int i = 0; i < 10000; i++)
            {
                testlist.Add(rnd.Next(-10, 10));
            }
            cocktail.Items.AddRange(testlist);
            testlist.Sort();
            //act 
            cocktail.Sort();

            //assert
            for (int i = 0; i < testlist.Count; i++)
            {
                Assert.AreEqual(cocktail.Items[i], testlist[i]);
            }
        }
    }
}