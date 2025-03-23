using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShapesLib;
using Lab10;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;

namespace Lab10_TESTS
{
    [TestClass]
    public class UnitTest1
    {
        // SHAPE TESTS ------------------------------------------------------------------------------------------------------------------------------------------------
        [TestMethod]
        public void ShapeConstructDefault()
        {
            Shape obj = new Shape();
            Assert.AreEqual(obj.Name, "Shape");
        }

        [TestMethod]
        public void ShapeConstructParams()
        {
            Shape obj = new Shape("olo");
            Assert.AreEqual(obj.Name, "olo");
        }

        [TestMethod]
        public void ShapeCopy()
        {
            Shape obj = new Shape("opa");
            Shape copy = new Shape(obj);
            Assert.AreEqual(obj.Name, copy.Name);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ShapeNullName()
        {
            Shape obj = new Shape(" ");
        }

        [TestMethod]
        public void ShapeRandomInit()
        {
            Shape obj = new Shape();
            obj.RandomInit();
            string[] nameArr = { "A", "B", "C", "D", "E", "F" };
            Assert.IsTrue(nameArr.Contains(obj.Name));
        }

        [TestMethod]
        public void ShapeEquals()
        {
            Shape obj1 = new Shape("ligma");
            Shape obj2 = new Shape("ligma");
            Assert.IsTrue(obj1.Equals(obj2));
        }

        [TestMethod]
        public void ShapeEqualsMismatch()
        {
            Shape obj1 = new Shape("Sugma");
            int obj2 = 10;
            Assert.IsFalse(obj1.Equals(obj2));
        }

        //CIRCLE TESTS --------------------------------------------------------------------------------------------------------------------------------------------------------
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CircleRadiusException()
        {
            Circle obj = new Circle();
            obj.Radius = -1;
        }

        [TestMethod]
        public void CircleConstructDefault()
        {
            Circle obj = new Circle();
            Assert.AreEqual(obj.Radius, 1);
        }

        [TestMethod]
        public void CircleConstructParams()
        {
            Circle obj = new Circle("iladies", 5.5);
            Assert.AreEqual(obj.Radius, 5.5);
        }

        [TestMethod]
        public void CircleRandomInit()
        {
            Circle obj = new Circle();
            obj.RandomInit();
            Assert.IsTrue(obj.Radius <= 100 && obj.Radius >= 0);
        }

        [TestMethod]
        public void CircleEquals()
        {
            Circle obj1 = new Circle("bofa", 15);
            Circle obj2 = new Circle("bofa", 15);
            Assert.IsTrue(obj1.Equals(obj2));
        }

        [TestMethod]
        public void CircleEqualsMismatch()
        {
            Circle obj1 = new Circle("biba", 15);
            Circle obj2 = new Circle("boba", 15);
            Assert.IsFalse(obj1.Equals(obj2));
        }

        // RECTANGLE TESTS -----------------------------------------------------------------------------------------------------------------------------------------------
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void RectangleLengthException()
        {
            Rectangle obj = new Rectangle();
            obj.Length = -1;
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void RectangleWidthException()
        {
            Rectangle obj = new Rectangle();
            obj.Width = -1;
        }

        [TestMethod]
        public void RectangleConstructDefault()
        {
            Rectangle obj = new Rectangle();
            Assert.AreEqual(obj.Length, 10);
            Assert.AreEqual(obj.Width, 5);
        }

        [TestMethod]
        public void RectangleConstructParams()
        {
            Rectangle obj = new Rectangle("Candies", 99, 1);
            Assert.AreEqual(obj.Length, 99);
            Assert.AreEqual(obj.Width, 1);
        }

        [TestMethod]
        public void RectangleRandomInit()
        {
            Rectangle obj = new Rectangle();
            obj.RandomInit();
            Assert.IsTrue(obj.Length <= 100 && obj.Length >= 0);
            Assert.IsTrue(obj.Width <= 100 && obj.Width >= 0);
        }

        [TestMethod]
        public void RectangleEquals()
        {
            Rectangle obj1 = new Rectangle("peepee", 5, 4);
            Rectangle obj2 = new Rectangle("peepee", 5, 4);
            Assert.IsTrue(obj1.Equals(obj2));
        }

        [TestMethod]
        public void RectangleEqualsNameMismatch()
        {
            Rectangle obj1 = new Rectangle("peepee", 5, 4);
            Rectangle obj2 = new Rectangle("poopoo", 5, 4);
            Assert.IsFalse(obj1.Equals(obj2));
        }

        [TestMethod]
        public void RectangleEqualsValueMismatch()
        {
            Rectangle obj1 = new Rectangle("peepee", 4, 4);
            Rectangle obj2 = new Rectangle("peepee", 5, 4);
            Assert.IsFalse(obj1.Equals(obj2));
        }

        // PARALLELEPIPED TESTS ----------------------------------------------------------------------------------------------------------------------------------------------------
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ParHeightException()
        {
            Par obj = new Par();
            obj.Height = -1;
        }

        [TestMethod]
        public void ParConstructDefualt()
        {
            Par obj = new Par();
            Assert.AreEqual(obj.Height, 10);
        }

        [TestMethod]
        public void ParConstructParams()
        {
            Par obj = new Par("jijij", 1, 1, 1);
            Assert.AreEqual(obj.Height, 1);
        }

        [TestMethod]
        public void ParRandomInit()
        {
            Par obj = new Par();
            obj.RandomInit();
            Assert.IsTrue(obj.Height <= 100 && obj.Height >= 0);
        }

        [TestMethod]
        public void ParEquals()
        {
            Par obj1 = new Par("squomp", 1, 2, 3.4);
            Par obj2 = new Par("squomp", 1, 2, 3.4);
            Assert.IsTrue(obj1.Equals(obj2));
        }

        [TestMethod]
        public void ParEqualsValueMismatch()
        {
            Par obj1 = new Par("squomp", 1, 2, 3.4);
            Par obj2 = new Par("squomp", 1, 2, 3);
            Assert.IsFalse(obj1.Equals(obj2));
        }

        [TestMethod]
        public void ParEqualsNameMismatch()
        {
            Par obj1 = new Par("squomp", 1, 2, 3.4);
            Par obj2 = new Par("squarmf", 1, 2, 3.4);
            Assert.IsFalse(obj1.Equals(obj2));
        }
    }
}
