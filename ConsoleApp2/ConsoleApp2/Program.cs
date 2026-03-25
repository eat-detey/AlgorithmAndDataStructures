using System;
using System.Numerics;
using static System.Runtime.InteropServices.JavaScript.JSType;
class Program
{
    static bool IsPrime(int number)
    {
        if (number < 2)
            return false;

        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
                return false;
        }
        return true;
    }
    static void Main()
    {
        int test1 = 7;
        int test2 = 1;
        int test3 = 23;
        int test4 = 4;
        int test5 = -3;

        Console.WriteLine(IsPrime(test1));
        Console.WriteLine(IsPrime(test2));
        Console.WriteLine(IsPrime(test3));
        Console.WriteLine(IsPrime(test4));
        Console.WriteLine(IsPrime(test5));
    }
}


