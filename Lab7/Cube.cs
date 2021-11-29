using System;

partial class lab7
{
    static void WriteDataC(int i)
    {
        Console.WriteLine(i);
    }
    public class Cube : GeometricBody
    {
        private float length;

        public Cube(float l)
        {
            length = l;
        }

        public float getSurface()
        {
            return 6 * (length * length);
        }

        public float getVolume()
        {
            return length * length * length;
        }

    }

}
