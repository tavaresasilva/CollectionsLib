using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyOwnCollections;

namespace MyOwnCollectionsTest
{
    [TestClass]
    public class NodeTest
    {
        [TestMethod]
        public void CanICreateANode_Success()
        {
            //Arrange
            int value = 10;

            //Act
            var node = new Node(value);
            var nodeType = typeof(Node);

            //Assert
            Assert.IsInstanceOfType(node, nodeType);
            
        }

        [TestMethod]
        public void ConstructorWorks_Success()
        {
            //Arrange
            var value = 54;
            var expected = 54;
        
            //Act
            var node = new Node(value);
            var returned = node.Value;
            
            //Assert
            Assert.AreEqual(expected, returned);
        }

        [TestMethod]
        public void ReferenceToNext_Success()
        {
            //Arrange

            var node1Val = 10;
            var node2Val = 20;

            //Act
            var node2 = new Node(node2Val);
            var node1 = new Node(node1Val, node2);

            //Assert
            Assert.AreEqual(node2, node1.Next);
            Assert.AreEqual(null, node2.Next);
        }

        [TestMethod]
        public void ReferenceToPrevious_Success()
        {
            //Arrange

            var node1Val = 10;
            var node2Val = 20;
            var node3val = 30;

            //Act
            var node3 = new Node(node3val);
            var node2 = new Node(node2Val, node3, null);
            node3.Previous = node2;
            var node1 = new Node(node1Val, node2, null);
            node2.Previous = node1;

            //Assert
            Assert.AreEqual(node2, node3.Previous);
            Assert.AreEqual(node1, node2.Previous);
            Assert.AreEqual(null, node1.Previous);

        }

    }
}
