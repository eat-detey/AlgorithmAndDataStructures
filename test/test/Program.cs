using System;

namespace test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int min = 0;
            int max = 0;
            int count = 0;
            int countGame = 0;

            Random rnd = new Random(); //создаём объект класса random
            char answer = 'Y';

            do
            {
                int counter = 0;
                int number = rnd.Next(1, 101);

                while (true)
                {
                    counter++;

                    // метод для ввода числа
                    int userNumber = GetUserNumber();

                    // метод для проверки числа
                    if (CheckNumber(userNumber, number))
                    {
                        Console.WriteLine("You won");

                        // метод для обновления статистики
                        UpdateStats(ref min, ref max, ref count, ref countGame, counter);
                        break;
                    }
                }

                // метод для вопроса о повторении
                answer = AskToPlayAgain();

            } while (answer == 'Y' || answer == 'y');

            // метод для вывода статистики
            ShowStats(min, max, count, countGame);
        }

        /// <summary>
        /// Получение числа и проверка его на правильность
        /// </summary>
        static int GetUserNumber()
        {
            Console.WriteLine("Input number from [1;100]");

            for (int i = 0; i < 3; i++)
            {
                if (!int.TryParse(Console.ReadLine(), out int userNumber) || userNumber > 100 || userNumber < 1)
                {
                    Console.WriteLine("Input number from [1;100]");
                }
                else
                {
                    return userNumber;
                }
            }

            Console.WriteLine("You are stupid");
            Environment.Exit(0);
            return 0;
        }

        /// <summary>
        /// Сравниваем число с загаданным
        /// </summary>

        static bool CheckNumber(int userNumber, int targetNumber)
        {
            if (userNumber > targetNumber)
            {
                Console.WriteLine("Your number is greater");
                return false;
            }
            else if (userNumber < targetNumber)
            {
                Console.WriteLine("Your number is less");
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// Обновление статистики игр (min, max и общее количество попыток)
        /// </summary>

        static void UpdateStats(ref int min, ref int max, ref int count, ref int countGame, int counter)
        {
            if (min == 0 || min > counter)
            {
                min = counter;
            }

            if (max < counter)
            {
                max = counter;
            }
            // можно было через тернарный оператор, но так понятнее
            // max = max < counter ? counter : max;

            countGame++;
            count += counter;
        }

        /// <summary>
        /// Вопрос хочет ли игрок сыграть ещё раз
        /// </summary>

        static char AskToPlayAgain()
        {
            Console.WriteLine("Do you want to play again? (Y/N)");
            string input = Console.ReadLine();

            if (!string.IsNullOrEmpty(input))
            {
                return input[0];
            }

            return 'N';
        }

        /// <summary>
        /// Итоговая статистика игр
        /// </summary>

        static void ShowStats(int min, int max, int count, int countGame)
        {
            if (countGame > 0)
            {
                double avg = (double)count / countGame;
                Console.WriteLine($"min = {min} max = {max} avg = {avg:F2}");
            }
            else
            {
                Console.WriteLine("No games played");
            }
        }
    }
}
