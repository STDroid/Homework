using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1
{
    internal class Program
    {
        static void Pause()   //Домашнее задание по созданию методов (6 задача)
        {
            Console.ReadLine();
        }
        static void Print(string ms,int x, int y) //Домашнее задание по созданию методов (6 задача)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(ms);
        }
        static double length(double x1, double x2, double y1, double y2)
        {
            double result = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine($"Расстояние между точками: {result:F2}");
            return result;

        }


        static void Main(string[] args)
        {
            task1();
            task2();
            task3a();
            task3b();
            task4a();
            task4b();
            task5a();
            task5b();
            task5c();

        }
        static void task1()
           {
            Console.WriteLine("Введите ваше имя");
            string FirstName = Console.ReadLine();
            Console.WriteLine("Введите вашe фамилию");
            string surname = Console.ReadLine();
            Console.WriteLine("Введите ваш возраст");
            string age = Console.ReadLine();
            Console.WriteLine("Введите ваш рост");
            string heigth = Console.ReadLine();
            Console.WriteLine("Введите ваш вес");
            string weight = Console.ReadLine();
            Console.WriteLine(FirstName + " " + surname + " " + age + " " + heigth + " " + weight); //вывод данных методом склеивания задача 1а
            Console.WriteLine("{0} {1} {2} {3} {4}", FirstName, surname, age, heigth, weight); //вывод данных методом форматирования задача 1б
            Console.WriteLine($"{FirstName} {surname} {age} {heigth} {weight}"); //вывод данных методом форматирования задача 1в
            Pause();
        }
        static void task2() //Задача на расчет индекса массы тела
        {
            Console.WriteLine("Введите ваш рост в метрах");
            string heigth = Console.ReadLine();
            Console.WriteLine("Введите ваш вес");
            string weight = Console.ReadLine();
            double heigthDB;
            heigthDB=double.Parse(heigth);
            double weightDB;
            weightDB = double.Parse(weight);
            double indexM = weightDB / (heigthDB * heigthDB);
            Console.WriteLine($"Ваш индекс массы тела: {indexM:F2}");
            Pause();
        }
        static void task3a()
        {
            double x1;
            double y1;
            double x2;
            double y2;
            double result;
            Console.Write("введите x1: ");
            x1 = double.Parse(Console.ReadLine());
            Console.Write("введите y1: ");
            y1 = double.Parse(Console.ReadLine());
            Console.Write("введите x2: ");
            x2 = double.Parse(Console.ReadLine());
            Console.Write("введите y2: ");
            y2 = double.Parse(Console.ReadLine());
            result = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine($"Расстояние между точками: {result:F2}");
            Pause();

        }
        static void task3b()
        {
            double x1;
            double y1;
            double x2;
            double y2;
            Console.Write("введите x1: ");
            x1 = double.Parse(Console.ReadLine());
            Console.Write("введите y1: ");
            y1 = double.Parse(Console.ReadLine());
            Console.Write("введите x2: ");
            x2 = double.Parse(Console.ReadLine());
            Console.Write("введите y2: ");
            y2 = double.Parse(Console.ReadLine());
            length(x1,x2,y1,y2);
            Pause();

        }

        static void task4a()
        {
            double firsnumber = 15;
            double secondnumber = 25;
            double rezerv = firsnumber;
            firsnumber = secondnumber;
            secondnumber = rezerv;
        }
        static void task4b()
        {
            double firsnumber = 15;
            double secondnumber = 25;
            firsnumber=firsnumber+secondnumber;
            secondnumber=firsnumber-secondnumber;
            firsnumber=firsnumber-secondnumber;
        }
        static void task5a()
        {
            Console.WriteLine("Шилов Игорь Пермь");
            Pause();
        }
        static void task5b()
        {
            Console.SetCursorPosition(Console.WindowWidth / 2, Console.WindowHeight / 2);
            Console.WriteLine("Шилов Игорь Пермь");
            Pause();
        }
        static void task5c()
        {
            
            int x = 10;
            int y = 12;
            string ms = "Шилов Игорь Пермь";
            Print(ms,x,y);
            Pause();
        }
        }
}
