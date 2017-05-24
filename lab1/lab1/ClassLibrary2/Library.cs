using System;

namespace ClassLibrary2
{
    public class Line
    {
        public double k, b;
        public Line(double k, double b)
        {
            this.k = k;
            this.b = b;
        }
    }

    public class point
    {
        double x, y;
        public point()
        { }
        public point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        public static void print(point c)
        {
            if (c != null)
                Console.WriteLine("Coordinati tochek peresechenya {0}  {1}", c.x, c.y);
            else
            {

            }
            Console.WriteLine("tochek peresechenya  net!");
        }
    }

    public class Operations
    {
        //Метод на на проверку точки пересечения прмямых
        public static point Cross(Line first, Line second)
        {
            double y, x;
            if ((first.b == second.b) && (second.k == first.k))
            {
                Console.WriteLine("Pryamie nalozheni drug na druga");
                var a = new point(first.k, second.k);
                return a;
            }

            if (first.k != second.k)
            {

                x = (double)(second.b - first.b) / (first.k - second.k);
                y = first.k * x + first.b;
                var a = new point(x, y);
                return a;
            }
            else
            {
                Console.WriteLine("Pryamie parallel`ni ,tochek peresechenya  net!");
                return null;
            }

        }
    }

    public class ConsoleData
    {
        //Ввод одного действительного числа
        public static double GetData()
        {
            double a = 0;
            try
            {
                a = double.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Error! Tol`ko celie chisla");
                Console.WriteLine("Vvedite zanovo !");
                a = double.Parse(Console.ReadLine());
            }
            return a;
        }
    }
}
