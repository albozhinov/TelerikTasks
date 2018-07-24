using System;


struct Point3D
{
    public int X { get; set; }

    public int Y { get; set; }

    public int Z { get; set; }

    private static readonly int o;

    public readonly int O
    {
        get { return this.o; }
        set {; }
    }

    public Point3D(int x, int y, int z)
    {
        this.X = x;
        this.Y = y;
        this.Z = z;
        //this.o = 
    }

    public override string ToString()
    {
        return string.Format($"3D-coordinate: X = {this.X}, Y = {this.Y}, Z = {this.Z}");
    }

}

