using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenStealler_Client.Packet
{
    enum Packet_Types
    {
        Heartbeat,
        Send_ID,
        Connect_To_ID,
        Request_Screen,
        Get_Screen,
        Display_Screen,
    }
}
