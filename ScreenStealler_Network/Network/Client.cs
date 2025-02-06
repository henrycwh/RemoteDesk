//## Author Information
//-**Author**: Feng-Hao Yeh
//-**Email**:
//  - Recommended: zzz3x2c1@gmail.com
//  - Alternate: yeh.feng.hao.110@gmail.com
//  - Work: yeh.feng.hao@try-n-go.com

using ScreenStealler_Network.Network.Packets;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Threading;



namespace ScreenStealler_Network.Network
{
    public enum Keyboard_Control
    {
        Key_Down,
        Key_Up
    }
    public class Client<T>
    {
        public delegate void Offline_Event_Handler();
        public event Offline_Event_Handler Offline;
        protected Dictionary<T, Type> packet_2_index = new Dictionary<T, Type>();
        protected Socket socket;
        protected bool is_online = false;
        public EndPoint? Get_Remote_End_Point() => socket.RemoteEndPoint;
        public Client() { }
        public Client(IPEndPoint end_point, Dictionary<T, Type> packet_2_index, T Heartbeat_Type)
        {
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            socket.Connect(end_point);
            is_online = true;
            this.packet_2_index = packet_2_index;
            packet_2_index.Add(Heartbeat_Type, typeof(Packet_Heartbeat<T>));
        }
        public bool Is_Online() => is_online;
        protected virtual void On_Client_Offline() { }
        public Client<T> Listen()
        {
            new Thread(() =>
            {
                try
                {
                    Console.WriteLine("start listen");

                    // Data_Length[3], Data_Length[2], Data_Length[1], Data_Length[0], Data[0 ~ Data_Length - 1], CRC
                    int length = 0;
                    byte[] temp = new byte[2048];

                    byte[] received_data = new byte[0];
                    int data_receive_state = -1;
                    int data_length = 0;
                    int received_index = 0;
                    byte CRC = 0;
                    int packet_index = 0;
                    while (true)
                    {
                        length = socket.Receive(temp);
                        if (length < 1)
                            break;

                        for (int i = 0; i < length; i++)
                        {
                            if (data_receive_state < 4)
                            {
                                if (data_receive_state == -1)
                                    packet_index = temp[i];
                                else
                                {
                                    data_length <<= 8;
                                    data_length |= temp[i];
                                }
                                data_receive_state++;
                                if (data_receive_state == 4)
                                {
                                    //1 byte packet index + 4 bytes length of data + data array + 1 byte CRC
                                    received_data = new byte[1 + 4 + data_length + 1];
                                    received_data[0] = (byte)packet_index;
                                    for (int j = 4; j > 0; j--)
                                        received_data[j] = (byte)((data_length >> ((j - 1) << 3)) & 0xFF);
                                }
                            }
                            else
                            {
                                received_data[1 + 4 + received_index++] = temp[i];

                                if (received_index > data_length)
                                {
                                    if (CRC == temp[i])
                                    {
                                        Packet_Base<T> packet = Deserialize_Packet(received_data);
                                        packet.Execute(this);
                                    }
                                    else
                                        break;
                                    received_index = 0;
                                    data_receive_state = -1;
                                    data_length = 0;
                                    CRC = 0;
                                    temp[i] = 0;
                                }
                            }
                            CRC += temp[i];
                        }
                    }
                }
                catch (Exception ex)
                {

                }
                Console.WriteLine("client offline");
                is_online = false;
                On_Client_Offline();
                Offline?.Invoke();
            }).Start();
            return this;
        }

        public void Close()
        {
            try
            {
                is_online = false;
                socket.Close();
            }
            catch (Exception)
            {

            }
        }
        public void Send_Message(Packet_Base<T> packet)
        {
            socket.Send(Serialize_Packet(packet));
        }

        private byte[] Serialize_Packet(Packet_Base<T> packet)
        {
            byte[] packet_raw_data = packet.Encode();
            if (packet_raw_data.Length == 0) throw new Exception("Raw data could not be empty");
            byte[] result = new byte[1 + 4 + packet_raw_data.Length + 1]; //1 byte packet index + 4 bytes length of data + data array + 1 byte CRC
            byte CRC = 0;
            int current_index = 0;

            T packet_index = packet.Get_Type();

            result[current_index] = (byte)Convert.ToInt32(packet_index);
            CRC += result[current_index++];

            for (int i = 3; i > -1; i--)
            {
                result[current_index] = (byte)(packet_raw_data.Length >> (i << 3));
                CRC += result[current_index++];
            }
            for (int i = 0; i < packet_raw_data.Length; i++)
            {
                result[current_index] = packet_raw_data[i];
                CRC += result[current_index++];
            }
            result[current_index] = CRC;
            return result;
        }
        private Packet_Base<T> Deserialize_Packet(byte[] data)
        {
            int length = data.Length - 1 - 4 - 1;
            T packet_type = (T)Enum.ToObject(typeof(T), data[0]);
            Type packetType = packet_2_index[packet_type];
            Packet_Base<T> packet = (Packet_Base<T>)Activator.CreateInstance(packetType);
            byte[] packet_raw_data = new byte[length];
            for (int i = 0; i < length; i++)
                packet_raw_data[i] = data[i + 1 + 4];
            packet.Decode(packet_raw_data);
            return packet;
        }
    }
}
