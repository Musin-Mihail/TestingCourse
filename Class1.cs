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
            convertInt.number = 2;
            Assert.AreEqual("два", convertInt.Convert());
        }
        [TestMethod]
        public void Test2()
        {
            convertInt.number = 22;
            Assert.AreEqual("двадцать два", convertInt.Convert());
        }
        [TestMethod]
        public void Test2_2()
        {
            convertInt.number = 18;
            Assert.AreEqual("восемнадцать", convertInt.Convert());
        }
        [TestMethod]
        public void Test3()
        {
            convertInt.number = 222;
            Assert.AreEqual("двести двадцать два", convertInt.Convert());
        }
        [TestMethod]
        public void Test3_2()
        {
            convertInt.number = 214;
            Assert.AreEqual("двести четырнадцать", convertInt.Convert());
        }
        [TestMethod]
        public void Test4()
        {
            convertInt.number = 2222;
            Assert.AreEqual("две тысячи двести двадцать два", convertInt.Convert());
        }
        [TestMethod]
        public void Test4_2()
        {
            convertInt.number = 2216;
            Assert.AreEqual("две тысячи двести шестнадцать", convertInt.Convert());
        }
        [TestMethod]
        public void Test5()
        {
            convertInt.number = 22222;
            Assert.AreEqual("двадцать две тысячи двести двадцать два", convertInt.Convert());
        }
        [TestMethod]
        public void Test5_2()
        {
            convertInt.number = 17217;
            Assert.AreEqual("семнадцать тысяч двести семнадцать", convertInt.Convert());
        }
        [TestMethod]
        public void Test6()
        {
            convertInt.number = 10207;
            Assert.AreEqual("десять тысяч двести семь", convertInt.Convert());
        }
        [TestMethod]
        public void Test7()
        {
            convertInt.number = 60050;
            Assert.AreEqual("шестьдесят тысяч пятьдесят", convertInt.Convert());
        }
        [TestMethod]
        public void Test8()
        {
            convertInt.number = 123456;
            Assert.AreEqual("сто двадцать три тысячи четыреста пятьдесят шесть", convertInt.Convert());
        }
        [TestMethod]
        public void Test9()
        {
            convertInt.number = 900002;
            Assert.AreEqual("девятсот тысяч два", convertInt.Convert());
        }
        [TestMethod]
        public void Test10()
        {
            convertInt.number = 121212;
            Assert.AreEqual("сто двадцать одна тысяча двести двенадцать", convertInt.Convert());
        }
    }
}