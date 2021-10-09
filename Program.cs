using System;
using System.Collections.Generic;


namespace programmingtest
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<Shape>();
            list.Add(new Rectangle("B", 10.0, 20.0));
            list.Add(new Rectangle("A", 5.0, 40.0));
            list.Add(new Circle("C", 10.0));
            var circle = new Circle("D", 1.5);
            list.Add(circle);
            circle.Radius = 2.0;
            list.Sort();
            Console.WriteLine(string.Join("\n", list));
        }
    }
}
