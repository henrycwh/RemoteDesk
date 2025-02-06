//## Author Information
//-**Author**: Feng-Hao Yeh
//-**Email**:
//  - Recommended: zzz3x2c1@gmail.com
//  - Alternate: yeh.feng.hao.110@gmail.com
//  - Work: yeh.feng.hao@try-n-go.com

namespace ScreenStealler_Network.Network
{
    public abstract class Packet_Base<T>
    {

        private byte[] raw_data = new byte[0];
        public abstract byte[] Encode(); // Properities => Raw Data
        public abstract void Decode(byte[] raw_data); // Raw Data => Properities
        public abstract void Execute(Client<T> client);
        public abstract T Get_Type();
    }
}
