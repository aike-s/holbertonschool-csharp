using System;

/// <sumary>
/// Class Shape
/// </sumary>
class Shape
{
    /// <sumary>
    /// Throws an NotImplementedException
    /// </sumary>
    public virtual int Area()
    {
        throw new NotImplementedException("Area() is not implemented");
    }
}

/// <sumary>
/// Class Rectangle that inherits from Shape
/// </sumary>
class Rectangle : Shape
{
    // Private width
    private int width;

    // Private height
    private int height;

    /// <sumary> Public property Width </sumary>
    public int Width
    {
        get => width;
        set
        {
            if (value < 0)
                throw new ArgumentException("Width must be greater than or equal to 0");
            else
                width = value;
        }
    }

    /// <sumary> Public property Height </sumary>
    public int Height
    {
        get => height;
        set
        {
            if (value < 0)
                throw new ArgumentException("Height must be greater than or equal to 0");
            else
                height = value;
        }
    }
    /// <sumary>
    /// Returns the area
    /// </sumary>
    public new int Area()
    {
        int area = width * height;
        return area;
    }

    /// <sumary>
    /// Prints in object acording to a format
    /// </sumary>
    public override string ToString()
    {
        return string.Format("[Rectangle] {0} / {1}", width, height);
    }
}

/// <sumary>
/// Class Square
/// </sumary>
class Square : Rectangle
{
    // Private size
    private int size;

    /// <sumary> Public property Size </sumary>
    public int Size
    {
        get => size;
        set
        {
            if (value < 0)
                throw new ArgumentException("Size must be greater than or equal to 0");
            else
            {
                size = value;
                this.Width = value;
                this.Height = value;
            }
        }
    }
}
