using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace DefiningClasses_Part2
{
    public static class PathStorage
    {
        // file to be read or written
        private static readonly StreamReader readFile = new StreamReader("CoordinatesIn.txt");
        private static readonly StreamWriter writeFile = new StreamWriter("DefiningClasses-Part2");
        
        public static Path LoadFile()
        {
            Path currentPath = new Path();

            using (readFile)
            {
                string line = readFile.ReadLine();

                while (line != null)
                {
                    string[] numbers = line.Split(' ');

                    Point3D currPoint = new Point3D()
                    {
                        X = double.Parse(numbers[0]),
                        Y = double.Parse(numbers[1]),
                        Z = double.Parse(numbers[2])
                    };

                    currentPath.AddPoint(currPoint);

                    line = readFile.ReadLine();
                }
            }
            return currentPath;
        }

        // save file
        public static void SaveFile(Path currentPath)
        {
            using (writeFile)
            {
                foreach (var item in currentPath.Points)
                {
                    string toBeWritten = string.Format("{0} {1} {2}", item.X, item.Y, item.Z);
                    writeFile.WriteLine(toBeWritten);
                }
            }
        }
    }
}
