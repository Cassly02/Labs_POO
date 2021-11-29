using System;
using System.Collections;
using System.Collections.Generic;


partial class lab7
{
    static void Main(string[] args)
    {
        int i = 1;
        Console.WriteLine("Test:");
        while (i++ < 10)
        {
            WriteDataP(i);
        }

        ////////////////////////////////////////////////////////////////////

        GeometricBody cube = new Cube(53);
        GeometricBody sphere = new Sphere(34);
        GeometricBody parallelepiped = new Parallelepiped(13, 19, 15);

        List<GeometricBody> bodies = new List<GeometricBody>();

        Console.WriteLine("Basic Level:");

        Console.WriteLine("\nCube:");
        Console.WriteLine("Volume: " + cube.getVolume());
        Console.WriteLine("Surface: " + cube.getSurface());

        Console.WriteLine("\nSphere:");
        Console.WriteLine("Volume: " + sphere.getVolume());
        Console.WriteLine("Surface: " + sphere.getSurface());

        Console.WriteLine("\nParallelepiped:");
        Console.WriteLine("Volume: " + parallelepiped.getVolume());
        Console.WriteLine("Surface: " + parallelepiped.getSurface());


        bodies.Add(cube);
        bodies.Add(sphere);
        bodies.Add(parallelepiped);

        Console.WriteLine("\nAdvanced Level:\n");
        Console.WriteLine("The biggest volume: " + GeometricBodyController.getBiggestSurfaceBody(bodies).getSurface());
        Console.WriteLine("The biggest surface: " + GeometricBodyController.getBiggestVolumeBody(bodies).getVolume());


        ////////////////////////////////////////////////////////////////////


    }
}
