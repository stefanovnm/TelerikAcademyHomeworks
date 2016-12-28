namespace _01_04.Points
{
    using System;

    public class Tests
    {
        public static void Main()
        {
            var point = new Point3D();

            point.X = 0.5M;
            point.Y = -3;
            point.Z = 1.35M;

            Console.WriteLine(point);
            Console.WriteLine(Point3D.O);
            Console.WriteLine("Distance between " + point + " and O is "+Distance.Between(point, Point3D.O));

            var path = new Path();
            path.AddPoint(Point3D.O);
            path.AddPoint(point);

            Console.WriteLine(path);

            var secondPath = new Path(new Point3D(1, 2, 3), new Point3D(2, 3, 4), new Point3D(3, 4, 5));

            Console.WriteLine(secondPath);

            PathStorage.SaveToFile("export.txt",secondPath);

            Console.WriteLine();

            Path pathFromFile = PathStorage.ReadFromFile("import.txt");
            Console.WriteLine(pathFromFile);

        }
    }
}
