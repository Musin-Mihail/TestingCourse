using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Course;
namespace TestProject1
{
    [TestClass]
    public class PasswordTest
    {
        Password password = new Password();
        Options options = new Options();

        [TestMethod]
        public void Test1Count()
        {
            string actual = password.Create(50, options);
            Console.WriteLine(actual);
            Assert.AreEqual(50, actual.Length);
        }
        [TestMethod]
        public void Test2rusCapitalLetterGood()
        {

            options.rusCapitalLetter = true;
            string actual = password.Create(100, options);
            Console.WriteLine(actual);
            foreach (var item in actual)
            {
                if (password.rusSmallLetterList.Contains(item) == true ||
                    password.engCapitalLetterList.Contains(item) == true ||
                    password.engSmallLetterList.Contains(item) == true ||
                    password.symbolsList.Contains(item) == true)
                {
                    Assert.Fail($"Символа {item} не должно быть в пароле");
                    return;
                }
            }
            Assert.IsTrue(true);
        }
        [TestMethod]
        public void Test3symbolsGood()
        {
            options.symbols = true;
            string actual = password.Create(100, options);
            Console.WriteLine(actual);
            foreach (var item in actual)
            {
                if (password.rusCapitalLetterList.Contains(item) == true ||
                    password.rusSmallLetterList.Contains(item) == true ||
                    password.engCapitalLetterList.Contains(item) == true ||
                    password.engSmallLetterList.Contains(item) == true)
                {
                    Assert.Fail($"Символа {item} не должно быть в пароле");
                    return;
                }
            }
            Assert.IsTrue(true);
        }
        [TestMethod]
        public void Test4engSmallLetterBad()
        {
            options.engSmallLetter = true;
            string actual = password.Create(100, options);
            Console.WriteLine(actual);
            foreach (var item in actual)
            {
                if (password.rusCapitalLetterList.Contains(item) == true ||
                    password.rusSmallLetterList.Contains(item) == true ||
                    password.engCapitalLetterList.Contains(item) == true ||
                    password.engSmallLetterList.Contains(item) == true ||
                    password.symbolsList.Contains(item) == true)
                {
                    Console.WriteLine($"Символа {item} не должно быть в пароле");
                    Assert.IsTrue(true);
                    return;
                }
            }
            Assert.IsTrue(false);
        }
        [TestMethod]
        public void Test5ALLGood()
        {
            options.rusCapitalLetter = true;
            options.rusSmallLetter = true;
            options.engCapitalLetter = true;
            options.engSmallLetter = true;
            options.symbols = true;

            bool rusCapitalLetterbool = false;
            bool rusSmallLetterbool = false;
            bool engCapitalLetterbool = false;
            bool engSmallLetterbool = false;
            bool symbolsbool = false;

            string actual = password.Create(200, options);
            Console.WriteLine(actual);

            foreach (var item in actual)
            {
                if (password.rusCapitalLetterList.Contains(item) == true)
                {
                    rusCapitalLetterbool = true;
                }
                if (password.rusSmallLetterList.Contains(item) == true)
                {
                    rusSmallLetterbool = true;
                }
                if (password.engSmallLetterList.Contains(item) == true)
                {
                    engCapitalLetterbool = true;
                }
                if (password.engCapitalLetterList.Contains(item) == true)
                {
                    engSmallLetterbool = true;
                }
                if (password.symbolsList.Contains(item) == true)
                {
                    symbolsbool = true;
                }
            }
            Assert.AreEqual(true, rusCapitalLetterbool);
            Assert.AreEqual(true, rusSmallLetterbool);
            Assert.AreEqual(true, engCapitalLetterbool);
            Assert.AreEqual(true, engSmallLetterbool);
            Assert.AreEqual(true, symbolsbool);
        }
    }
}