namespace UnitTests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using MyHashSet;
    using MyHashTable;

    [TestClass]
    public class SetTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var setOne = new Set<int>();
            setOne.Add(5);
            setOne.Add(5);
            setOne.Add(5);
            setOne.Add(5);
            setOne.Add(5);
            setOne.Add(5);
            setOne.Add(5);
            setOne.Add(5);
            setOne.Add(5);
            setOne.Add(6);

            var setTwo = new Set<int>();
            setTwo.Add(5);
            setTwo.Add(10);

            Console.WriteLine(setOne);
            Console.WriteLine(setTwo);

            var union = setOne.Union(setTwo);

            Console.WriteLine();
            Console.WriteLine(union);

            var intersect = setOne.Intersect(setTwo);

            Console.WriteLine(intersect);
        }

        [TestMethod]
        public void TestIfAddAddsACorrectAmount()
        {
            var set = new Set<int>();
            set.Add(5);
            set.Add(6);

            Assert.AreEqual(2, set.Count);
        }

        [TestMethod]
        public void TestIfAddingASameKeyAddsOnlyTheFirstTime()
        {
            var set = new Set<int>();
            set.Add(5);
            set.Add(5);
            set.Add(5);
            set.Add(5);
            set.Add(5);
            set.Add(5);
            set.Add(5);
            set.Add(5);
            set.Add(5);

            Assert.AreEqual(1, set.Count);
        }

        [TestMethod]
        public void TestIfRemoveWorksCorrectly()
        {
            var set = new Set<int>();
            set.Add(5);
            set.Add(6);

            set.Remove(5);
            Assert.AreEqual(1, set.Count);
        }

        [TestMethod]
        public void TestIfFindFindsTheValue()
        {
            var set = new Set<int>();
            set.Add(5);
            set.Add(6);

            Assert.AreEqual(true, set.Contains(5));
            Assert.AreEqual(5, set.Find(5));
            Assert.AreEqual(false, set.Contains(7));
        }

        [TestMethod]
        public void TestIfClearLeavesAnEmptySet()
        {
            var set = new Set<int>();
            set.Add(5);
            set.Add(7);
            set.Add(123);
            set.Add(5);
            set.Add(64);
            set.Add(1256);
            set.Add(6);
            set.Add(772);
            set.Add(6);

            set.Clear();
            Assert.AreEqual(0, set.Count);
        }

        [TestMethod]
        public void TestIfUnionUnitesTwoSets()
        {
            var setOne = new Set<int>();
            setOne.Add(5);
            setOne.Add(6);

            var setTwo = new Set<int>();
            setTwo.Add(5);
            setTwo.Add(10);

            var union = setOne.Union(setTwo);

            Assert.AreEqual(3, union.Count);
            Assert.AreEqual(true, union.Contains(5));
            Assert.AreEqual(true, union.Contains(6));
            Assert.AreEqual(true, union.Contains(10));
        }

        [TestMethod]
        public void TestIfIntersectIntersectsTwoSets()
        {
            var setOne = new Set<int>();
            setOne.Add(5);
            setOne.Add(6);

            var setTwo = new Set<int>();
            setTwo.Add(5);
            setTwo.Add(10);

            var intersect = setOne.Intersect(setTwo);

            Assert.AreEqual(2, intersect.Count);
            Assert.AreEqual(false, intersect.Contains(5));
            Assert.AreEqual(true, intersect.Contains(6));
            Assert.AreEqual(true, intersect.Contains(10));
        }
    }
}
