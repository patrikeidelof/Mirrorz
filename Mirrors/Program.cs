using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mirrors
{
    class Program
    {
        static void Main(string[] args)
        {
            Grid grid = new Grid();
            Console.WriteLine("Starting 3 X 3 grid.");

            Console.WriteLine("Using 1,1,1");
            Console.WriteLine(grid.Start(1,1,1));


            Console.WriteLine("Using 1,2,1");
            Console.WriteLine(grid.Start(1, 2, 1));
            Console.WriteLine("Using 1,3,1");
            Console.WriteLine(grid.Start(1, 3, 1));
            Console.WriteLine("Using 1,3,2");
            Console.WriteLine(grid.Start(1, 3, 2));

            Console.WriteLine("Using 2,1,4");
            Console.WriteLine(grid.Start(2, 1, 4));
            Console.WriteLine("Using 2,3,2");
            Console.WriteLine(grid.Start(2, 3, 2));
            Console.ReadLine();
        }


        // static Grid ThreeByThree()
    }
}
