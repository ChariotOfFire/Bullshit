using System;
using System.Net;
using System.Net.Sockets;

namespace Bullshit
{
    public class NetworkClient
    {
        public static async void Connect(string host)
        {
            if (host.Contains(":") == false)
                return;

            var hostArray = host.Split(':');
            var ip = hostArray[0];
            var port = int.Parse(hostArray[1]);
            using (TcpClient tcpClient = new TcpClient())
            {
                Console.WriteLine("Клиент запущен");
                try
                {
                    await tcpClient.ConnectAsync(ip, port);
                }
                catch (SocketException e)
                {
                    Console.WriteLine(e);
                }

                if (tcpClient.Connected)
                    Console.WriteLine($"Подключение с {tcpClient.Client.RemoteEndPoint} установлено");
                else
                    Console.WriteLine("Не удалось подключиться");
            }
        }
    }
}
