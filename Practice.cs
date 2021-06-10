using System;

namespace ConsoleApp2
{
    class Practice
    {
        static void Mymeathod(int a)
        {
            int g = a * 10000;
            Console.WriteLine("Function ok" + g);
        }
        static void Main(string[] args)
        {
            int s, l, b;
            Console.WriteLine("Enter ur preference");
            int per = Convert.ToInt32(Console.ReadLine());
            switch (per)
            {
                case 1:
                    Console.WriteLine("Enter side of square");
                    s = Convert.ToInt32(Console.ReadLine());
                    int area = s * s;
                    Console.WriteLine("UR sq area is" + area);
                    if (area < 20)
                        Console.WriteLine("AREA is short");
                    else if (area > 20 && area < 30)
                        Console.WriteLine("areac ok");
                    else
                        Console.WriteLine("Not ok");

                    break;
                case 2:
                    Console.WriteLine("Enter l b of rect");
                    l  =Convert.ToInt32(Console.ReadLine());
                    b = Convert.ToInt32(Console.ReadLine());
                    area = l * b;
                    Console.WriteLine("UR sq area is" + area);
                    Mymeathod(area);
                    break;
            }
            }
    }
}
