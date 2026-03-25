////проверка, можно ли составить слово
using System;
class Program
{
    static bool CanConstruct(string ransomNote, string magazine)
    {
        char[] ransomArr = ransomNote.ToCharArray();
        char[] magazineArr = magazine.ToCharArray();
        Array.Sort(ransomArr);
        Array.Sort(magazineArr);
        int i = 0, j = 0;
        while (i < ransomArr.Length && j < magazineArr.Length)
        {
            if (ransomArr[i] == magazineArr[j])
            {
                i++;
                j++;
            }
            else if (ransomArr[i] > magazineArr[j])
            {
                j++;
            }
            else
            {
                return false;
            }
        }
        return i == ransomArr.Length;
    }
    //тест программы
    static void Main()
    {
        string note = "aab";
        string magazine = "baa";
        bool result = CanConstruct(note, magazine);
        Console.WriteLine($"Можно ли составить '{note}' из '{magazine}'? {result}");
        string note2 = "abc";
        string magazine2 = "ab";
        bool result2 = CanConstruct(note2, magazine2);
        Console.WriteLine($"Можно ли составить '{note2}' из '{magazine2}'? {result2}");
    }
}

////поиск "счастливого числа" в массиве
using System;
class Program
{
    static int FindLucky(int[] arr)
    {
        Array.Sort(arr);
        int maxLucky = -1;
        int i = 0;
        while (i < arr.Length)
        {
            int currentNum = arr[i];
            int count = 0;
            while (i < arr.Length && arr[i] == currentNum)
            {
                count++;
                i++;
            }
            if (currentNum == count)
            {
                maxLucky = currentNum;
            }
        }
        return maxLucky;
    }
    // тест программы
    static void Main()
    {
        int[] arr1 = { 2, 2, 3, 4 };
        int result1 = FindLucky(arr1);
        Console.WriteLine($"Счастливое число в [2,2,3,4]: {result1}");
        int[] arr2 = { 1, 2, 2, 3, 3, 3 };
        int result2 = FindLucky(arr2);
        Console.WriteLine($"Счастливое число в [1,2,2,3,3,3]: {result2}");
        int[] arr3 = { 5, 5, 5, 5, 5 };
        int result3 = FindLucky(arr3);
        Console.WriteLine($"Счастливое число в [5,5,5,5,5]: {result3}");
    }
}

////поиск максимального количества единиц
using System;
class Program
{
    static int LongestOnes(int[] nums, int k)
    {
        int left = 0;
        int zeroCount = 0;
        int maxLength = 0;
        for (int right = 0; right < nums.Length; right++)
        {
            if (nums[right] == 0)
            {
                zeroCount++;
            }
            while (zeroCount > k)
            {
                if (nums[left] == 0)
                {
                    zeroCount--;
                }
                left++;
            }
            int currentLength = right - left + 1;
            if (currentLength > maxLength)
            {
                maxLength = currentLength;
            }
        }

        return maxLength;
    }
    //тест программы
    static void Main()
    {
        int[] nums1 = { 1, 1, 0, 1, 1, 1 };
        int k1 = 1;
        int result1 = LongestOnes(nums1, k1);
        Console.WriteLine($"Максимум единиц: {result1}");
        int[] nums2 = { 1, 0, 0, 1, 1, 0, 1, 0, 1 };
        int k2 = 2;
        int result2 = LongestOnes(nums2, k2);
        Console.WriteLine($"Максимум единиц: {result2}");
        Console.Write("Массив: ");
        foreach (int num in nums2)
        {
            Console.Write(num + " ");
        }
    }
}