using Course;
namespace TestProject1
{
    [TestClass]
    public class TestReplaceChar
    {
        ReplaceCharClass replaceCharClass = new ReplaceCharClass();
        [TestMethod]
        public void Test1()
        {
            string text = "привет как дела";
            Assert.AreEqual("пpивeт кaк дeлa", replaceCharClass.Start(text));
        }
    }
}