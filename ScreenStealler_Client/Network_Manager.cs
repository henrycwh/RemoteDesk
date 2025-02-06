//## Author Information
//-**Author**: Feng-Hao Yeh
//-**Email**:
//  - Recommended: zzz3x2c1@gmail.com
//  - Alternate: yeh.feng.hao.110@gmail.com
//  - Work: yeh.feng.hao@try-n-go.com

using ScreenStealler_Client.Packet;
using ScreenStealler_Client.Packets;
using ScreenStealler_Network.Network;
using System;
using System.Collections.Generic;
using System.Net;

namespace ScreenStealler_Client
{
    internal class Network_Manager
    {
        public static Client<Packet_Types> Create_Client(IPEndPoint server_end_point)
        {
            Dictionary<Packet_Types, Type> packet_2_type = new Dictionary<Packet_Types, Type>()
            {
                {Packet_Types.Send_ID, typeof(Packet_Send_ID) },
                {Packet_Types.Connect_To_ID, typeof(Packet_Connect_To_ID) },
                {Packet_Types.Request_Screen, typeof(Packet_Request_Screen) },
                {Packet_Types.Get_Screen, typeof(Packet_Get_Screen) },
                {Packet_Types.Display_Screen, typeof(Packet_Display_Screen) },
            };
            Client<Packet_Types> client = new Client<Packet_Types>(server_end_point, packet_2_type, Packet_Types.Heartbeat);
            client.Listen();
            return client;
        }
    }
}
