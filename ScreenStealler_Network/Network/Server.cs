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
    public class Server<T>
    {

        private Dictionary<T, Type> packet_2_index = new Dictionary<T, Type>();

        public delegate void Client_Event_Handler(Client<T> client);
        public event Client_Event_Handler? Client_Online;
        public event Client_Event_Handler? Client_Offline;

        private Packet_Heartbeat<T> heartbeat_packet;
        private Socket server;
        private List<Client<T>> remote_clients = new List<Client<T>>();

        private Func<Socket, Dictionary<T, Type>, Remote_Client<T>> client_getter = (socket, type_dict) => new Remote_Client<T>(socket, type_dict);
        public Server(Func<T> heartbeat_type_getter)
        {
            heartbeat_packet = new Packet_Heartbeat<T>(heartbeat_type_getter);
            Register_Packet(heartbeat_type_getter(), typeof(Packet_Heartbeat<T>));
        }
        public void Set_Client_Getter(Func<Socket, Dictionary<T, Type>, Remote_Client<T>> client_getter) => this.client_getter = client_getter;
        public void Register_Packet(T enum_type, Type packet_type)
        {
            packet_2_index.Add(enum_type, packet_type);
        }
        public void Build_Up(int Port)
        {
            try
            {
                Console.WriteLine("Server is currenly building up ...");
                server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                server.Bind(new IPEndPoint(IPAddress.Any, Port));
                server.Listen(10);
                new Thread(() =>
                {
                    Console.WriteLine("Server builded, listening...");
                    while (true)
                    {
                        Socket client = server.Accept();
                        lock (remote_clients)
                        {
                            Client<T> remote_client = client_getter(client, packet_2_index).Listen();
                            Start_Heartbeat_Checking(remote_client);
                            remote_client.Offline += delegate { Client_Offline?.Invoke(remote_client); };
                            remote_clients.Add(remote_client);
                            Client_Online?.Invoke(remote_client);
                        }
                    }
                }).Start();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
        public void Send_Message(Remote_Client<T> client, Packet_Base<T> packet)
        {
            client.Send_Message(packet);
        }

        private void Start_Heartbeat_Checking(Client<T> client)
        {
            new Thread(() =>
            {

                while (true)
                {
                    try
                    {
                        Thread.Sleep(5000);
                        client.Send_Message(heartbeat_packet);
                    }
                    catch (Exception ex)
                    {
                        if (!client.Is_Online())
                            break;
                    }
                }
            }).Start();
        }
    }
}
