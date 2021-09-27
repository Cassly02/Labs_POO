using System;

namespace MyApplication
{
    class monitor
    {
            public string Color;
            public int Dimension;
            public string Resolution;
        public monitor(string ColorName, int DimensionNr, string ResolutionNr)
        {
            Color = ColorName;
            Dimension = DimensionNr;
            Resolution = ResolutionNr;
        }

        static void Main(string[] args)
        {
            monitor m1 = new monitor("Golden",22,"1901x1680");
            monitor m2 = new monitor("Brown",32,"1960x1880");
            Console.WriteLine(m1.Color + " " + m1.Dimension + " " + m1.Resolution);
            Console.WriteLine(m2.Color + " " + m2.Dimension + " " + m2.Resolution);

        }
    }
}