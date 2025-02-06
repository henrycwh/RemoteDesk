//## Author Information
//-**Author**: Feng-Hao Yeh
//-**Email**:
//  - Recommended: zzz3x2c1@gmail.com
//  - Alternate: yeh.feng.hao.110@gmail.com
//  - Work: yeh.feng.hao@try-n-go.com

using System.Drawing;
using System.IO;
using System.Windows;

namespace ScreenStealler_Client
{
    class Screen_Helper
    {
        private static byte[] CaptureScreen()
        {
            double screenLeft = SystemParameters.VirtualScreenLeft;
            double screenTop = SystemParameters.VirtualScreenTop;
            double screenWidth = SystemParameters.VirtualScreenWidth;
            double screenHeight = SystemParameters.VirtualScreenHeight;
            byte[] bytes;
            using (Bitmap bmp = new Bitmap((int)screenWidth, (int)screenHeight))
            {

                using (Graphics g = Graphics.FromImage(bmp))
                {
                    g.CopyFromScreen((int)screenLeft, (int)screenTop, 0, 0, bmp.Size);
                    using (var stream = new MemoryStream())
                    {
                        bmp.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
                        bytes = stream.ToArray();
                    }
                }
            }
            return bytes;
        }

        public static byte[] Get_Screen() => CaptureScreen();
    }
}
