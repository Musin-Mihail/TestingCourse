using Course;
namespace TestProject1
{
    [TestClass]
    public class Class1
    {
        ConvertInt convertInt = new ConvertInt();
        [TestMethod]
        public void Test1()
        {
            int number = 2;
            Assert.AreEqual("два", convertInt.Convert(number));
        }
        [TestMethod]
        public void Test2()
        {
            int number = 22;
            Assert.AreEqual("двадцатьдва", convertInt.Convert(number));
        }
        [TestMethod]
        public void Test2_2()
        {
            int number = 18;
            Assert.AreEqual("восемьнадцать", convertInt.Convert(number));
        }
        [TestMethod]
        public void Test3()
        {
            int number = 222;
            Assert.AreEqual("двестидвадцатьдва", convertInt.Convert(number));
        }
        [TestMethod]
        public void Test3_2()
        {
            int number = 214;
            Assert.AreEqual("двестичетырнадцать", convertInt.Convert(number));
        }
        [TestMethod]
        public void Test4()
        {
            int number = 2222;
            Assert.AreEqual("две тысячи двестидвадцатьдва", convertInt.Convert(number));
        }
        [TestMethod]
        public void Test4_2()
        {
            int number = 2216;
            Assert.AreEqual("две тысячи двестишестьдесят", convertInt.Convert(number));
        }
        [TestMethod]
        public void Test5()
        {
            int number = 22222;
            Assert.AreEqual("двадцатьдве тысячи двестидвадцатьдва", convertInt.Convert(number));
        }
        [TestMethod]
        public void Test5_2()
        {
            int number = 17217;
            Assert.AreEqual("семьнадцать тысяч двестисемьнадцать", convertInt.Convert(number));
        }
        [TestMethod]
        public void Test6()
        {
            int number = 10207;
            Assert.AreEqual("десять тысяч двестисемь", convertInt.Convert(number));
        }
        [TestMethod]
        public void Test7()
        {
            int number = 60050;
            Assert.AreEqual("шестьдесят тысяч пятьдесят", convertInt.Convert(number));
        }
    }
}