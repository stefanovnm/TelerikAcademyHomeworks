// Write a static class with a static method to calculate the distance between two points in the 3D space.

namespace _01_04.Points
{
    using System;

    public static class Distance
    {
        public static decimal Between(Point3D first, Point3D second)
        {
            decimal distance = 0;

            decimal deltaX = second.X - first.X;
            decimal deltaY = second.Y - first.Y;
            decimal deltaZ = second.Z - first.Z;

            distance = (decimal)Math.Sqrt((double)(deltaX * deltaX) + (double)(deltaY * deltaY) + (double)(deltaZ * deltaZ)); 
            // Math.Sqrt wants double, the points are decimal so we will lose some precision. You can read here how to be done in other way http://stackoverflow.com/questions/4124189/performing-math-operations-on-decimal-datatype-in-c

            return distance;
        }

    }
}
