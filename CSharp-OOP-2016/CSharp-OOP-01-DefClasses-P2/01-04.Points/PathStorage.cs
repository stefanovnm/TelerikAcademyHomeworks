//Create a static class PathStorage with static methods to save and load paths from a text file.
//Use a file format of your choice.

namespace _01_04.Points
{
    using System;
    using System.IO;
    using System.Linq;

    public static class PathStorage
    {
        public static void SaveToFile(string file, Path path)
        {
            file = @"..\..\Results\" + file; //just for easy access
            StreamWriter writer = new StreamWriter(file, false);//overwrite

            using (writer)
            {
                writer.Write(path);
            }

            Console.WriteLine("Result is saved in "+file.Substring(5,file.Length-5));
        }
        
        public static Path ReadFromFile(string file)
        {
            Path path = new Path();
            file = @"..\..\Input\" + file; //just for easy access
            StreamReader reader = new StreamReader(file);
            Console.WriteLine("Path is read from " + file.Substring(5, file.Length - 5));

            using (reader)
            {
                string currentLine = reader.ReadLine();
                while (!string.IsNullOrEmpty(currentLine))
                {
                    currentLine = currentLine.Replace("p(","");

                    decimal[] currentPoint = currentLine
                        .Split(new char[] { ' ', ',', ')' }, StringSplitOptions.RemoveEmptyEntries)
                        .Select(decimal.Parse)
                        .ToArray();

                    path.AddPoint(new Point3D(currentPoint[0], currentPoint[1], currentPoint[2]));
                    currentLine = reader.ReadLine();
                }
            }

            Console.WriteLine("Path was read");

            return path;
        }
    }
}
