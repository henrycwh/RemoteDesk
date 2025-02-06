//## Author Information
//-**Author**: Feng-Hao Yeh
//-**Email**:
//  - Recommended: zzz3x2c1@gmail.com
//  - Alternate: yeh.feng.hao.110@gmail.com
//  - Work: yeh.feng.hao@try-n-go.com

using ScreenStealler_Network;
using ScreenStealler_Network.Network;
using ScreenStealler_Server.Packet;
using ScreenStealler_Server.Packet.Packets;

namespace ScreenStealler_Server
{
    internal class Server
    {
        public delegate void Building_Up_Handler(Server<Packet_Types> server);
        public event Building_Up_Handler? On_Building_Up;

        Server<Packet_Types> network_server;
        public Server(int Port) {
            network_server = new Server<Packet_Types>(() => Packet_Types.Heartbeat);
            network_server.Set_Client_Getter((socket, packet_2_index) => new ScreenStealler_Client<Packet_Types>(socket, packet_2_index));
            network_server.Register_Packet(Packet_Types.Send_ID, typeof(Packet_Send_ID));
            network_server.Register_Packet(Packet_Types.Connect_To_ID, typeof(Packet_Connect_To_ID));
            network_server.Register_Packet(Packet_Types.Request_Screen, typeof(Packet_Request_Screen));
            network_server.Register_Packet(Packet_Types.Get_Screen, typeof(Packet_Get_Screen));
            network_server.Register_Packet(Packet_Types.Display_Screen, typeof(Packet_Display_Screen));
        }
        public Server<Packet_Types> Get_Network_Server() => network_server;
        public void Build_Up(int Port)
        {
            On_Building_Up?.Invoke(network_server);
            network_server.Build_Up(Port);
        }
    }
}
