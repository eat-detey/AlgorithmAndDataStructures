using System.ComponentModel.Design;
using System.Security.Cryptography.X509Certificates;
using static System.Runtime.InteropServices.JavaScript.JSType;

internal class Program
{
    //private static object array;

    static void Main(string[] args)
    {
        //1.1 задание

        //Console.WriteLine("первое число:");
        //int num1 = Convert.ToInt32(Console.ReadLine()); //преобразует к типу инт
        //Console.WriteLine("второе число:");
        //int num2 = Convert.ToInt32(Console.ReadLine());
        //int sum = num1 + num2;
        //int dif = num1 - num2;
        //int del = num1 * num2;
        //Console.WriteLine($"Сумма:  {sum}");
        //Console.WriteLine($"Разность: {dif}");
        //Console.WriteLine($"Произведение: {del}");

        //1.2 задание 

        //Console.WriteLine("Температура в °C:");
        //int t = Convert.ToInt32(Console.ReadLine());
        //int f = t * 9 / 5 + 32;
        //Console.WriteLine($"Температура в °F: {f}");

        //1.3 задание

        //Console.WriteLine("Длина: ");
        //int a = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine("Ширина: ");
        //int b = Convert.ToInt32(Console.ReadLine());
        //int P = 2 *(a + b);
        //int S = a * b;
        //Console.WriteLine($"Периметр: {P}");
        //Console.WriteLine($"Площадь: {S}");

        //2.1 задание

        //Console.WriteLine("Введите число: ");
        //int number = Convert.ToInt32(Console.ReadLine());
        //if (number % 2 == 0) Console.WriteLine("Число чётное");
        //else Console.WriteLine("Число нечётное");

        //2.2 задание

        //Console.WriteLine("первое число: ");
        //int num1 = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine("второе число: ");
        //int num2 = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine("третье число: ");
        //int num3 = Convert.ToInt32(Console.ReadLine());
        //int maxNum = num1;
        //if (num2 > maxNum) maxNum = num2;
        //if (num3 > maxNum) maxNum = num3;
        //if (num1 > maxNum) maxNum = num1;
        //Console.WriteLine($"Максимальное число: {maxNum}");

        //2.3 задание КАЛЬКУЛЯТОР
        //Console.WriteLine("Первое число: ");
        //double num1 = Convert.ToDouble(Console.ReadLine());
        //Console.WriteLine("Второе число: ");
        //double num2 = Convert.ToDouble(Console.ReadLine());
        //Console.WriteLine("Выберите операцию: ");
        //string operation = Console.ReadLine();
        //double result = 0;
        //bool Voperation = true;
        //switch(operation){
        //    case "+":
        //        result = num1 + num2;
        //        break;
        //    case "-": 
        //        result = num1 - num2;
        //        break;
        //    case "*":
        //        result = num1 * num2;
        //        break;
        //    case "/":
        //        if (num2 == 0)
        //        {
        //            Console.WriteLine("Ошибка");
        //            Voperation = false;
        //        }
        //        else
        //        {
        //            result = num1 / num2;
        //        }
        //            break;
        //}
        //if (Voperation) Console.WriteLine($"Ответ: {result}");

        //3.1 задание
        //Console.WriteLine("Введите число: ");
        //int N = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine($"\nЧисла кратные 3 от 1 до {N}");
        //for (int i = 1; i <= N; i++)
        //{
        //    if (i % 3 == 0)
        //    {
        //        Console.WriteLine(i + " ");
        //    }
        //}

        //3.2 задание
        //Console.WriteLine("Введите число: ");
        //int N = Convert.ToInt32(Console.ReadLine());
        //long factorial = 1;
        //for (int i = 1; i <= N; i++)
        //{
        //    factorial *= i;
        //}
        //Console.WriteLine(factorial);

        //3.3 задание
        //string password;
        //while (true)
        //{
        //    Console.WriteLine("Введите пароль: ");
        //    password = Console.ReadLine();
        //    if (password == "12345")
        //    {
        //        Console.WriteLine("Верно!");
        //        break;
        //    }
        //    else Console.WriteLine("Не верно!");
        //}

        //1.1 и 1.2 задания

        int[] test1_1 = { 1, 2, 3, 4, 5 };
        int[] test1_2 = { -1, 0, 1 };
        int[] test1_3 = { };
        int[] test1_4 = null;

        Console.WriteLine($"Массив[1, 2, 3, 4, 5]: {GetSum(test1_1)}");
        Console.WriteLine($"Массив[-1, 0, 1]: {GetSum(test1_2)}");
        Console.WriteLine($"Массив[]: {GetSum(test1_3)}");
        Console.WriteLine($"Массив null: {GetSum(test1_4)}");

        static int GetSum(int[] array)
        {
            
            if (array == null || array.Length == 0)
            {
                return 0;
            }

            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum = sum + array[i];
            }
            return sum;
        }
        int[] test2_1 = { 3, 7, 2, 9, 1 };
        int[] test2_2 = { -5, -2, -10, -1 };
        int[] test2_3 = { 42 };
        int[] test2_4 = null;

        Console.WriteLine($"Массив[3, 7, 2, 9, 1]: {FindMax(test2_1)}");
        Console.WriteLine($"Массив[-5, -2, -10, -1]: {FindMax(test2_2)}");
        Console.WriteLine($"Массив[42]: {FindMax(test2_3)}");

        int result4 = FindMax(test2_4);
        if (test2_4 == null)
        {
            Console.WriteLine($"Массив null:{result4}");
        }
        else
        {
            Console.WriteLine($"Массив null: {result4}");
        }
        static int FindMax(int[] array)
        {
            if (array == null || array.Length == 0)
            {
                return int.MinValue;
            }
            int max = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > max)  
                {
                    max = array[i];  
                }
            }
            return max;
        }
    }
}


