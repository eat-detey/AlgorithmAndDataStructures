using System;

class Program
{
    static void Main()
    {
        // Тест задачи 1.4
        Console.WriteLine("--- Тест задачи 1.4 (Подсчет положительных чисел) ---");
        int[] test1 = { 1, -2, 3, 0, 5, -1 };
        int[] test2 = { -5, -3, -1 };
        int[] test3 = { 0, 0, 0 };
        int[] test4 = { 10, 20, 30 };
        int[] test5 = { };
        int[] test6 = null;

        Console.WriteLine($"Положительных в [1,-2,3,0,5,-1]: {CountPositive(test1)}"); // 3
        Console.WriteLine($"Положительных в [-5,-3,-1]: {CountPositive(test2)}");      // 0
        Console.WriteLine($"Положительных в [0,0,0]: {CountPositive(test3)}");         // 0
        Console.WriteLine($"Положительных в [10,20,30]: {CountPositive(test4)}");      // 3
        Console.WriteLine($"Положительных в []: {CountPositive(test5)}");              // 0
        Console.WriteLine($"Положительных в null: {CountPositive(test6)}");            // 0

        // Тест задачи 2.4
        Console.WriteLine("\n--- Тест задачи 2.4 (Високосный год) ---");
        Console.WriteLine($"2000 високосный? {IsLeapYear(2000)}");   // true
        Console.WriteLine($"2020 високосный? {IsLeapYear(2020)}");   // true
        Console.WriteLine($"1900 високосный? {IsLeapYear(1900)}");   // false
        Console.WriteLine($"2023 високосный? {IsLeapYear(2023)}");   // false
        Console.WriteLine($"2024 високосный? {IsLeapYear(2024)}");   // true
    }

    // Решение задачи 1.4
    static int CountPositive(int[] array)
    {
        if (array == null || array.Length == 0)
            return 0;

        int count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
                count++;
        }
        return count;
    }

    // Решение задачи 2.4
    static bool IsLeapYear(int year)
    {
        if (year % 400 == 0)
            return true;
        if (year % 100 == 0)
            return false;
        if (year % 4 == 0)
            return true;
        return false;
    }
}