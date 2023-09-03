namespace MindBoxTestApp
{
    /// <summary>
    /// Вычисление площади фигуры без знания типа фигуры
    /// </summary>
    public class SquareCalculator
    {
        public double CalculateSquare(IShape shape)
        {
            return shape.GetSquare();
        }
    }
}
