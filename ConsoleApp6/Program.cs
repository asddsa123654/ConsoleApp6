using System;

class Program
{
    // Делегат для обчислення площі фігури
    delegate double AreaDelegate(double x);

    // Метод для обчислення площі кола
    static double CircleArea(double radius)
    {
        return Math.PI * radius * radius;
    }

    // Метод для обчислення площі квадрата
    static double SquareArea(double side)
    {
        return side * side;
    }

    static void Main()
    {
        // Вхідні дані
        double radius = 5;
        double side = 4;

        // Делегати для обчислення площ
        AreaDelegate circleAreaDelegate = new AreaDelegate(CircleArea);
        AreaDelegate squareAreaDelegate = new AreaDelegate(SquareArea);

        // Виклик методів через делегати
        double circleArea = circleAreaDelegate(radius);
        double squareArea = squareAreaDelegate(side);

        // Виведення результатів
        Console.WriteLine($"Площа кола: {circleArea}");
        Console.WriteLine($"Площа квадрата: {squareArea}");

        // Порівняння площ
        if (circleArea > squareArea)
            Console.WriteLine("Площа кола більша.");
        else if (circleArea < squareArea)
            Console.WriteLine("Площа квадрата більша.");
        else
            Console.WriteLine("Площі однакові.");

        Console.ReadKey();
    }
}
