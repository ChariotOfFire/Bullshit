using System;
using System.Text;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;

namespace Bullshit
{
    public class TCPSendReseive
    {
        protected static TcpClient _tcpClient;

        public static string GetData()
        {
            var response = new List<byte>();
            var stream = _tcpClient.GetStream();
            int bytesRead;
            while ((bytesRead = stream.ReadByte()) != '\n')
            {
                response.Add((byte)bytesRead);
            }
            return Encoding.UTF8.GetString(response.ToArray());
        }

        public async static void SendData(string data)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(data);
            var stream = _tcpClient.GetStream();
            await stream.WriteAsync(bytes, 0, bytes.Length);
        }
    }
}
