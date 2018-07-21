using System;
using System.Drawing;
using System.Windows.Forms;
using MyPhotoshop.Data;
using MyPhotoshop.Filters;
using MyPhotoshop.Filters.Transform;

namespace MyPhotoshop
{
    class MainClass
    {
        [STAThread]
        public static void Main(string[] args)
        {
            var window = new MainWindow();
            window.AddFilter(new PixelFilter<LighteningParameters>(
                "Осветление/затемнение",
                (pixel, parameters) => pixel * parameters.Coefficient
                ));
            window.AddFilter(new PixelFilter<EmptyParameters>(
                "Черно-белое",
                (pixel, parameters) =>
                {
                    var lightness = (pixel.R + pixel.G + pixel.B) / 3;
                    return new Pixel(lightness, lightness, lightness);
                }));
            window.AddFilter(new TransformFilter(
                "Отразить по горизонтали",
                size => size,
                (point, size) => new Point(size.Width - point.X - 1, point.Y)
                ));
            window.AddFilter(new TransformFilter(
                "Повернуть против часовой стрелки",
                size => new Size(size.Height, size.Width),
                (point, size) => new Point(point.Y, point.X)
                ));



            window.AddFilter(new TransformFilter<RotationParameters>
                ("Свободное вращение", new RotateTratsformer()));

            Application.Run(window);
        }
    }
}
