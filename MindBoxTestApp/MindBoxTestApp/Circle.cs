namespace MindBoxTestApp
{
    public class Circle : IShape
    {
        /// <summary>
        /// Радиус круга
        /// </summary>
        protected double Radius { get; }

        /// <summary>
        /// Круг
        /// </summary>
        /// <param name="rad">Радиус круга</param>
        /// <exception cref="ArgumentOutOfRangeException">Если радиус круга имеет отрицательное значение</exception>
        public Circle(double radius)
        {
            if (radius < 0)
            {
                throw new ArgumentOutOfRangeException("Радиус не может быть отрицательным");
            }
            Radius = radius;
        }

        /// <summary>
        /// Вычисление площади круга
        /// </summary>
        /// <returns></returns>
        public double GetSquare()
        {
            return Math.PI * (Math.Pow(Radius, 2));
        }

    }
}