//## Author Information
//-**Author**: Feng-Hao Yeh
//-**Email**:
//  - Recommended: zzz3x2c1@gmail.com
//  - Alternate: yeh.feng.hao.110@gmail.com
//  - Work: yeh.feng.hao@try-n-go.com

using ScreenStealler_Network.Network;
using System.Net.Sockets;

namespace ScreenStealler_Network
{
    internal class ScreenStealler_Client<T> : Remote_Client<T>
    {
        private static Dictionary<long, ScreenStealler_Client<T>> id_2_clients = new Dictionary<long, ScreenStealler_Client<T>>();
        public static bool Contains_Client_By_ID(long ID) => id_2_clients.ContainsKey(ID);
        public static ScreenStealler_Client<T> Get_Client_By_ID(long ID) => id_2_clients[ID];

        private long ID = 0;
        private string Password = "";

        public ScreenStealler_Client(Socket socket, Dictionary<T, Type> packet_2_index) : base(socket, packet_2_index)
        {
            lock (id_2_clients)
            {
                do
                {
                    ID = DateTime.Now.Ticks % 1000000000;
                } while (id_2_clients.ContainsKey(ID));
                id_2_clients.Add(ID, this);
            }
            Password = Global.Generate_Random_String(6);
        }
        protected new void On_Client_Offline()
        {
            lock (id_2_clients) id_2_clients.Remove(ID);
        }
        public long Get_ID() => ID;
        public int Get_Screen()
        {
            return 0;
        }
        public void Set_Display_Screen(int Image)
        {

        }
        public void Send_Mouse_Position(int x, int y)
        {

        }
        public void Send_Keyboard_Status(Keyboard_Control control, Key_Code key)
        {

        }
        public bool Is_Password_Valid(string Password) => this.Password.Equals(Password);
    }
}
