namespace _01.Shapes
{
    public class Square : Rectangle
    {
        public Square(double height) 
            : base(height, height)
        {
        }

        public override double CalculateSurface()
        {
            return Height * Height;
        }
    }
}
