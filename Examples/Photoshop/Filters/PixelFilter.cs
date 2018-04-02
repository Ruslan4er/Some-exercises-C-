using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MyPhotoshop.Data;

namespace MyPhotoshop.Filters
{
    public abstract class PixelFilter : ParametrizedFilter
    {
        protected PixelFilter(IParameters parameters)
            : base(parameters)
        {
        }

        public override Photo Process(Photo original, IParameters parameters)
        {
            var result = new Photo(original.Width, original.Height);

            for (int x = 0; x < result.Width; x++)
                for (int y = 0; y < result.Height; y++)
                {
                    result[x, y] = ProcessPixel(original[x, y], parameters);
                }
            return result;
        }

        public abstract Pixel ProcessPixel(Pixel original, IParameters parameters);
    }
}
