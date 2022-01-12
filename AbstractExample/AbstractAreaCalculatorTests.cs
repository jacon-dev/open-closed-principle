using NUnit.Framework;

namespace OpenClose.AbstractExample
{
    [TestFixture]
    public class AbstractAreaCalculatorTests
    {
        private AbstractAreaCalculator _sut;

        [SetUp]
        public void Setup()
        {
            _sut = new AbstractAreaCalculator();
        }
        
        [Test]
        public void TestThatRectangleCalculatesAsExpected()
        {
            var rectangle = new Rectangle
            {
                Height = 10,
                Width = 15
            };

            Assert.AreEqual(150, _sut.CalculateShapeArea(new object[]{ rectangle }));
        }
        
        [Test]
        public void TestThatCircleCalculatesAsExpected()
        {
            var circle = new Circle
            {
                Radius = 10
            };

            Assert.AreEqual(314.16, _sut.CalculateShapeArea(new object[]{ circle }));
        }
        
    }
}