//## Author Information
//-**Author**: Feng-Hao Yeh
//-**Email**:
//  - Recommended: zzz3x2c1@gmail.com
//  - Alternate: yeh.feng.hao.110@gmail.com
//  - Work: yeh.feng.hao@try-n-go.com

using System.Windows;
using System.Windows.Media;

namespace ScreenStealler_Client.GUIs
{
    /// <summary>
    /// Remote_Screen.xaml 的互動邏輯
    /// </summary>
    public partial class Remote_Screen : Window
    {
        private long ID;
        public Remote_Screen(long ID)
        {
            this.ID = ID;
            InitializeComponent();
            Title = ID.ToString();
            Closing += delegate { Global.Dispose_Screen(this); };
        }
        public long Get_ID() => ID;
        public void Display(ImageSource image)
        {
            screen_displayer.Source = image;
            Show();
        }
    }
}
