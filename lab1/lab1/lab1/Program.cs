using System;
using ClassLibrary2;

namespace lab1
{
    class Program
    {
        static void Main()
        {
            string answer;
            do
            {
                Console.WriteLine("Uravninie tipa y=kx+b");
                Console.WriteLine("Vvedite kooficenti k,b po ocheridi");
                var first = new Line(ConsoleData.GetData(), ConsoleData.GetData());
                Console.WriteLine("Vvedite kooficenti k,b po ocheridi");
                var second = new Line(ConsoleData.GetData(), ConsoleData.GetData());
                var c = Operations.Cross(first, second);
                point.print(c);
                Console.WriteLine("Zadat` parametri zanavo? (Y/N)");
                answer = Console.ReadLine();
            }
            while ((answer == "y") || (answer == "Y"));
        }
    }
}