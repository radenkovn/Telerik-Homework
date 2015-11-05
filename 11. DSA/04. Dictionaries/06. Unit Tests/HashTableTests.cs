namespace UnitTests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using MyHashTable;

    [TestClass]
    public class HashTableTests
    {
        [TestMethod]
        public void TestIfAddAddsACorrectAmount()
        {
            var table = new HashTable<int, int>();

            table.Add(1, 11);
            table.Add(2, 12);
            table.Add(3, 13);
            table.Add(4, 14);
            table.Add(5, 15);
            table.Add(6, 16);
            table.Add(7, 17);
            table.Add(8, 18);
            var count = table.Count;
            Assert.AreEqual(8, count);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void TestIfAddingASameKeyThrows()
        {
            var table = new HashTable<int, int>();

            table.Add(1, 11);
            table.Add(1, 12);
            var count = table.Count;
            Assert.AreEqual(8, count);
        }

        [TestMethod]
        public void TestIfRemoveWorksCorrectly()
        {
            var table = new HashTable<int, int>();

            table.Add(1, 11);
            table.Add(2, 12);
            table.Add(3, 13);
            table.Add(4, 14);
            table.Add(5, 15);
            table.Add(6, 16);
            table.Add(7, 17);
            table.Add(8, 18);

            var count = table.Count;
            Assert.AreEqual(8, count);
            table.Remove(4);
            Assert.AreEqual(false, table.Contains(4));
            Assert.AreEqual(7, table.Count);
        }

        [TestMethod]
        public void TestIfFindFindsTheValue()
        {
            var table = new HashTable<int, int>();

            table.Add(1, 11);
            Assert.AreEqual(11, table.Find(1));
        }

        [TestMethod]
        public void TestIfClearLeavesAnEmptyTable()
        {
            var table = new HashTable<int, int>();

            table.Add(1, 11);
            table.Add(2, 12);
            table.Add(3, 13);
            table.Add(4, 14);
            table.Add(5, 15);
            table.Add(6, 16);
            table.Add(7, 17);
            table.Add(8, 18);

            table.Clear();
            Assert.AreEqual(0, table.Count);
        }

        [TestMethod]
        public void TestKeysProperty()
        {
            var table = new HashTable<int, int>();

            table.Add(1, 11);
            table.Add(2, 12);
            table.Add(3, 13);
            table.Add(4, 14);
            table.Add(5, 15);
            table.Add(6, 16);
            table.Add(7, 17);
            table.Add(8, 18);

            Assert.AreEqual(8, table.Keys.Count);
        }
    }
}
