using System;

namespace DefiningClasses_Part2
{
    class Program
    {
        static void Main(string[] args)
        {

            Path newPath = PathStorage.LoadFile();

            Point3D point = new Point3D(1, 2, 6);

            newPath.AddPoint(point);

            foreach (var item in newPath.Points)
            {
                Console.WriteLine(item.ToString());
            }

            PathStorage.SaveFile(newPath);

            Point3D first = new Point3D(1, 2, 3);
            Point3D second = new Point3D(1, 5, 8);

            Console.WriteLine(Calculate.CalculateDistance(first, second));
        }
    }
}
