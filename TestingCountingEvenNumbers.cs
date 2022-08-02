using Course;
namespace TestProject1
{
    [TestClass]
    public class TestingCountingEvenNumbers
    {
        CountingEvenNumbers countingEvenNumbers = new CountingEvenNumbers();
        [TestMethod]
        public void Test1()
        {
            string array = "1;2;3;4;5;6;7;8;9;10";
            List<int> listInt = countingEvenNumbers.GetListInt(array);
            int summ = countingEvenNumbers.GetSumm(listInt);
            Assert.AreEqual(30, summ);
        }
        [TestMethod]
        public void Test2()
        {
            string array = "2;4;6;8;10;12;14;16";
            List<int> listInt = countingEvenNumbers.GetListInt(array);
            int summ = countingEvenNumbers.GetSumm(listInt);
            Assert.AreEqual(72, summ);
        }
        [TestMethod]
        public void Test3()
        {
            string array = "1;3;5;7;9;11;13;15";
            List<int> listInt = countingEvenNumbers.GetListInt(array);
            int summ = countingEvenNumbers.GetSumm(listInt);
            Assert.AreEqual(0, summ);
        }
        [TestMethod]
        public void Test4()
        {
            string array = "0;1;3;5;7;9;11;13;15";
            List<int> listInt = countingEvenNumbers.GetListInt(array);
            int summ = countingEvenNumbers.GetSumm(listInt);
            Assert.AreEqual(0, summ);
        }
        [TestMethod]
        public void Test5()
        {
            string array = "0;1;2;3;4;5;6;7;8;9;-10";
            List<int> listInt = countingEvenNumbers.GetListInt(array);
            int summ = countingEvenNumbers.GetSumm(listInt);
            Assert.AreEqual(10, summ);
        }
    }
}
