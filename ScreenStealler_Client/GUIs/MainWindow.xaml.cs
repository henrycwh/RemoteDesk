//## Author Information
//-**Author**: Feng-Hao Yeh
//-**Email**:
//  - Recommended: zzz3x2c1@gmail.com
//  - Alternate: yeh.feng.hao.110@gmail.com
//  - Work: yeh.feng.hao@try-n-go.com

using ScreenStealler_Client.Packet;
using ScreenStealler_Client.Packets;
using ScreenStealler_Network.Network;
using System.Net;
using System.Threading.Tasks;
using System.Windows;

namespace ScreenStealler_Client
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Client<Packet_Types>? client;
        public MainWindow()
        {
            InitializeComponent();
            Global.Set_Task_Scheduler(TaskScheduler.FromCurrentSynchronizationContext());
            Global.On_ID_Set += (ID) =>
            {
                ID_TextBlock.Text = ID.ToString();
                Remote_ID.Text = ID.ToString();
            };
            Loaded += delegate
            {
                client = Network_Manager.Create_Client(new IPEndPoint(IPAddress.Parse("127.0.0.1"), 25535));
                client.Send_Message(new Packet_Send_ID());
            };
            Closing += delegate
            {
                client?.Close();
            };
        }

        private void On_Connect_Clicked(object sender, RoutedEventArgs e)
        {
            long id = long.Parse(Remote_ID.Text);
            Packet_Connect_To_ID connect_to_id = new Packet_Connect_To_ID();
            connect_to_id.Set_ID(id);
            client?.Send_Message(connect_to_id);
        }
    }
}
