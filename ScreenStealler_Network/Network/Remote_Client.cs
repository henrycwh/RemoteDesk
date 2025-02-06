//## Author Information
//-**Author**: Feng-Hao Yeh
//-**Email**:
//  - Recommended: zzz3x2c1@gmail.com
//  - Alternate: yeh.feng.hao.110@gmail.com
//  - Work: yeh.feng.hao@try-n-go.com

using System;
using System.Collections.Generic;
using System.Net.Sockets;

namespace ScreenStealler_Network.Network
{
    public class Remote_Client<T> : Client<T>
    {
        public Remote_Client(Socket socket, Dictionary<T, Type> packet_2_index)
        {
            this.socket = socket;
            is_online = true;
            this.packet_2_index = packet_2_index;
        }
    }
}
