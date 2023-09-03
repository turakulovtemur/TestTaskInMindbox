

using MindBoxTestApp;

Console.WriteLine("Введите радиус окружности для нахождения площади");
double number = Convert.ToDouble(Console.ReadLine());
Circle circle = new Circle(number);
Console.WriteLine($"Площадь круга радиусом {number} равна {circle.GetSquare()}");

Console.WriteLine("------------------------------------------------------------------------------------------------");
Console.WriteLine("Введите длины сторон треугольника: a, b, c через enter");
double FirstNum = Convert.ToDouble(Console.ReadLine());
double SecondNum = Convert.ToDouble(Console.ReadLine());
double ThirdNum = Convert.ToDouble(Console.ReadLine());
Triangle triangle = new Triangle(FirstNum, SecondNum, ThirdNum);
var square = triangle.GetSquare();


Console.WriteLine($"Площадь треугольника равна {square}");
if (triangle.IstRectangle == true)
{
    Console.WriteLine($"Треугольник прямоугольный");
}
Console.WriteLine("------------------------------------------------------------------------------------------------");
Console.WriteLine($"Вычисление площади фигуры без знания типа фигуры в compile-time");
Console.WriteLine("Введите фигуру круг или треугольник");
SquareCalculator calculator = new SquareCalculator();
var word = Console.ReadLine();

switch (word.ToLower())
{
    case "круг":
        Console.WriteLine("Введите радиус окружности для нахождения площади");
        double num = Convert.ToDouble(Console.ReadLine());
        circle = new Circle(num);
        Console.WriteLine($"Площадь круга равна {calculator.CalculateSquare(circle)}");
        break;
    case "треугольник":
        Console.WriteLine("Введите длины сторон треугольника: a, b, c через enter");
        double firstNum = Convert.ToDouble(Console.ReadLine());
        double secondNum = Convert.ToDouble(Console.ReadLine());
        double thirdNum = Convert.ToDouble(Console.ReadLine());
        triangle = new Triangle(firstNum, secondNum, thirdNum);
        Console.WriteLine($"Площадь треугольника равна {calculator.CalculateSquare(triangle)}");
        if (triangle.IstRectangle == true)
        {
            Console.WriteLine($"Треугольник прямоугольный");
        }
        break;

}