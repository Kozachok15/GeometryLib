using GeometryLib;

namespace LibTests
{
    public class UnitTest1
    {
        [Fact]
        public void CircleArea_CalculatedCorrectly()
        {
            var circle = new Circle(5);
            Assert.Equal(78.54, Math.Round(circle.CalculateArea(), 2));
        }

        [Fact]
        public void TriangleArea_CalculatedCorrectly()
        {
            var triangle = new Triangle(3, 4, 5);
            Assert.Equal(6, triangle.CalculateArea());
        }

        [Fact]
        public void TriangleIsRightAngled_True()
        {
            var triangle = new Triangle(3, 4, 5);
            Assert.True(triangle.IsRightAngled());
        }

        [Fact]
        public void TriangleIsRightAngled_False()
        {
            var triangle = new Triangle(3, 4, 6);
            Assert.False(triangle.IsRightAngled());
        }

        [Fact]
        public void Circle_InvalidRadius()
        {
            Assert.Throws<ArgumentException>(() => new Circle(0));
            Assert.Throws<ArgumentException>(() => new Circle(-5));
        }

        [Fact]
        public void Triangle_InvalidSides()
        {
            Assert.Throws<ArgumentException>(() => new Triangle(0, 4, 5));
            Assert.Throws<ArgumentException>(() => new Triangle(3, -4, 5));
        }
    }
}