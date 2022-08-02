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
            convertInt.number = "2.00";
            Assert.AreEqual("два рубля ноль копеек", convertInt.Convert());
        }
        [TestMethod]
        public void Test2()
        {
            convertInt.number = "22,01";
            Assert.AreEqual("двадцать два рубля одна копейка", convertInt.Convert());
        }
        [TestMethod]
        public void Test2_2()
        {
            convertInt.number = "18.12";
            Assert.AreEqual("восемнадцать рублей двенадцать копеек", convertInt.Convert());
        }
        [TestMethod]
        public void Test3()
        {
            convertInt.number = "222";
            Assert.AreEqual("двести двадцать два рубля ноль копеек", convertInt.Convert());
        }
        [TestMethod]
        public void Test3_2()
        {
            convertInt.number = "214.99";
            Assert.AreEqual("двести четырнадцать рублей девяносто девять копеек", convertInt.Convert());
        }
        [TestMethod]
        public void Test4()
        {
            convertInt.number = "2222.1";
            Assert.AreEqual("две тысячи двести двадцать два рубля одна копейка", convertInt.Convert());
        }
        [TestMethod]
        public void Test4_2()
        {
            convertInt.number = "2216.2";
            Assert.AreEqual("две тысячи двести шестнадцать рублей две копейки", convertInt.Convert());
        }
        [TestMethod]
        public void Test5()
        {
            convertInt.number = "22222,3";
            Assert.AreEqual("двадцать две тысячи двести двадцать два рубля три копейки", convertInt.Convert());
        }
        [TestMethod]
        public void Test5_2()
        {
            convertInt.number = "17217,04";
            Assert.AreEqual("семнадцать тысяч двести семнадцать рублей четыре копейки", convertInt.Convert());
        }
        [TestMethod]
        public void Test6()
        {
            convertInt.number = "10207.06";
            Assert.AreEqual("десять тысяч двести семь рублей шесть копеек", convertInt.Convert());
        }
        [TestMethod]
        public void Test7()
        {
            convertInt.number = "60050,15";
            Assert.AreEqual("шестьдесят тысяч пятьдесят рублей пятнадцать копеек", convertInt.Convert());
        }
        [TestMethod]
        public void Test8()
        {
            convertInt.number = "123456,87";
            Assert.AreEqual("сто двадцать три тысячи четыреста пятьдесят шесть рублей восемдесят семь копеек", convertInt.Convert());
        }
        [TestMethod]
        public void Test9()
        {
            convertInt.number = "900002,74";
            Assert.AreEqual("девятсот тысяч два рубля семдесят четыре копейки", convertInt.Convert());
        }
        [TestMethod]
        public void Test10()
        {
            convertInt.number = "121212,44";
            Assert.AreEqual("сто двадцать одна тысяча двести двенадцать рублей сорок четыре копейки", convertInt.Convert());
        }
        [TestMethod]
        public void Test11()
        {
            convertInt.number = "123456789,22";
            Assert.AreEqual("сто двадцать три миллиона четыреста пятьдесят шесть тысяч семьсот восемдесят девять рублей двадцать две копейки", convertInt.Convert());
        }
        [TestMethod]
        public void Test12()
        {
            convertInt.number = "100400700,90";
            Assert.AreEqual("сто миллионов четыреста тысяч семьсот рублей девяносто копеек", convertInt.Convert());
        }
        [TestMethod]
        public void Test13()
        {
            convertInt.number = "900000009.06";
            Assert.AreEqual("девятсот миллионов девять рублей шесть копеек", convertInt.Convert());
        }
        [TestMethod]
        public void Test14()
        {
            convertInt.number = "12345678912.11";
            Assert.AreEqual("двенадцать миллиардов триста сорок пять миллионов шестьсот семдесят восемь тысяч девятсот двенадцать рублей одинадцать копеек", convertInt.Convert());
        }
        [TestMethod]
        public void Test15()
        {
            convertInt.number = "908070605040.54";
            Assert.AreEqual("девятсот восемь миллиардов семдесят миллионов шестьсот пять тысяч сорок рублей пятьдесят четыре копейки", convertInt.Convert());
        }
        [TestMethod]
        public void Test16()
        {
            convertInt.number = "908070605040123,76";
            Assert.AreEqual("девятсот восемь триллионов семдесят миллиардов шестьсот пять миллионов сорок тысяч сто двадцать три рубля семдесят шесть копеек", convertInt.Convert());
        }
        [TestMethod]
        public void Test17()
        {
            convertInt.number = "";
            Assert.AreEqual("ноль рублей ноль копеек", convertInt.Convert());
        }
        [TestMethod]
        public void Test18()
        {
            convertInt.number = ",77";
            Assert.AreEqual("ноль рублей семдесят семь копеек", convertInt.Convert());
        }
        [TestMethod]

        public void Test19()
        {
            convertInt.number = "-2,77";
            Assert.AreEqual("минус два рубля семдесят семь копеек", convertInt.Convert());
        }
    }
}