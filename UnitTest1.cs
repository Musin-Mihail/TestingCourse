using Course;
namespace TestProject
{
    [TestClass]
    public class UnitTest1
    {
        Words wordsGame = new Words();
        [TestMethod]
        public void Test1ShortWord()
        {
            wordsGame.usedWords.Clear();
            wordsGame.dictionary.Clear();
            wordsGame.startGame = true;
            wordsGame.endCurrentchar = ' ';

            string word = "f";
            Assert.IsFalse(wordsGame.WordCheck(word));
        }
        [TestMethod]
        public void Test2NoWordInDictionary()
        {
            wordsGame.usedWords.Clear();
            wordsGame.dictionary.Clear();
            wordsGame.startGame = true;
            wordsGame.endCurrentchar = ' ';

            wordsGame.dictionary.Add("����");

            string word = "������";
            Assert.IsFalse(wordsGame.WordCheck(word));
        }

        [TestMethod]
        public void Test3InvalidFirstLetter()
        {
            wordsGame.usedWords.Clear();
            wordsGame.dictionary.Clear();
            wordsGame.startGame = true;
            wordsGame.endCurrentchar = ' ';

            wordsGame.usedWords.Add("������");
            string word = "������";

            wordsGame.dictionary.Add("������");

            Assert.IsFalse(wordsGame.WordCheck(word));
        }
        [TestMethod]
        public void Test4TheWordHasBeen()
        {
            wordsGame.usedWords.Clear();
            wordsGame.dictionary.Clear();
            wordsGame.startGame = true;
            wordsGame.endCurrentchar = '�';

            wordsGame.usedWords.Add("������");
            wordsGame.dictionary.Add("������");

            string word = "������";
            Assert.IsFalse(wordsGame.WordCheck(word));
        }
        [TestMethod]
        public void Test5AllGood()
        {
            wordsGame.usedWords.Clear();
            wordsGame.dictionary.Clear();
            wordsGame.startGame = true;
            wordsGame.endCurrentchar = '�';

            wordsGame.dictionary.Add("������");

            string word = "������";
            Assert.IsTrue(wordsGame.WordCheck(word));
        }
    }
}