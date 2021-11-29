using System;
using System.Collections.Generic;


partial class lab7
{
    static void WriteDataG(int j)
    {
        Console.WriteLine(j);
    }


    public class GeometricBodyController {
    static public GeometricBody getBiggestSurfaceBody(List<GeometricBody> bodies) {
        float max = 0;
        GeometricBody maxBody = null;

        foreach (var shape in bodies) { 
            float surf = shape.getSurface();

            if (surf > max) {
                max = surf;
                maxBody = shape;
            }
        }

        return maxBody;
    }

    static public GeometricBody getBiggestVolumeBody(List<GeometricBody> bodies) {
        float max = 0;
        GeometricBody maxBody = null;

        foreach (var shape in bodies) {
            float surf = shape.getVolume();

            if (surf > max) {
                max = surf;
                maxBody = shape;
            }
        }

        return maxBody;
    }
}

}
