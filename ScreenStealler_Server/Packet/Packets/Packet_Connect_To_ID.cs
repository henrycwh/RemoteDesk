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
    internal class Packet_Connect_To_ID : Packet_Base<Packet_Types>
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

            long ID = this.ID;
            byte[] result = new byte[1 + 8];
            result[0] = (byte)(Success ? 1 : 0);
            for (int i = 0; i < 8; i++)
            {
                result[i + 1] = (byte)(ID & 0xff);
                ID >>= 8;
            }
            return result;
        }

        public override void Execute(Client<Packet_Types> client)
        {
            Success = ScreenStealler_Client<Packet_Types>.Contains_Client_By_ID(ID);
            client.Send_Message(this);
        }

        public override Packet_Types Get_Type() => Packet_Types.Connect_To_ID;
    }
}
