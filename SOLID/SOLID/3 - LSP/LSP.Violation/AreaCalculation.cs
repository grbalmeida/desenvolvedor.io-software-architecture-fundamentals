using System;

namespace SOLID.LSP.Violation
{
    public class AreaCalculation
    {
        private static void GetRectangleArea(Rectangle rectangle)
        {
            Console.Clear();
            Console.WriteLine("Calculating the Rectangle Area");
            Console.WriteLine();
            Console.WriteLine(rectangle.Height + " * " + rectangle.Width);
            Console.WriteLine();
            Console.WriteLine(rectangle.Area);
            Console.ReadKey();
        }

        public static void Calculate()
        {
            var square = new Square()
            {
                Height = 10,
                Width = 5
            };

            GetRectangleArea(square);
        }
    }
}
