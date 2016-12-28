namespace _01.Shapes
{
    public class Triangle : Shape
    {
        public Triangle(double height, double width)
            :base(height, width)
        {
        }

        public override double CalculateSurface()
        {
            return Height * Width / 2;
        }
    }
}
