using System;

namespace MyApplication
{
    class monitor
    {
        private string Color;
        private int Dimension;
        private string Resolution;

        public string getColor()
        {
            return this.Color;
        }
        public int getDimension()
        {
            return this.Dimension;
        }
        public string getResolution()
        {
            return this.Resolution;
        }
        public void setColor(string Color)
        {
            this.Color = Color;
        }
        public void setDimension(int Dimension)
        {
            this.Dimension = Dimension;
        }
        public void setResolution(string Resolution)
        {
            this.Resolution = Resolution;
        }


        public monitor(string Color, int Dimension, string Resolution)
        {
            this.Color = Color;
            this.Dimension = Dimension;
            this.Resolution = Resolution;
        }

        static void Main(string[] args)
        {
            monitor m1 = new monitor("Red", 80, "1900x1800");
            monitor m2 = new monitor("Black", 90, "1980x1260");
            Console.WriteLine("\n\tThe first mon: \nColor: "+m1.getColor+"\nDimension: "+m1.getDimension+"\nRezolution: "+m1.getResolution+"\n");
            m1.Color = "Blue";
            m1.Dimension = 43;
            m1.Resolution = "1200";
            Console.WriteLine("\n\tThe first mon was update: \nColor: " + m1.getColor + "\nDimension: " + m1.getDimension + "\nRezolution: " + m1.getResolution + "\n");
            Console.WriteLine("\n\tThe first mon: \nColor: " + m2.getColor + "\nDimension: " + m2.getDimension + "\nRezolution: " + m2.getResolution + "\n");

        }
    }
}