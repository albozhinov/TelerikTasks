using System;

public struct Point3D
{
    // Static Field
    public static readonly Point3D startOfCordinateSystem = new Point3D(0, 0, 0);

    // Fields
    private double x;
    private double y;
    private double z;   

    public Point3D(double x, double y, double z)
        : this()
    {
        this.X = x;
        this.Y = y;
        this.Z = z;
    }

    // Properties
    public double X { get => this.x; set => this.x = value; }

    public double Y { get => this.y; set => this.y = value; }

    public double Z { get => this.z; set => this.z = value; }

    public static Point3D StartOfCordinateSystem
    {
        get { return startOfCordinateSystem; }
    }

    // Method override
    public override string ToString()
    {
        return string.Format($"3D-cordinate: X = {this.X}, Y = {this.Y}, Z = {this.Z}");
    }

}

