using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Igor.Base;      // простарство имен BaseMethods.

namespace HomeWork2
{
    internal class Program
    {
        #region задача 1
        static void Task1() //Задача 1 
        {
            Console.Clear();
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("Выполнение задачи 1");
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine();

           
            Console.Write("введите число 1: ");
            double num1=double.Parse(Console.ReadLine());
            Console.Write("введите число 2: ");
            double num2 = double.Parse(Console.ReadLine());
            Console.Write("введите число 3: ");
            double num3 = double.Parse(Console.ReadLine());
            double minnumber1 = num1 < num2 ? num1 : num2;
            double minnumber2 = minnumber1 < num3 ? minnumber1 : num3;
            Console.WriteLine($"Минимальное число из трех: {minnumber2}");
            BaseMethods.Pause();

        }
        #endregion


        #region задача 2
        static void Task2() //задача 2
        {
            Console.Clear();
            Console.WriteLine("+++++++++++++++++++");
            Console.WriteLine("Выполнение задачи 2");
            Console.WriteLine("+++++++++++++++++++");
            Console.WriteLine();
            Console.Write("Введите число: ");

            int n = int.Parse(Console.ReadLine());
            int count;
            for (count=0; n!=0; count++)
            {
                n = n / 10;
            }
            Console.WriteLine();
            Console.WriteLine($"Количесво цифр в числе: {count}");
            BaseMethods.Pause();


        }
        #endregion


        #region Задача 3
        static void Task3() //задача 3
        {
            Console.Clear();
            Console.WriteLine("+++++++++++++++++++");
            Console.WriteLine("Выполнение задачи 3");
            Console.WriteLine("+++++++++++++++++++");
            Console.WriteLine();

            
            double number=2;
            double sum=0;
            
            while (number!=0) 
            {
                Console.Write("введите число: ");
                number = double.Parse(Console.ReadLine());
                double ostatok= number%2;

                if (ostatok != 0 && number > 0)
                {
                    sum = sum + number;
                }
            }
            Console.WriteLine($"Сумма всех введенных нечетных чисел = {sum}");
            BaseMethods.Pause();

        }
        #endregion


