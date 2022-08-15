using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Course;

namespace TestProject1
{
    [TestClass]
    public class SinusTest
    {
        Sinus sinus = new Sinus();
        [TestMethod]
        public void Test1()
        {
            sinus.Length = 5;
            sinus.Сalculation();
            Assert.AreEqual(0, sinus.doublesList[0]);
            Assert.AreEqual(1, sinus.doublesList[1]);
        }
        [TestMethod]
        public void Test2()
        {
            sinus.Length = 9;
            sinus.Сalculation();
            Assert.AreEqual(0, sinus.doublesList[0]);
            Assert.AreEqual(1, sinus.doublesList[2]);
        }
        [TestMethod]
        public void Test3()
        {
            Assert.ThrowsException<MustBeLessThanFive>(() =>
                {
                    sinus.Length = 4;
                    sinus.Сalculation();
                });
        }
        [TestMethod]
        public void Test4()
        {
            Assert.ThrowsException<NoEvenNumbers>(() =>
            {
                sinus.Length = 8;
                sinus.Сalculation();
            });
        }
    }
}
