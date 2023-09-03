using MindBoxTestApp;

namespace MindBoxUnitTest
{
    /// <summary>
    /// Тестирование  с помощью xUnit
    /// </summary>
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            [Fact]
            void GetSquareCircle() 
            {
                var circle = new Circle(4);
                var CircleSquare = circle.GetSquare();

                Assert.Equal(50.26548245743669, CircleSquare);
            }

            [Fact]
            void CircleNegativeRadiusTest()
            {
                Assert.Throws<ArgumentOutOfRangeException>(() => new Circle(-10));
            }

            [Fact]
            void GetSquareTriangle()
            {
                var Triangle = new Triangle(3, 4, 5); 
                var TriangleSquare = Triangle.GetSquare(); 

                Assert.Equal(6, TriangleSquare);
            }

            [Fact]
            void IsRectangleTest()
            { 
                var triangle = new Triangle(3, 4, 5);
                 
                var IsRectangle = triangle.IstRectangle;
                 
                Assert.True(IsRectangle);
            }

            [Fact]
            void NotRectangleTest()
            {
                //Arrange
                var triangle = new Triangle(6, 2, 5);

                //Act
                var IsRectangle = triangle.IstRectangle;

                //Assert
                Assert.False(IsRectangle);
            }

        }
    }
}