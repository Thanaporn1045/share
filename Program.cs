using System;

namespace หุ้น
{
    class Program
    {
        static void Main(string[] args)
        {
            string mode;
            double x, y, time, price;
            mode = Console.ReadLine();
            x = double.Parse(Console.ReadLine());
            y = double.Parse(Console.ReadLine());
            if (mode == "time" || mode == "price")
            {
                if (x >= 0)
                {
                    if (mode == "time")
                    {
                        price = Math.Pow(x - 1, 2);
                        Console.WriteLine("{0} , {1}", x, price);
                    }
                    else if (mode == "price")
                    {
                        if (x >= 1)
                        {
                            time = Math.Sqrt(y) + 1;
                            Console.WriteLine("{0} , {1}", time, y);
                        }
                        else
                        {
                            time = -Math.Sqrt(y) + 1;
                            Console.WriteLine("{0} , {1}", time, y);
                        }
                    }
                }
                else Console.WriteLine("Invalid mouse position");
            }
            else Console.WriteLine("Invalid mode");
            Console.ReadLine();
        }
    }
}
