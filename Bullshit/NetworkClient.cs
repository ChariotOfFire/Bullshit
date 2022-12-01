using System;
using System.Net;
using System.Net.Sockets;

namespace Bullshit
{
    public class NetworkClient : TCPSendReseive
    {
        public static string Username { get; set; }
        private static bool _isConnected = false;

        public static async void Connect(string host)
        {
            _isConnected = true;
            if (host.Contains(":") == false)
                return;
            _tcpClient = new TcpClient();
            var hostArray = host.Split(':');
            var ip = hostArray[0];
            var port = int.Parse(hostArray[1]);
            Console.WriteLine("Клиент запущен");
            try
            {
                await _tcpClient.ConnectAsync(ip, port);
            }
            catch (SocketException)
            {
                Console.WriteLine($"Сервера {host} не существует");
            }

            if (_tcpClient.Connected)
                Console.WriteLine($"Подключение с {_tcpClient.Client.RemoteEndPoint} установлено");
            else
                Console.WriteLine("Не удалось подключиться");
        }

        public static void Disconnect()
        {
            if (_isConnected)
            {
                _tcpClient.Close();
                _isConnected = false;
            }
        }
    }
}
