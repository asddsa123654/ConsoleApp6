using System;

class Program
{
    // Масив з назвами місяців
    static string[] months = new string[] { "Січень", "Лютий", "Березень", "Квітень", "Травень", "Червень",
                                             "Липень", "Серпень", "Вересень", "Жовтень", "Листопад", "Грудень" };

    // Масив середніх температур для кожного місяця
    static double[] temperatures = new double[] { -5.0, -3.0, 5.0, 10.0, 15.0, 20.0,
                                                  25.0, 24.0, 15.0, 8.0, 3.0, -1.0 };

    // Делегат для виведення назви місяця і температури
    delegate void MonthInfoDelegate(int monthIndex);

    // Метод для виведення інформації про місяць
    static void PrintMonthInfo(int monthIndex)
    {
        Console.WriteLine($"Місяць: {months[monthIndex - 1]}, Середня температура: {temperatures[monthIndex - 1]}°C");
    }

    static void Main()
    {
        // Масив індексів місяців для вибору
        int[] monthIndices = { 1, 4, 7 };  // Січень, Квітень, Липень

        // Створення делегата
        MonthInfoDelegate monthInfoDelegate = new MonthInfoDelegate(PrintMonthInfo);

        // Групове викликання методів для трьох місяців
        foreach (int index in monthIndices)
        {
            monthInfoDelegate(index);
        }

        Console.ReadKey();
    }
}
