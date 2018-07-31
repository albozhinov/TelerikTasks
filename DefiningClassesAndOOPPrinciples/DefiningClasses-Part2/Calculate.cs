using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses_Part2
{
    public static class Calculate
    {        
        public static double  CalculateDistance(Point3D firstPoint, Point3D secondPoint)
        {
            double result = Math.Sqrt((secondPoint.X - firstPoint.X) * (secondPoint.X - firstPoint.X)
                                       +
                                       (secondPoint.Y - firstPoint.Y) * (secondPoint.Y - firstPoint.Y)
                                       +
                                       (secondPoint.Z - firstPoint.Z) * (secondPoint.Z - firstPoint.Z));
            return result;
        }
    }
}
