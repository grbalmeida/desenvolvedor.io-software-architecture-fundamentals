using System;

namespace SOLID.LSP.Solution
{
    public class AreaCalculation
    {
        private static void GetParallelogramArea(Parallelogram parallelogram)
        {
            Console.Clear();
            Console.WriteLine("Calculating the Parallelogram Area");
            Console.WriteLine();
            Console.WriteLine(parallelogram.Height + " * " + parallelogram.Width);
            Console.WriteLine();
            Console.WriteLine(parallelogram.Area);
            Console.ReadKey();
        }

        public static void Calculate()
        {
            var square = new Square(5, 5);
            var rectangle = new Rectangle(10, 5);

            GetParallelogramArea(square);
            GetParallelogramArea(rectangle);
        }
    }
}
