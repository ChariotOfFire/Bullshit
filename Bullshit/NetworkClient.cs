using System;
using System.Net;
using System.Net.Sockets;

namespace Bullshit
{
    public class NetworkClient
    {
        public static async void Connect()
        {
            using (TcpClient tcpClient = new TcpClient())
            {
                Console.WriteLine("Клиент запущен");
                try
                {
                    await tcpClient.ConnectAsync("127.0.0.1", 8888);
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
