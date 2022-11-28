using System;
using System.Net;
using System.Net.Sockets;

namespace Bullshit
{
    public static class NetworkServer
    {
        private static TcpListener _tcpServer;

        public static void MyIP()
        {
            // Получение имени компьютера.
            string host = Dns.GetHostName();
            // Получение ip-адреса.
            foreach (var e in Dns.GetHostEntry(host).AddressList)
            {
                Console.WriteLine(e.ToString());
            }

        }

        public async static void Create()
        {
            var localAddress = IPAddress.Parse("127.0.0.1");
            var localEndPoint = new IPEndPoint(localAddress, 8888);
            _tcpServer = new TcpListener(localEndPoint);
            Console.WriteLine(_tcpServer.LocalEndpoint);
            _tcpServer.Start();

            _tcpServer.Start();    // запускаем сервер
            Console.WriteLine("Сервер запущен. Ожидание подключений... ");

            // получаем подключение в виде TcpClient
            using (var tcpClient = await _tcpServer.AcceptTcpClientAsync())
            {
                Console.WriteLine($"Входящее подключение: {tcpClient.Client.RemoteEndPoint}");
            }
            _tcpServer.Stop(); // останавливаем сервер
        }
    }
}
