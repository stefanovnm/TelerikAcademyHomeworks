//Create a class Path to hold a sequence of points in the 3D space.

namespace _01_04.Points
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Path
    {
        private List<Point3D> path3D;

        public Path()
        {
            this.Path3D = new List<Point3D>();
        }

        public Path(params Point3D[] points)
            :this()
        {
            foreach (var point in points)
            {
                this.path3D.Add(point);
            }
        }

        public List<Point3D> Path3D 
        {
            get { return new List<Point3D>(this.path3D); } //return copy of the List(not the reference to the actual list)
            private set { this.path3D = value; }
        }

        public void AddPoint(Point3D point)
        {
            this.path3D.Add(point);
        }

        public void Clear()
        {
            this.path3D.Clear();
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            foreach (var point in path3D)
            {
                result.AppendLine(point.ToString());
            }

            return result.ToString();
        }
    }
}
