using System;
using System.Net.Sockets;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bullshit
{
    public static class NetworkConnection
    {
        public static void Connect()
        {
            var port = 80;
            var url = "www.google.com";

            using (var socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp))
            {
                try
                {
                    // пытаемся подключиться используя URL-адрес и порт
                    socket.Connect(url, port);
                    Console.WriteLine($"Подключение к {url} установлено");
                    Console.WriteLine($"Адрес подключения {socket.RemoteEndPoint}");
                    Console.WriteLine($"Адрес приложения {socket.LocalEndPoint}");
                }
                catch (SocketException)
                {
                    Console.WriteLine($"Не удалось установить подключение к {url}");
                }
            }
        }
    }
}
