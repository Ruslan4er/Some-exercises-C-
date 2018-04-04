using System;

namespace MyPhotoshop.Data
{
    public struct Pixel
    {
        public Pixel(double r, double g, double b)
            : this()
        {
            R = r;
            G = g;
            B = b;
        }

        private double Check(double value)
        {
            if (value < 0 || value > 1)
            {
                throw new ArgumentOutOfRangeException();
            }
            return value;
        }

        private double r;

        public double R
        {
            get { return r; }
            set { r = Check(value); }
        }

        private double g;

        public double G
        {
            get { return g; }
            set { g = Check(value); }
        }

        private double b;

        public double B
        {
            get { return b; }
            set { b = Check(value); }
        }

        public static double Trim(double value)
        {
            if (value < 0) return 0;
            return value > 1 ? 1 : value;
        }

        public static Pixel operator *(Pixel pixel, double value)
        {
            return new Pixel(
                Trim(pixel.R * value),
                Trim(pixel.G * value),
                Trim(pixel.B * value)
                );
        }

        public static Pixel operator *(double value, Pixel pixel)
        {
            return pixel * value;
        }

    }
}
