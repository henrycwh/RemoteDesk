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
    internal class Packet_Request_Screen : Packet_Base<Packet_Types>
    {
        private long ID;
        private bool Success = false;

        public override void Decode(byte[] raw_data)
        {
            ID = 0;
            for (int i = 0; i < 8; i++)
                ID |= raw_data[i] << (i << 3);
        }

        public override byte[] Encode()
        {
            return new byte[] { (byte)(Success ? 1 : 0) };
        }

        public override void Execute(Client<Packet_Types> client)
        {
            Success = ScreenStealler_Client<Packet_Types>.Contains_Client_By_ID(ID);
            client.Send_Message(this);

            if (Success)
            {
                Packet_Get_Screen packet = new Packet_Get_Screen();
                packet.Set_Request_ID((client as ScreenStealler_Client<Packet_Types>).Get_ID());
                client = ScreenStealler_Client<Packet_Types>.Get_Client_By_ID(ID);
                client.Send_Message(packet);
            }
        }

        public override Packet_Types Get_Type() => Packet_Types.Request_Screen;
    }
}
