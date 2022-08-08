using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Course;

namespace TestProject1
{
    [TestClass]
    public class CalculatorTest
    {
        Calculator calculator = new Calculator();
        [TestMethod]
        public void TestPlus()
        {
            float x = 4;
            float y = 5;
            float actual = calculator.Plus(x,y);
            float expected = 9;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMinus()
        {
            float x = 4;
            float y = 5;
            float actual = calculator.Minus(x, y);
            float expected = -1;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMultiply()
        {
            float x = 4;
            float y = 5;
            float actual = calculator.Multiply(x, y);
            float expected = 20;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestDivide()
        {
            float x = 4;
            float y = 5;
            float actual = calculator.Divide(x, y);
            float expected = 0.8f;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMultiplyArray1Good()
        {
            List<int> list = new List<int>() { 1, 2, 3, 4, 5 };
            List<float> actual = calculator.MultiplyArray(list);
            List<float> expected = new List<float>() { 3, 4, 9, 8, 15 };
            for (int i = 0; i < actual.Count; i++)
            {
                if (actual[i] != expected[i])
                {
                    Console.WriteLine($"Значение {i} не совпадает: " + actual[i] + " - " + expected[i]);

                    return;
                }
            }
            Console.WriteLine("Все значения совпадают");
            Assert.IsTrue(true);
        }
        [TestMethod]
        public void TestMultiplyArray2Bad9_10()
        {
            List<int> list = new List<int>() { 1, 2, 3, 4, 5 };
            List<float> actual = calculator.MultiplyArray(list);
            List<float> expected = new List<float>() { 3, 4, 10, 8, 15 };
            for (int i = 0; i < actual.Count; i++)
            {
                if (actual[i] != expected[i])
                {
                    Console.WriteLine($"Значение под индексом {i} не совпадают: " + actual[i] + " - " + expected[i]);
                    Assert.IsTrue(true);
                    return;
                }
            }
            Console.WriteLine("Все значения совпадают");
            Assert.IsTrue(false);
        }
    }
}