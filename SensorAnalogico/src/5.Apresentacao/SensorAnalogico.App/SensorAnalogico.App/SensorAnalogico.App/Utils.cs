using Avalonia.Controls;
using Avalonia.Media.Imaging;
using Avalonia.Platform;
using SkiaSharp;
using Svg.Skia;
using System;
using System.IO;
using System.Linq;

namespace SensorAnalogico.App
{
    public static class Utils
    {
        public static Image ReadSVGToImage(string filePath, string imageName = "", double width = 0f, double height = 0f)
        {
            Image img = new();
            using var svg = new SKSvg();
            if (filePath.ToArray()[0] != '/') { filePath += '/' + filePath; }
            if (svg.Load(AssetLoader.Open(new Uri($"avares://SensorAnalogico.App{filePath}"))) is { })
            {
                var imgStream = new MemoryStream();
                svg.Save(imgStream, SKColor.Empty, SKEncodedImageFormat.Png, 100, 1f, 1f);
                imgStream.Seek(0, SeekOrigin.Begin);

                img = new()
                {
                    Source = new Bitmap(imgStream),
                    Name = imageName,
                };
                if (height > 0f) img.Height = height;
                if (width > 0f) img.Width = width;
            }
            return img;
        }

    }
}
