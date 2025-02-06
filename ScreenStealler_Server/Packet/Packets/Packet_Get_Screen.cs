//## Author Information
//-**Author**: Feng-Hao Yeh
//-**Email**:
//  - Recommended: zzz3x2c1@gmail.com
//  - Alternate: yeh.feng.hao.110@gmail.com
//  - Work: yeh.feng.hao@try-n-go.com

using ScreenStealler_Network;
using ScreenStealler_Network.Network;

namespace ScreenStealler_Server.Packet.Packets
{
    internal class Packet_Get_Screen : Packet_Base<Packet_Types>
    {
        private long Request_ID;
        private byte[] screen_data = new byte[0];

        public void Set_Request_ID(long ID)
        {
            Request_ID = ID;
        }
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
            byte[] result = new byte[8];
            for (int i = 0; i < 8; i++)
            {
                result[i] = (byte)(Request_ID & 0xff);
                Request_ID >>= 8;
            }
            return result;
        }

        public override void Execute(Client<Packet_Types> client)
        {
            if (!ScreenStealler_Client<Packet_Types>.Contains_Client_By_ID(Request_ID))
                return;
            Packet_Display_Screen display = new Packet_Display_Screen();
            display.Set_ID((client as ScreenStealler_Client<Packet_Types>).Get_ID());
            display.Set_Screen_Data(screen_data);
            client = ScreenStealler_Client<Packet_Types>.Get_Client_By_ID(Request_ID);
            client.Send_Message(display);
        }

        public override Packet_Types Get_Type() => Packet_Types.Get_Screen;
    }
}
