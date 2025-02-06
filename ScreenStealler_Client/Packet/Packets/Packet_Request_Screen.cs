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
    internal class Packet_Request_Screen : Packet_Base<Packet_Types>
    {
        private long ID;
        private bool success = false;
        public override void Decode(byte[] raw_data)
        {
            success = raw_data[0] == 1;
        }
        public void Set_ID(long ID)
        {
            this.ID = ID;
        }
        public override byte[] Encode()
        {
            byte[] result = new byte[8];
            for (int i = 0; i < 8; i++)
            {
                result[i] = (byte)(ID & 0xff);
                ID >>= 8;
            }
            return result;
        }

        public override void Execute(Client<Packet_Types> client)
        {

        }

        public override Packet_Types Get_Type() => Packet_Types.Request_Screen;
    }
}
