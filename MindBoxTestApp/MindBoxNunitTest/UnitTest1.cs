using MindBoxTestApp;

namespace MindBoxNunitTest
{
    /// <summary>
    /// Тестирование с помощью Nunit
    /// </summary>
    [TestFixture]
    public class Tests
    { 
        [Test]
        public void CircleSquareCalculationTest()
        {
            var circle = new Circle(4);
            var CircleSquare = circle.GetSquare();

            Assert.AreEqual(50.26548245743669, CircleSquare);
        }


        [Test]
        public void CircleNegativeRadiusTest()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Circle(-10));
        }

         
        [Test]
        public void TriangleSquareCalculationTest()
        {
            var Triangle = new Triangle(3, 4, 5);

            var TriangleSquare = Triangle.GetSquare();

            Assert.AreEqual(6, TriangleSquare);
        }


        [Test]
        public void IsRectangleTest()
        {
            //Arrange
            var triangle = new Triangle(3, 4, 5);

            //Act
            var IsRectangle = triangle.IstRectangle;

            //Assert
            Assert.AreEqual(true, IsRectangle);
        }

         
        [Test]
        public void NotRectangleTest()
        {
            //Arrange
            var triangle = new Triangle(6, 2, 5);

            //Act
            var IsRectangle = triangle.IstRectangle;

            //Assert
            Assert.AreEqual(false, IsRectangle);
        }
    }
}