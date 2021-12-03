using System;

namespace ConsoleApp3_4
{
    public class Program
    {
        static void Main(string[] args)
        {
            Run();
        }

        public static void Run()
        {
            Console.Write("Введите радиус ");
            string srad = Console.ReadLine();

            Console.Write("Введите значение x ");
            string sx = Console.ReadLine();

            Console.Write("Введите значение y ");
            string sy = Console.ReadLine();

            Console.Write("Введите значение x0 ");
            string sx0 = Console.ReadLine();

            Console.Write("Введите значение y0 ");
            string sy0 = Console.ReadLine();

            double rad = 0, x = 0, y = 0, x0 = 0, y0 = 0;

            try
            {
                x = Convert.ToInt32(sx);
                y = Convert.ToInt32(sy);
                x0 = Convert.ToInt32(sx0);
                y0 = Convert.ToInt32(sy0);
                rad = Convert.ToInt32(srad);
            }
            catch
            {
                Console.WriteLine("Некорректные данные");
                Console.ReadLine();
                Run();
                Environment.Exit(0);
            }

            Circle.Lenght(rad);
            Circle.Square(rad);
            Circle.Point(x, y, x0, y0, rad);

            Console.ReadLine();
            Run();
            Environment.Exit(0);
        }

        static class Circle
        {
            public static void Lenght(double rad)
            {
                Console.WriteLine("Длина окружности с радиусом {0} = {1}", rad, 2*Math.PI*rad);
            }
            public static void Square(double rad)
            {
                Console.WriteLine("Площадь окружности с радиусом {0} = {1}", rad, Math.PI * (Math.Pow(rad,2)));
            }
            public static void Point(double x, double y, double x0, double y0, double rad)
            {
                if (rad > Math.Sqrt(Math.Pow(x - x0, 2) + Math.Pow(y - y0, 2)))
                {
                    Console.WriteLine("Точка {0} входит в окружность", x + ";" + y);
                }
                else
                {
                    Console.WriteLine("Точка {0} не входит в окружность", x + ";" + y);
                }
            }
        }
    }
}