using Course;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1
{
    [TestClass]
    public class ConverArrayTest
    {
        ConverArray converArray = new ConverArray();
        [TestMethod]
        public void Test1Create()
        {
            converArray.CreateRandomArray();
            Assert.AreEqual(100, converArray.listInt.Count);
        }
        [TestMethod]
        public void Test2Conver()
        {
            converArray.listInt = new List<int>() { -100, -50, 40, 90 };
            List<int> expected = new List<int>() { -1, -1, 1, 1 };
            converArray.ChangeArray();
            for (int i = 0; i < expected.Count; i++)
            {
                if (expected[i] != converArray.listInt[i])
                {
                    Assert.Fail();
                    return;
                }
            }
            Assert.IsTrue(true);
        }
        [TestMethod]
        public void Test3Counting()
        {
            converArray.listInt = new List<int>() { -1, -1, 1, 1 };
            converArray.TransitionCounting();
            Assert.AreEqual(1, converArray.countMinus);
            Assert.AreEqual(0, converArray.countPlus);
        }
        [TestMethod]
        public void Test4Counting()
        {
            converArray.listInt = new List<int>() { -1, 1, -1, 1, -1, 1, -1, 1, 1, 1, 1, 1, 1, 1 };
            converArray.TransitionCounting();
            Assert.AreEqual(4, converArray.countMinus);
            Assert.AreEqual(3, converArray.countPlus);
        }
    }
}
