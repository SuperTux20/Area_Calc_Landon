using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShapeLib;

namespace AreaCalculatorTest
{
    [TestClass]
    public class AreaCalculatorTest
    {
        [TestMethod]
        public void Square()
        {
            Assert.AreEqual(49, Shaper.getSquareArea(7));
        }

        [TestMethod]
        public void SquareString()
        {
            Assert.AreEqual(16, Shaper.getSquareArea("four"));
        }

        [TestMethod]
        public void SquareStringInvalid()
        {
            Assert.AreEqual(null, Shaper.getSquareArea("error lmao"));
        }

        [TestMethod]
        public void RectParallelo()
        {
            Assert.AreEqual(700, Shaper.getRectangleArea(new double[] { 7, 100 }));
        }

        [TestMethod]
        public void Triangle()
        {
            Assert.AreEqual(5.3, Shaper.getRectangleArea(new double[] { 2, 5.3 }) / 2);
        }

        [TestMethod]
        public void Radius()
        {
            Assert.AreEqual(2, Shaper.getCircleRadius(4));
        }

        [TestMethod]
        public void Diameter()
        {
            Assert.AreEqual(8, Shaper.getCircleDiameter(4));
        }
    }
}