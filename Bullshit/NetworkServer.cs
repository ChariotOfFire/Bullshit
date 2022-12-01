using System;
using System.Text;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;

namespace Bullshit
{
    public class NetworkServer : TCPSendReseive
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
            var port = int.Parse(hostArray[1]);

            var localAddress = IPAddress.Parse("127.0.0.1");
            var localEndPoint = new IPEndPoint(localAddress, port);
            _tcpServer = new TcpListener(localEndPoint);
            Console.WriteLine(_tcpServer.LocalEndpoint);
            _tcpServer.Start();
            Console.WriteLine("Сервер запущен. Ожидание подключений... ");
            _tcpClient = await _tcpServer.AcceptTcpClientAsync();
        }

        public static string GetRemoteUsername()
        {
            return "";
        }
    }
}
