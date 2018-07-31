using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses_Part2
{
    public class Path
    {
        // Field
        private List<Point3D> points;

        // Constructor
        public Path()
        {
            points = new List<Point3D>();
        }
        // Property
        public List<Point3D> Points
        {
            get => new List<Point3D>(points);
        }

        public int Count { get => this.points.Count; }

        // Methods
        public void AddPoint(Point3D point)
        {
            this.points.Add(point);
        }

        public void RemovePoint(Point3D point)
        {
            this.points.Remove(point);
        }

        public override string ToString()
        {
            return String.Join(Environment.NewLine, this.points);
        }
    }
}
