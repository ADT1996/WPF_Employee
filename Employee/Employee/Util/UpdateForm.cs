using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace Employee.Util
{
    enum ACTION { VIEW, EDIT, INSERT}
    class UpdateForm
    {
        public static string EMPTY = "";
        public static bool UNCHECKED = false;
        public static DateTime? NONDAY = null;
        public static object NONITEM = null;
        
        public static Brush DefaultBGTextBox = (SolidColorBrush) new BrushConverter().ConvertFrom("#FFFFFF");
        public static Brush ErrorBGControl = (SolidColorBrush) new BrushConverter().ConvertFrom("#FFFF00");

        public static Brush DefaultBGCmb
        {
            get
            {
                LinearGradientBrush myLinearGradientBrush = new LinearGradientBrush();

                myLinearGradientBrush.StartPoint = new Point(0.5, 0);
                myLinearGradientBrush.EndPoint = new Point(0.5, 1
);

                BrushConverter brushConverter = new BrushConverter();
                GradientStop color1 = new GradientStop(Color.FromArgb(255,243,243,243),0.0);
                GradientStop color2 = new GradientStop(Color.FromArgb(255, 221, 221, 221), 0.5);
                GradientStop color3 = new GradientStop(Color.FromArgb(255, 205, 205, 205), 1.0);

                myLinearGradientBrush.GradientStops.Add(color1);
                myLinearGradientBrush.GradientStops.Add(color2);
                myLinearGradientBrush.GradientStops.Add(color3);

                return myLinearGradientBrush;
            }
        }

        public static ImageSource BytesToImage(byte[] image)
        {
            if (image == null) return null;

            BitmapImage bitmap = new BitmapImage();
            MemoryStream memory = new MemoryStream(image);
            bitmap.BeginInit();
            bitmap.StreamSource = memory;
            bitmap.EndInit();
            return bitmap;
        }

        public static byte[] ImageToBytes(ImageSource image)
        {
            byte[] bytps = null;
            var bitmapImage = image as BitmapImage;
            
            if(bitmapImage != null)
            {
                var encoder = new JpegBitmapEncoder();
                encoder.Frames.Add(BitmapFrame.Create(bitmapImage));
                using(var stream = new MemoryStream())
                {
                    encoder.Save(stream);
                    bytps = stream.ToArray();
                }
            }

            return bytps;
        }
    }
}
