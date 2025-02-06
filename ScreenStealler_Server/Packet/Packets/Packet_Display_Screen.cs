//## Author Information
//-**Author**: Feng-Hao Yeh
//-**Email**:
//  - Recommended: zzz3x2c1@gmail.com
//  - Alternate: yeh.feng.hao.110@gmail.com
//  - Work: yeh.feng.hao@try-n-go.com

using ScreenStealler_Network.Network;

namespace ScreenStealler_Server.Packet.Packets
{
    internal class Packet_Display_Screen : Packet_Base<Packet_Types>
    {
        private long ID;
        private byte[] screen_data = new byte[0];
        public void Set_ID(long ID) => this.ID = ID;
        public void Set_Screen_Data(byte[] Screen_Data) => screen_data= Screen_Data;

        public override void Decode(byte[] raw_data)
        {
            // Nothing to do
        }

        public override byte[] Encode()
        {
            byte[] result = new byte[8 + screen_data.Length];
            int i = 0;
            for (i = 0; i < 8; i++)
            {
                result[i] = (byte)(ID & 0xff);
                ID >>= 8;
            }
            for (; i < result.Length; i++) result[i] = screen_data[i - 8];
            return result;
        }

        public override void Execute(Client<Packet_Types> client)
        {
            // Nothing to do
        }

        public override Packet_Types Get_Type() => Packet_Types.Display_Screen;
    }
}
