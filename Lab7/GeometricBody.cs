using System;

partial class lab7
{
    static void WriteData(int i)
    {
        Console.WriteLine(i);
    }
    public interface GeometricBody
    {
        float getSurface();
        float getVolume();
    }

}
