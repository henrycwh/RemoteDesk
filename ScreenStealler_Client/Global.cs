//## Author Information
//-**Author**: Feng-Hao Yeh
//-**Email**:
//  - Recommended: zzz3x2c1@gmail.com
//  - Alternate: yeh.feng.hao.110@gmail.com
//  - Work: yeh.feng.hao@try-n-go.com

using ScreenStealler_Client.GUIs;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace ScreenStealler_Client
{
    internal class Global
    {
        public delegate void On_ID_Set_Handler(long ID);
        public static event On_ID_Set_Handler On_ID_Set;

        private static long ID = 0;
        private static TaskScheduler? Scheduler;

        private static Dictionary<long, Remote_Screen> remotes = new Dictionary<long, Remote_Screen>();
        public static void Set_Task_Scheduler(TaskScheduler Scheduler) => Global.Scheduler = Scheduler;
        public static TaskScheduler? Get_Task_Scheduler() => Scheduler;

        public static long Get_ID() => ID;
        public static void Set_ID(long ID)
        {
            Global.ID = ID;
            if (Scheduler != null)
                new Task(() =>
                {
                    On_ID_Set?.Invoke(ID);
                }).Start(Scheduler);
        }
        public static void Dispose_Screen(Remote_Screen screen)
        {
            if (remotes.ContainsKey(screen.Get_ID())) remotes.Remove(screen.Get_ID());
        }
        public static void Display_Screen(long ID, byte[] Screen_Data)
        {
            if (Scheduler != null)
                new Task(() =>
                {
                    Remote_Screen screen;
                    if (remotes.ContainsKey(ID)) screen = remotes[ID];
                    else remotes.Add(ID, screen = new Remote_Screen(ID));

                    ImageSource imageSource = ByteArrayToImageSource(Screen_Data);
                    screen.Display(imageSource);
                }).Start(Scheduler);
        }


        private static ImageSource ByteArrayToImageSource(byte[] imageData)
        {
            using (MemoryStream ms = new MemoryStream(imageData))
            {
                BitmapImage bitmap = new BitmapImage();
                bitmap.BeginInit();
                bitmap.StreamSource = ms;
                bitmap.CacheOption = BitmapCacheOption.OnLoad;
                bitmap.EndInit();
                return bitmap;
            }
        }

    }
}
