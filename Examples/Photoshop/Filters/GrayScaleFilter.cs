using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MyPhotoshop.Data;

namespace MyPhotoshop.Filters
{
    public class GrayScaleFilter : PixelFilter
    {
        public GrayScaleFilter(IParameters parameters)
            : base(new EmptyParameters())
        {
        }

        public override string ToString()
        {
            return "Черно-белое";
        }

        public override Pixel ProcessPixel(Pixel original, IParameters parameters)
        {
            var lightness = (original.R + original.G + original.B) / 3;
            return new Pixel(lightness, lightness, lightness);
        }
    }
}
