//## Author Information
//-**Author**: Feng-Hao Yeh
//-**Email**:
//  - Recommended: zzz3x2c1@gmail.com
//  - Alternate: yeh.feng.hao.110@gmail.com
//  - Work: yeh.feng.hao@try-n-go.com

using System;

namespace ScreenStealler_Network.Network.Packets
{
    internal class Packet_Heartbeat<T> : Packet_Base<T>
    {
        Func<T> type_getter;
        public Packet_Heartbeat(Func<T> type_getter)
        {
            this.type_getter = type_getter;
        }

        public override byte[] Encode()
        {
            return new byte[0];
        }
        public override void Decode(byte[] raw_data)
        {
        }

        public override T Get_Type() => type_getter();

        public override void Execute(Client<T> client)
        {
        }
    }
}
