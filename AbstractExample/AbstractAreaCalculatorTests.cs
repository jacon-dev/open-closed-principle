﻿using NUnit.Framework;
using OpenClose.AbstractExample;

namespace OpenClose
{
    [TestFixture]
    public class AbstractAreaCalculatorTests
    {
        private AbstractAreaCalculator sut;

        [SetUp]
        public void Setup()
        {
            sut = new AbstractAreaCalculator();
        }
        
        [Test]
        public void TestThatRectangleCalculatesAsExpected()
        {
            var rectangle = new Rectangle();
            rectangle.Height = 10;
            rectangle.Width = 15;
            
            Assert.AreEqual(150, sut.CalculateShapeArea(new object[]{ rectangle }));
        }
        
        [Test]
        public void TestThatCircleCalculatesAsExpected()
        {
            var circle = new Circle();
            circle.Radius = 10;
            
            Assert.AreEqual(314.16, sut.CalculateShapeArea(new object[]{ circle }));
        }
        
    }
}