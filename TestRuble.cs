using Course;
namespace TestProject1
{
    [TestClass]
    public class TestRuble
    {
        [TestMethod]
        public void Test1()
        {
            RubleClass ruble1 = new RubleClass(9, 18);
            RubleClass ruble2 = new RubleClass(9, 18);
            if (ruble1 + ruble2 != "восемнадцать рублей тридцать шесть копеек")
            {
                Assert.Fail("ruble1 + ruble2");
            }
            if (ruble1 - ruble2 != "ноль рублей ноль копеек")
            {
                Assert.Fail("ruble1 - ruble2");

            }
            if (ruble1 * ruble2 != "восемдесят четыре рубля двадцать семь копеек")
            {
                Assert.Fail("ruble1 * ruble2");

            }
            if (ruble1 / ruble2 != "один рубль ноль копеек")
            {
                Assert.Fail("ruble1 / ruble2");

            }
            if (ruble1 == ruble2 != true)
            {
                Assert.Fail("ruble1 == ruble2");

            }
            if (ruble1 != ruble2 != false)
            {
                Assert.Fail("ruble1 != ruble2");
            }
            Assert.IsTrue(true);
        }
        [TestMethod]
        public void Test2()
        {
            RubleClass ruble1 = new RubleClass(9, 18);
            RubleClass ruble2 = new RubleClass(-19, 18);
            if (ruble1 + ruble2 != "минус десять рублей ноль копеек")
            {
                Assert.Fail("ruble1 + ruble2");
            }
            if (ruble1 - ruble2 != "двадцать восемь рублей тридцать шесть копеек")
            {
                Assert.Fail("ruble1 - ruble2");

            }
            if (ruble1 * ruble2 != "минус сто семдесят шесть рублей семь копеек")
            {
                Assert.Fail("ruble1 * ruble2");

            }
            if (ruble1 / ruble2 != "минус ноль рублей сорок семь копеек")
            {
                Assert.Fail("ruble1 / ruble2");

            }
            if (ruble1 == ruble2 != false)
            {
                Assert.Fail("ruble1 == ruble2");

            }
            if (ruble1 != ruble2 != true)
            {
                Assert.Fail("ruble1 != ruble2");
            }
            Assert.IsTrue(true);
        }
        [TestMethod]
        public void Test3()
        {
            RubleClass ruble1 = new RubleClass(9, 18);
            RubleClass ruble2 = new RubleClass(0, 0);
            if (ruble1 + ruble2 != "девять рублей восемнадцать копеек")
            {
                Assert.Fail("ruble1 + ruble2");
            }
            if (ruble1 - ruble2 != "девять рублей восемнадцать копеек")
            {
                Assert.Fail("ruble1 - ruble2");

            }
            if (ruble1 * ruble2 != "ноль рублей ноль копеек")
            {
                Assert.Fail("ruble1 * ruble2");

            }
            if (ruble1 / ruble2 != "Делить на 0 нельзя")
            {
                Assert.Fail("ruble1 / ruble2");

            }
            if (ruble1 == ruble2 != false)
            {
                Assert.Fail("ruble1 == ruble2");

            }
            if (ruble1 != ruble2 != true)
            {
                Assert.Fail("ruble1 != ruble2");
            }
            Assert.IsTrue(true);
        }
    }
}