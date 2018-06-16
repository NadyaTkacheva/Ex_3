using System;
using System.IO;

namespace Task3
{
    class Program
    {
         static void Func(double x, double y)
        {
           if ((x*x+y*y<=1)&&(x<=1)&&(y<=1)&&(y>=-1)&&(x>=-2)&&(y>=(-1/2*x-1))&&(y<=(1/2*x+1)))
            {
                Console.WriteLine("x={0}, y={1} : точка попадает",x,y);
            }
           else
                Console.WriteLine("x={0}, y={1} : точка не попадает",x,y);

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 3");
            Random rnd = new Random();           
           for (int i=0;i<20;i++)
            {
                Func(Convert.ToDouble(rnd.Next(-20, 10) / 10.0), Convert.ToDouble(rnd.Next(-10, 10) / 10.0));
                Console.WriteLine();
            }
            
             Console.ReadKey();
        }
    }
}
