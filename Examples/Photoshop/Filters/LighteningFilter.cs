using System;
using MyPhotoshop.Data;
using MyPhotoshop.Filters;

namespace MyPhotoshop.Filters
{
    public class LighteningFilter : PixelFilter
    {
        public LighteningFilter(IParameters parameters)
            : base(new LighteningParameters())
        {
        }
        
        public override string ToString()
        {
            return "Осветление/затемнение";
        }

        public override Pixel ProcessPixel(Pixel original, IParameters parameters)
        {
            return original * (parameters as LighteningParameters).Coefficient;
        }
    }
}


