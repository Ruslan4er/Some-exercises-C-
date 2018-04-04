using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using MyPhotoshop.Data;

namespace MyPhotoshop.Filters
{
    public class TransformFilter : ParametrizedFilter<EmptyParameters>
        //where TParameters : IParameters, new()
    {
        string name;
        Func<Size, Size> sizeTransform;
        Func<Point, Size, Point> pointTransform;

        public TransformFilter(string name, Func<Size, Size> sizeTransform, Func<Point, Size, Point> pointTransform)
        {
            this.name = name;
            this.sizeTransform = sizeTransform;
            this.pointTransform = pointTransform;
        }

        public override string ToString()
        {
            return name;
        }

        public override Photo Process(Photo original, EmptyParameters parameters)
        {
            var oldSize = new Size(original.Width, original.Height);
            var newSize = sizeTransform(oldSize);
            var result = new Photo(newSize.Width, newSize.Height);
            for (var x = 0; x < newSize.Width; x++)
            {
                for (var y = 0; y < newSize.Height; y++)
                {
                    var point = new Point(x, y);
                    var oldPoint = pointTransform(point, oldSize);
                    result[x, y] = original[oldPoint.X, oldPoint.Y];
                }
            }
            return result;
        }
    }
}
