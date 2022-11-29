using System;
using System.Net;
using System.Net.Sockets;

namespace Bullshit
{
    public static class NetworkServer
    {
        private static TcpListener _tcpServer;

        public static string MyIP()
        {
            // Получение имени компьютера.
            string host = Dns.GetHostName();
            // Получение ip-адреса.
            string ipAdresses = "";
            foreach (var e in Dns.GetHostEntry(host).AddressList)
            {
                if (e.ToString().Contains(":") == false &&
                    e.ToString().StartsWith("192.") == false)
                    ipAdresses += $"Public IP: {e}\n";
                if (e.ToString().StartsWith("192."))
                    ipAdresses += $"Local IP:  {e}\n";
            }
            return ipAdresses;
        }

        public async static void Create(string host)
        {
            if (host.Contains(":") == false)
                return;

            var hostArray = host.Split(':');
            var ip = hostArray[0];
            var port = int.Parse(hostArray[1]);

            var localAddress = IPAddress.Parse("127.0.0.1");
            var localEndPoint = new IPEndPoint(localAddress, port);
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

        public static void CloseConnection()
        {
            Console.WriteLine("Connection stopped");
            _tcpServer.Stop();
        }
    }
}
