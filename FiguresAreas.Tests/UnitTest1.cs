namespace FiguresAreas
{
    [TestClass]
    public class CircleTests
    {
        [TestMethod]
        public void CirceTest1()
        {
            double r = 5;

            var result = Areas.CalcArea(r);
            Assert.AreEqual(78.53981633974483, result);
        }

        [TestMethod]
        public void CirceTest2()
        {
            double r = -5;

            var result = Areas.CalcArea(r);
            Assert.AreEqual(-1, result);
        }

        [TestMethod]
        public void CirceTest3()
        {
            double r = 10;

            var result = Areas.CalcArea(r);
            Assert.AreEqual(314.1592653589793, result);
        }
    }
    [TestClass]
    public class TriangleTests
    {
        [TestMethod]
        public void TriangleTest1()
        {
            double a = 5;
            double b = 8;
            double c = 4;

            var result = Areas.CalcArea(a, b, c);
            Assert.AreEqual(8.181534085976786, result);
        }
        [TestMethod]
        public void TriangleTest2()
        {
            double a = 3;
            double b = 3;
            double c = 3;

            var result = Areas.CalcArea(a, b, c);
            Assert.AreEqual(3.897114317029974, result);
        }

        [TestMethod]
        public void TriangleTest3()
        {
            double a = 0;
            double b = -1;
            double c = 15;

            var result = Areas.CalcArea(a, b, c);
            Assert.AreEqual(-1, result);
        }

        [TestMethod]
        public void TriangleTest4()
        {
            double a = 5;
            double b = 12;
            double c = 8;

            var result = Areas.CalcArea(a, b, c);
            Assert.AreEqual(14.523687548277813, result);
        }
    }
}