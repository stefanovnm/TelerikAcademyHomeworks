// Create a structure Point3D to hold a 3D-coordinate {X, Y, Z} in the Euclidian 3D space.
//Implement the ToString() to enable printing a 3D point.

//Add a private static read-only field to hold the start of the coordinate system – the point O{0, 0, 0}.
//Add a static property to return the point O.

namespace _01_04.Points
{
    public struct Point3D
    {
        private static readonly Point3D o = new Point3D(0, 0, 0);

        private decimal x;
        private decimal y;
        private decimal z;

        public Point3D (decimal x, decimal y, decimal z)
            :this()
	    {
            this.X = x;
            this.Y = y;
            this.Z = z;
	    }

        public decimal X 
        {
            get { return this.x; }
            set { this.x = value; }
        }
        public decimal Y
        {
            get { return this.y; }
            set { this.y = value; }
        }
        public decimal Z
        {
            get { return this.z; }
            set { this.z = value; }
        }

        public static Point3D O
        {
            get { return o; }
        }

        public override string ToString()
        {
            return string.Format("p({0}, {1}, {2})", x, y, z);
        }
    }
}
