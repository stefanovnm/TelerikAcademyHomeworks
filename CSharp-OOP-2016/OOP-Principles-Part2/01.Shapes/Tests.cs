namespace _01.Shapes
{
    using System;

    public class Tests
    {
        public static void Main()
        {
            Shape[] shapes =
            {
                new Rectangle(5.5,10),
                new Square(3.3),
                new Triangle(5.5, 10),
                new Rectangle(2,1),
                new Square(1),
                new Triangle(2, 2)
            };

            foreach (var shape in shapes)
            {
                Console.WriteLine("{0}: Surface is {1:0.00} m²", shape.GetType().Name, shape.CalculateSurface());
            }
        }
    }
}
