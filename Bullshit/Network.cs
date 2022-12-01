using System.Net;

namespace Bullshit
{
    public static class Network
    {
        public static string Username { get; set; }
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
    }
}
