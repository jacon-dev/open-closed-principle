using NUnit.Framework;

namespace OpenClose.PolymorphicExample
{
    [TestFixture]
    public class PolymorphicAreaCalculatorTests
    {
        private PolymorphicAreaCalculator _sut;
        
        [SetUp]
        public void Setup()
        {
            _sut = new PolymorphicAreaCalculator();
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