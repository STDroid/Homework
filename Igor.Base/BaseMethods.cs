using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Igor.Base
{
    public class BaseMethods
    {
        public static int Sumnumber(int number)
        {
            int sum = 0;
            while (number > 0)
            {
                sum = sum + number % 10;
                number = number / 10;
            }
            return sum;
        }

        public static void PrintInfo(int numberHW)
        {
            Console.WriteLine($"Домашняя работа номер: {numberHW}");
            Console.WriteLine($"Студент: Шилов Игорь");
            Console.WriteLine($"=============================================");

        }
        public static void Pause()   //Домашнее задание по созданию методов (6 задача)
        {
            Console.ReadKey();
        }
        public static void Print(string ms, int x, int y) //Домашнее задание по созданию методов (6 задача)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(ms);
        }
        public static double length(double x1, double x2, double y1, double y2)
        {
            double result = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine($"Расстояние между точками: {result:F2}");
            return result;

        }
        static bool password(bool finaltest)
        {
            Console.Clear();
            Console.WriteLine("+++++++++++++++++++");
            Console.WriteLine("Выполнение задачи 4");
            Console.WriteLine("+++++++++++++++++++");
            Console.WriteLine();

            string login = "root";
            string password = "GeekBrains";
            int counter = 3;
            string logincheck;
            string passwordcheck;
            finaltest = false;

            do
            {
                Console.Clear();
                Console.Write("введите логин: ");
                logincheck = Console.ReadLine();
                Console.Write("введите пароль: ");
                passwordcheck = Console.ReadLine();
                bool resultlogin = login.Equals(logincheck);
                bool resultpassword = password.Equals(passwordcheck);

                if (resultlogin && resultpassword)
                {
                    Console.Write("вы ввели правильный логин и пароль");
                    finaltest = true;
                }
                else
                {
                    if (counter - 1 != 1 && counter - 1 != 0)
                    {
                        Console.WriteLine("вы ввели не правильный логин или пароль");
                        counter--;
                        Console.Write($"вы можете попробывать еще {counter} раза");
                        BaseMethods.Pause();
                    }
                    else if (counter - 1 == 1)
                    {
                        Console.WriteLine("вы ввели не правильный логин или пароль");
                        counter--;
                        Console.Write($"вы можете попробывать еще {counter} раз");
                        BaseMethods.Pause();
                    }

                    else
                    {
                        Console.WriteLine("вы ввели не правильный логин или пароль");
                        counter--;
                        Console.Write("вызод из программы");
                        BaseMethods.Pause();
                    }

                }

            }
            while (counter > 0 && finaltest != true);
            Console.Clear();
            Console.Write($"результат проверки логина и пароля = {finaltest}");
            BaseMethods.Pause();
            return finaltest;
        }
    }
}
