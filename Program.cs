using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using FiguresAreas;

namespace MindBox
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> figures = new List<string> { "Треугольник", "Круг" }; //тут можно добавить фигуру, обновив предварительно dll
            double result;
            try
            {
                Console.WriteLine("Выберете вашу фигуру: ");
                int i = 1;
                foreach (var f in figures)
                {
                    Console.WriteLine($"{i}. {f}");
                    i++;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Вы ввели строку или ошиблись в вводе");
            }

            try
            {
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine($"Ваша фигура {figures.ElementAt(0)}");
                        Console.WriteLine("Введите 1 сторону треугольника в см:");
                        double a = double.Parse(Console.ReadLine());
                        Console.WriteLine("Введите 2 сторону треугольника в см:");
                        double b = double.Parse(Console.ReadLine());
                        Console.WriteLine("Введите 3 сторону треугольника в см:");
                        double c = double.Parse(Console.ReadLine());
                        if (a == b && a == c && a != 0)
                        {
                            result = Areas.CalcArea(a, b, c); //вызываем метод самописной библиотеки для треугольника, сработает проверка на равносторонность
                            Console.WriteLine($"Ваш треугольник равносторонний, его площадь равна {result} см^2");
                        }
                        else
                        {
                            result = Areas.CalcArea(a, b, c); //вызываем метод самописной библиотеки для обычного треугольника
                            if (result > 0)
                                Console.WriteLine($"Площадь вашего треугольника равна {result} см^2");
                            else
                                Console.WriteLine("Такого треугольника не существует или длина одной из сторон отрицательна!");
                        }
                        break;
                    case 2:
                        Console.WriteLine($"Ваша фигура {figures.ElementAt(1)}");
                        Console.WriteLine("Введите радиус вашего круга в см:");
                        double r = double.Parse(Console.ReadLine());
                        result = Areas.CalcArea(r);
                        if (result > 0)
                            Console.WriteLine($"Площадь вашего круга равна {result} см^2");
                        else
                            Console.WriteLine("Радиус должен быть больше нуля!");
                        break;
                    default:
                        Console.WriteLine("Вашего пункта нет в списке");
                        break;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Вы ввели не число или ошиблись в вводе");
            }
        }
    }
}
