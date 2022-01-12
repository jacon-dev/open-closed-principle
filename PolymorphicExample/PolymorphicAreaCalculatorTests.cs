using NUnit.Framework;

namespace OpenClose.PolymorphicExample
{
    [TestFixture]
    public class PolymorphicAreaCalculatorTests
    {
        private PolymorphicAreaCalculator sut;
        
        [SetUp]
        public void Setup()
        {
            sut = new PolymorphicAreaCalculator();
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