using System;

class Program
{
    // Універсальний делегат для операцій
    delegate T OperationDelegate<T>(T a, T b);

    // Методи для операцій
    static int Add(int a, int b) => a + b;
    static int Subtract(int a, int b) => a - b;
    static int Multiply(int a, int b) => a * b;
    static int Divide(int a, int b) => a / b;

    // Метод для операцій з дійсними числами
    static double Add(double a, double b) => a + b;
    static double Subtract(double a, double b) => a - b;
    static double Multiply(double a, double b) => a * b;
    static double Divide(double a, double b) => a / b;

    static void Main()
    {
        // Операції для цілих чисел
        OperationDelegate<int> operationInt = Add;
        Console.WriteLine($"10 + 5 = {operationInt(10, 5)}");

        operationInt = Subtract;
        Console.WriteLine($"10 - 5 = {operationInt(10, 5)}");

        operationInt = Multiply;
        Console.WriteLine($"10 * 5 = {operationInt(10, 5)}");

        operationInt = Divide;
        Console.WriteLine($"10 / 5 = {operationInt(10, 5)}");

        // Операції для дійсних чисел
        OperationDelegate<double> operationDouble = Add;
        Console.WriteLine($"10.5 + 5.3 = {operationDouble(10.5, 5.3)}");

        operationDouble = Subtract;
        Console.WriteLine($"10.5 - 5.3 = {operationDouble(10.5, 5.3)}");

        operationDouble = Multiply;
        Console.WriteLine($"10.5 * 5.3 = {operationDouble(10.5, 5.3)}");

        operationDouble = Divide;
        Console.WriteLine($"10.5 / 5.3 = {operationDouble(10.5, 5.3)}");

        Console.ReadKey();
    }
}
