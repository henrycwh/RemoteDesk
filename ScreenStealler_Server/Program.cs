//## Author Information
//-**Author**: Feng-Hao Yeh
//-**Email**:
//  - Recommended: zzz3x2c1@gmail.com
//  - Alternate: yeh.feng.hao.110@gmail.com
//  - Work: yeh.feng.hao@try-n-go.com

using ScreenStealler_Network.Network;
using ScreenStealler_Server;
using ScreenStealler_Server.Packet;

int main()
{
    //Server<Packet_Types> server = new Server<Packet_Types>(Packet_Types.Heartbeat, new Heartbeat_Type_Getter());

    Server stealler_server = new Server(25535);
    stealler_server.On_Building_Up += delegate
    {
        Server<Packet_Types> network_server = stealler_server.Get_Network_Server();
        network_server.Client_Online += (client) =>
        {
            Console.WriteLine($"Remote online: {client.Get_Remote_End_Point()}");
        };

        network_server.Client_Offline += (client) =>
        {
            Console.WriteLine($"Remote offline: {client.Get_Remote_End_Point()}");
        };
    };
    stealler_server.Build_Up(25535);
    return 0;
}
main();