        #region Задача 4
        static bool Task4(bool finaltest) // задача 4 
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
            finaltest=false;
     
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
                    BaseMethods.Pause();
                }
                else
                {
                    if (counter - 1 != 1 && counter - 1 !=0)
                    {
                        Console.WriteLine("вы ввели не правильный логин или пароль");
                        counter--;
                        Console.Write($"вы можете попробывать еще {counter} раза");
                        BaseMethods.Pause();
                    }
                    else if(counter - 1 == 1)
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
        #endregion


        #region Задача 5 - а
        static void Task51() //Задача 5-а
        {
            Console.Clear();
            Console.WriteLine("+++++++++++++++++++++");
            Console.WriteLine("Выполнение задачи 5-а");
            Console.WriteLine("+++++++++++++++++++++");
            Console.WriteLine();

            Console.WriteLine("Введите ваш рост в метрах, (например 1,72)");
            string heigth = Console.ReadLine();
            Console.WriteLine("Введите ваш вес");
            string weight = Console.ReadLine();
            double heigthDB;
            heigthDB = double.Parse(heigth);
            double weightDB;
            weightDB = double.Parse(weight);
            double indexM = weightDB / (heigthDB * heigthDB);
            Console.WriteLine($"Ваш индекс массы тела: {indexM:F2}");
            if (indexM >= 18.5 && indexM <= 25)
            {
                Console.WriteLine("ваш индекс масссы тела в пределах нормы");
            }
            else if (indexM < 18.5)
            {
                Console.WriteLine("ваш индекс масссы тела ниже нормы \n Вам необходимо набрать вес");
            }
            else
            {
                Console.WriteLine("ваш индекс масссы тела выше нормы \n Вам необходимо сбросить вес");
            }
            BaseMethods.Pause();
        }
        #endregion

        #region Задача 5 - б
        static void Task52()
        {
            Console.Clear();
            Console.WriteLine("++++++++++++++++++++");
            Console.WriteLine("Выполнение задачи 5-б");
            Console.WriteLine("++++++++++++++++++++");
            Console.WriteLine();

            Console.WriteLine("Введите ваш рост в метрах, (например 1,72)");
            string heigth = Console.ReadLine();
            Console.WriteLine("Введите ваш вес");
            string weight = Console.ReadLine();
            double heigthDB;
            heigthDB = double.Parse(heigth);
            double weightDB;
            weightDB = double.Parse(weight);
            double indexM = weightDB / (heigthDB * heigthDB);
            double changeweigth;
            Console.WriteLine($"Ваш индекс массы тела: {indexM:F2}");
            if (indexM >= 18.5 && indexM <= 25)
            {
                Console.WriteLine("ваш индекс масссы тела в пределах нормы");
            }
            else if (indexM < 18.5)
            {
                changeweigth = (18.5-indexM) * (heigthDB * heigthDB);
                Console.WriteLine($"ваш индекс масссы тела ниже нормы \n Вам необходимо набрать {changeweigth:F2}кг.");
            }
            else
            {
                changeweigth = (indexM-25) * (heigthDB * heigthDB);
                Console.WriteLine($"ваш индекс масссы тела выше нормы \n Вам необходимо сбросить {changeweigth:F2}кг.");
            }
            BaseMethods.Pause();
        }
        #endregion


        #region Задача 6
        static int Sumnumber(int number) //Подпрограмма для задачи 6 нахождение суммы цифр числа
        {
            int sum = 0;
            while (number>0)
            {
                sum= sum + number % 10;
                number = number / 10;
            }
            return sum;
        }
        static void Task6()
        {
            Console.Clear();
            Console.WriteLine("+++++++++++++++++++");
            Console.WriteLine("Выполнение задачи 6");
            Console.WriteLine("+++++++++++++++++++");
            Console.WriteLine();
            int number = 0;
            bool good=false;
            int sum = 0;
            int quantity=0;
            DateTime start=DateTime.Now;                     //запуск отсчета времени
            do                                               //цикл подсчета хороших чисел с постусловием
            {
                number++;
                sum=Sumnumber(number);
                int goodnumber = number % sum;
                good = goodnumber == 0;
                if (good)
                {
                    quantity++;
                    Console.WriteLine("  "+quantity);        //Добавил, чтобы видеть ход выполнения задачи
                }
            }
            while (number <= 1000000000);
            Console.Clear();
            Console.WriteLine($"Количество хороших чисел в заданом периоде = {quantity}");
            Console.WriteLine($"затраченое время: {DateTime.Now-start}");         //подсчет затраченого времени
            BaseMethods.Pause();
        }

        #endregion


        #region задача 7-а
        static void Task71()
        {
            Console.Clear();
            Console.WriteLine("++++++++++++++++++++");
            Console.WriteLine("Выполнение задачи 7-а");
            Console.WriteLine("++++++++++++++++++++");
            Console.WriteLine();

        }

        #endregion


        #region задача 7-б
        static void Task72()
        {
            Console.Clear();
            Console.WriteLine("++++++++++++++++++++");
            Console.WriteLine("Выполнение задачи 7-б");
            Console.WriteLine("++++++++++++++++++++");
            Console.WriteLine();

        }

        #endregion


        static void Main(string[] args)
        {
            bool f = true;
            

            while (f)
            {
                Console.Clear();
                int numberHW = 2;
                BaseMethods.PrintInfo(numberHW);
                Console.WriteLine("");
                Console.WriteLine("Моя домашняя работа");
                Console.WriteLine("==========================");
                Console.WriteLine("Введите 1 для выбора задачи 1");
                Console.WriteLine("Введите 2 для выбора задачи 2");
                Console.WriteLine("Введите 3 для выбора задачи 3");
                Console.WriteLine("Введите 4 для выбора задачи 4");
                Console.WriteLine("Введите 51 для выбора задачи 5-а");
                Console.WriteLine("Введите 52 для выбора задачи 5-б");
                Console.WriteLine("Введите 6 для выбора задачи 6");
                Console.WriteLine("Введите 71 для выбора задачи 7-а");
                Console.WriteLine("Введите 72 для выбора задачи 7-б");
                Console.WriteLine("Введите 0 для выхода из приложения");
                Console.WriteLine("");

                int number = int.Parse(Console.ReadLine());
                bool x = false; //нужно для четвертой задачи возвращающей болево значение, без указания этой переменной вылазит ошибка, т.к. переменная не используется
                switch (number)
                {
                    case 0:
                        Console.WriteLine("завершение работы...");
                        f = false;
                        break;
                    case 1:
                        Task1();
                        break;
                    case 2:
                        Task2();
                        break;
                    case 3:
                        Task3();
                        break;
                    case 4:
                        Task4(x);
                        break;
                    case 51:
                        Task51();
                        break;
                    case 52:
                        Task52();
                        break;
                    case 6:
                        Task6();
                        break;
                    case 71:
                        Task71();
                        break;
                    case 72:
                        Task72();
                        break;

                    default:
                        Console.WriteLine("Неверный номер задачи. \nПовторите ввод");
                        BaseMethods.Pause();
                        break;
                }

            }

        }
    }
}
