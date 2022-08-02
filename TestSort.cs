using Course;
namespace TestProject1
{
    [TestClass]
    public class TestSort
    {
        [TestMethod]
        public void Test1ShortWord()
        {
            SortingInt sortingInt = new SortingInt();
            List<int> Badlist = new List<int>() { 5, 6, 4, 7, 3, 8, 2, 9, 1, 10 };
            List<int> Goodlist = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            List<int> Sortlist = sortingInt.Sorting(Badlist);

            bool good = true;
            for (int i = 0; i < Goodlist.Count; i++)
            {
                if (Goodlist[i] != Sortlist[i])
                {
                    good = false;
                    break;
                }
            }
            Assert.AreEqual(good, true);
        }
    }
}