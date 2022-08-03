
using Course;

namespace TestProject1
{
    [TestClass]
    public class TestSearchTwoVowelsWord
    {
        SearchTwoVowelsWord searchTwoVowelsWord = new SearchTwoVowelsWord();
        [TestMethod]
        public void Test1()
        {
            string text = " как привет как дела привет дела как ";
            Dictionary<string, List<int>> dictionary = searchTwoVowelsWord.Start(text);
            Assert.AreEqual(1, dictionary.Count);
            Assert.AreEqual(true, dictionary.ContainsKey("привет"));
            Assert.AreEqual(2, dictionary["привет"].Count);
        }
        [TestMethod]
        public void Test2()
        {
            string text = " однажды в студёную зимнюю пору ";
            Dictionary<string, List<int>> dictionary = searchTwoVowelsWord.Start(text);

            Assert.AreEqual(3, dictionary.Count);

            Assert.AreEqual(true, dictionary.ContainsKey("однажды"));
            Assert.AreEqual(true, dictionary.ContainsKey("студёную"));
            Assert.AreEqual(true, dictionary.ContainsKey("зимнюю"));

            Assert.AreEqual(1, dictionary["однажды"].Count);
            Assert.AreEqual(1, dictionary["студёную"].Count);
            Assert.AreEqual(1, dictionary["зимнюю"].Count);
        }
        [TestMethod]
        public void Test3()
        {
            string text = " п   пр   при   прив   приве привет  прив   приве  ";
            Dictionary<string, List<int>> dictionary = searchTwoVowelsWord.Start(text);

            Assert.AreEqual(5, dictionary.Count);

            Assert.AreEqual(true, dictionary.ContainsKey("пр"));
            Assert.AreEqual(true, dictionary.ContainsKey("при"));
            Assert.AreEqual(true, dictionary.ContainsKey("прив"));
            Assert.AreEqual(true, dictionary.ContainsKey("приве"));
            Assert.AreEqual(true, dictionary.ContainsKey("привет"));

            Assert.AreEqual(1, dictionary["пр"].Count);
            Assert.AreEqual(1, dictionary["при"].Count);
            Assert.AreEqual(2, dictionary["прив"].Count);
            Assert.AreEqual(2, dictionary["приве"].Count);
            Assert.AreEqual(1, dictionary["привет"].Count);
        }
    }
}
