using System;
using System.Linq;

namespace TriangleArea
{
    class TriangleArea
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var dot = input.Split(' ').Select(x => double.Parse(x)).ToArray();
            double i = dot[1] * dot[5] - dot[2] * dot[4];
            double j = dot[0] * dot[5] - dot[2] * dot[3];
            double k = dot[0] * dot[4] - dot[1] * dot[3];
            double vec = Math.Sqrt(i * i + j * j + k * k);
            double area = vec / 2;
            Console.Write(area);
        }
    }
}
