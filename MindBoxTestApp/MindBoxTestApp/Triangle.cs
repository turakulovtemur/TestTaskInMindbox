namespace MindBoxTestApp
{
    public class Triangle : IShape
    {
        /// <summary>
        /// Первая сторона
        /// </summary>
        protected double FirstSide { get; }

        /// <summary>
        /// Вторая сторона
        /// </summary>
        protected double SecondSide { get; }

        /// <summary>
        /// Третья сторона
        /// </summary>
        protected double ThirdSide { get; }

        private readonly bool isRectangle;

        /// <summary>
        /// Является ли треугольник прямоугольным
        /// </summary>
        public bool IstRectangle => isRectangle;



        /// <summary>
        /// Треугольник
        /// </summary>
        /// <param name="firstNum">Первая сторона</param>
        /// <param name="secondNum">Вторая сторона</param>
        /// <param name="thirdNum">Третья сторона</param>
        /// <exception cref="ArgumentOutOfRangeException">Если сторона треугольника имеет отрицательное значение</exception>
        public Triangle(double firstNum, double secondNum, double thirdNum)
        {
            if (firstNum < 0 || secondNum < 0 || thirdNum < 0)
            {
                throw new ArgumentOutOfRangeException("Сторона не может быть отрицательной");
            }

            FirstSide = firstNum;
            SecondSide = secondNum;
            ThirdSide = thirdNum;
            isRectangle = CheckSquareness();
        }

        /// <summary>
        /// Проверка, является ли треугольник прямоугольным
        /// </summary>
        private bool CheckSquareness()
        {
            var max = Math.Max(FirstSide, Math.Max(SecondSide, ThirdSide));
            var maxSqr = Math.Pow(max, 2);
            return maxSqr + maxSqr == (FirstSide * FirstSide) + (SecondSide * SecondSide) + (ThirdSide * ThirdSide);
        }

        /// <summary>
        /// Вычисление площади треугольника
        /// </summary>
        public double GetSquare()
        {
            var perimeter = 0.5 * (FirstSide + SecondSide + ThirdSide);
            return Math.Sqrt(perimeter * (perimeter - FirstSide) * (perimeter - SecondSide) * (perimeter - ThirdSide));
        }
    }
}
