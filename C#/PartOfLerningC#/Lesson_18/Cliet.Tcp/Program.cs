using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Cliet.Tcp
{
    class Program
    {
        public static object Encodin { get; private set; }

        static void Main(string[] args)
        {
            #region TCP
            //const string ip = "127.0.0.1";
            //const int port = 8080;
            //var tcpEndPoint = new IPEndPoint(IPAddress.Parse(ip), port);
            //var TcpSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            //Console.WriteLine("Input Messang");
            //var message = Console.ReadLine();
            //var data = Encoding.UTF8.GetBytes(message);
            //TcpSocket.Connect(tcpEndPoint);
            //TcpSocket.Send(data);
            //var buffer = new byte[256];
            //var size = 0;
            //var answer = new StringBuilder();
            //do
            //{
            //    size = TcpSocket.Receive(buffer);
            //    answer.Append(Encoding.UTF8.GetString(buffer, 0, size));
            //}
            //while (TcpSocket.Available > 0);
            //Console.WriteLine(answer.ToString());
            //TcpSocket.Shutdown(SocketShutdown.Both);
            //TcpSocket.Close();
            //Console.ReadLine();
            #endregion
            const string ip = "127.0.0.1";
            const int port = 8082;
            var udpEndPoint = new IPEndPoint(IPAddress.Parse(ip), port);
            var udpSocket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            udpSocket.Bind(udpEndPoint);
            while (true)
            {
                
                Console.WriteLine("Input message");
                var message = Console.ReadLine();
                var serverEndPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8081);
                udpSocket.SendTo(Encoding.UTF8.GetBytes(message),serverEndPoint);
                var buffer = new byte[256];
                var size = 0;
                var data = new StringBuilder();

                EndPoint senderEndPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8081);
                do
                {

                    size = udpSocket.ReceiveFrom(buffer, ref senderEndPoint);
                    data.Append(Encoding.UTF8.GetString(buffer));

                }
                while (udpSocket.Available > 0);
                Console.WriteLine(data);
                Console.ReadLine();
            }
        }
    }
}
