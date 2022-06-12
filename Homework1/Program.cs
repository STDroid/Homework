using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Igor.Base;      // простарство имен BaseMethods.

namespace HomeWork1
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            BaseMethods.PrintInfo(1);
            Task1();
            Task2();
            Task3a();
            Task3b();
            Task4a();
            Task4b();
            Task5a();
            Task5b();
            Task5c();

        }
        static void Task1()
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
            BaseMethods.Pause();
        }
        static void Task2() //Задача на расчет индекса массы тела
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
            BaseMethods.Pause();
        }
        static void Task3a()
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
            BaseMethods.Pause();

        }
        static void Task3b()
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
            BaseMethods.length(x1,x2,y1,y2);
            BaseMethods.Pause();

        }

        static void Task4a()
        {
            double firsNumber = 15;
            double secondNumber = 25;
            double rezerv = firsNumber;
            firsNumber = secondNumber;
            secondNumber = rezerv;
        }
        static void Task4b()
        {
            double firsNumber = 15;
            double secondNumber = 25;
            firsNumber=firsNumber+secondNumber;
            secondNumber=firsNumber-secondNumber;
            firsNumber=firsNumber-secondNumber;
        }
        static void Task5a()
        {
            Console.WriteLine("Шилов Игорь Пермь");
            BaseMethods.Pause();
        }
        static void Task5b()
        {
            Console.SetCursorPosition(Console.WindowWidth / 2, Console.WindowHeight / 2);
            Console.WriteLine("Шилов Игорь Пермь");
            BaseMethods.Pause();
        }
        static void Task5c()
        {
            
            int x = 10;
            int y = 12;
            string ms = "Шилов Игорь Пермь";
            BaseMethods.Print(ms,x,y);
            BaseMethods.Pause();
        }
        }
}
