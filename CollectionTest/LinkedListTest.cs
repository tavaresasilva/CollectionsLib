using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Text;
using com.tavaresasilva.MyOwnCollections;

namespace com.tavaresasilva.MyOwnCollections.Test
{
    [TestClass]
    public class LinkedListTest
    {
        [TestMethod]
        public void CanICreateALinkedList_Success()
        {
            //Act
            var linkedList = new LinkedList();
            var typeOfLinkedList = typeof(LinkedList);

            //Assert
            Assert.IsInstanceOfType(linkedList, typeOfLinkedList);
        }

        [TestMethod]
        public void Add_Success()
        {
            //Arrage
            int expectedListCount = 3;
            LinkedList linkedList = new LinkedList();


            //Act
            linkedList.Add(12);
            linkedList.Add(13);
            linkedList.Add(16);

            //Assert
            Assert.AreEqual(expectedListCount, linkedList.Count());

            Assert.IsTrue(linkedList.Contains(12));
            Assert.IsTrue(linkedList.Contains(13));
            Assert.IsTrue(linkedList.Contains(16));

            Assert.IsFalse(linkedList.Contains(50));
            Assert.IsFalse(linkedList.Contains(35));

        }

        [TestMethod]
        public void Contains_True()
        {
            //Arrenge
            LinkedList list = new LinkedList();
            list.Add(24);
            list.Add(12);

            //Act
            var hasValue = list.Contains(12);

            //Assert
            Assert.IsTrue(hasValue);

        }

        [TestMethod]
        public void Contains_False()
        {
            //Arrenge
            LinkedList list = new LinkedList();
            list.Add(24);
            list.Add(12);

            //Act
            var hasValue = list.Contains(100);

            //Assert
            Assert.IsFalse(hasValue);

        }

        [TestMethod]
        public void Next_Success()
        {
            //Arrange
            LinkedList list = new LinkedList();

            list.Add(10);
            list.Add(20);
            list.Add(30);
            list.Add(40);

            //Act
            Node node = list.GetFirstNodeWithValue(20);
            Node nextNode = list.Next(node);

            //Assert
            Assert.AreEqual(10, nextNode.Value);

        }

        [TestMethod]
        public void Previous_Success()
        {
            //Arrange
            LinkedList list = new LinkedList();

            list.Add(10);
            list.Add(20);
            list.Add(30);
            list.Add(40);

            //Act
            Node node = list.GetFirstNodeWithValue(20);
            Node previousNode = list.Previous(node);

            //Assert
            Assert.AreEqual(30, previousNode.Value);

        }

        [TestMethod]
        public void GetFirstNodeWithValue_SuccessNode()
        {
            //Arrange
            LinkedList list = new LinkedList();

            list.Add(10);
            list.Add(20);
            list.Add(35);


            //Act
            var node = list.GetFirstNodeWithValue(20);

            //Assert
            Assert.AreEqual(20, node.Value);

        }

        [TestMethod]
        public void GetFirstNodeWithValue_Null()
        {
            //Arrange
            LinkedList list = new LinkedList();

            list.Add(10);
            list.Add(20);
            list.Add(35);


            //Act
            var node = list.GetFirstNodeWithValue(50);

            //Assert
            Assert.AreEqual(null, node);

        }

        [TestMethod]
        public void IsEmpty_False()
        {
            //Arrange
            LinkedList list = new LinkedList();
            list.Add(10);

            //Act
            bool isEmpty = list.IsEmpty();

            //Assert
            Assert.IsFalse(isEmpty);
        }

        [TestMethod]
        public void IsEmpty_True()
        {
            //Arrange
            LinkedList list = new LinkedList();

            //Act
            bool isEmpty = list.IsEmpty();

            //Assert
            Assert.IsTrue(isEmpty);
        }

        [TestMethod]
        public void Clear_Success()
        {
            //Arrange
            LinkedList list = new LinkedList();
            list.Add(10);
            list.Add(20);

            //Act

            list.Clear();

            //Assert

            Assert.AreEqual(0, list.Count());
            Assert.IsTrue(list.IsEmpty());

        }
    }
}
