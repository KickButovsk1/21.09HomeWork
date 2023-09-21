using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_2._3task_21._09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вторая задача");
            double s;
            string str = Console.ReadLine();
            bool ss = Double.TryParse(str, out s);
            Console.WriteLine($"Проверяем - {str}");
            if (ss == true)
            {
                double y1 = Convert.ToDouble(Console.ReadLine());
                double x1 = Convert.ToDouble(Console.ReadLine());
                double x2 = Convert.ToDouble(Console.ReadLine());
                double y2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"Введите y1 = {y1}");
                Console.WriteLine($"Введите x1 = {x1}");
                Console.WriteLine($"Введите x2 = {x2}");
                Console.WriteLine($"Введите y2 = {y2}");
                double k = (y1 - y2) / (x1 - x2);
                double b = y2 - k * x2;
                Console.WriteLine($"Уравнение прямой y = {k} * x + {b}");
            }
            else
            {
                Console.WriteLine("С помощью этого невозможно рассчитать уравнение для прямой");
            }
            Console.WriteLine("Третья задача");
            double okr;
            string okrstr = Console.ReadLine();
            bool okrprov = Double.TryParse(okrstr, out okr);
            Console.WriteLine($"Проверяем - {okr}");
            if (okrprov == true)
            {
                double a = Convert.ToDouble(Console.ReadLine());
                double b = Convert.ToDouble(Console.ReadLine());
                double R = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"First koordinata - {a}");
                Console.WriteLine($"Second koordinata - {b}");
                Console.WriteLine($"Radius - {R}");
                Console.WriteLine($"Уравнение окружности - (x - {a})^2 + (y - {b})^2 = {R}^2");
            }
            else
            {
                Console.WriteLine("Вы ввели не число");
            }

            Console.ReadKey();
        }
    }
}
