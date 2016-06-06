using Microsoft.VisualStudio.TestTools.UnitTesting;
using SinglyLinkedList;

namespace SingleListUnit
{
    [TestClass]
    public class ListSingleTests
    {
        private ListSingle _list;

        [TestInitialize]
        public void BeforeEach()
        {
            _list = new ListSingle();
        }

        [TestMethod]
        public void CreateEmpty()
        {
            Assert.AreEqual("", _list.ForString());
        }

        [TestMethod]
        public void InsertOneElement()
        {
            _list.AddNewElement(5);
            
            Assert.AreEqual("5", _list.ForString());
        }

        [TestMethod]
        public void InsertSeveralElements()
        {
            _list.AddNewElement(5);
            _list.AddNewElement(8);
            _list.AddNewElement(2);
            
            Assert.AreEqual("5, 8, 2", _list.ForString());
        }

        [TestMethod]
        public void DeleteElementFromEmpty()
        {
            _list.DeleteSomeElement(5);
            
            Assert.AreEqual("", _list.ForString());
        }

        [TestMethod]
        public void DeleteSingleElement()
        {
            _list.AddNewElement(5);
            
            _list.DeleteSomeElement(5);
            
            Assert.AreEqual("", _list.ForString());
       }

        [TestMethod]
        public void DeleteRepeatedElements()
        {
            _list.AddNewElement(2);
            _list.AddNewElement(2);
            _list.AddNewElement(5);
            _list.AddNewElement(9);
            _list.AddNewElement(2);

            _list.DeleteSomeElement(2);

            Assert.AreEqual("5, 9", _list.ForString());
        }

        [TestMethod]
        public void DeleteAllElements()
        {
            _list.AddNewElement(5);
            _list.AddNewElement(5);
            _list.AddNewElement(5);
            _list.AddNewElement(5);

            _list.DeleteSomeElement(5);

            Assert.AreEqual("", _list.ForString());
        }
    }
}
