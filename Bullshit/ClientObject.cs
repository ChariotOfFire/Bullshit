using System;
using System.IO;
using System.Net.Sockets;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bullshit
{
    public class ClientObject
    {
        protected internal string Id { get; } = Guid.NewGuid().ToString();
        protected internal StreamWriter Writer { get; set; }
        protected internal StreamReader Reader { get; set; }
        public string Username { get; set; }

        TcpClient client;
        ServerObject server; // объект сервера

        public ClientObject(TcpClient tcpClient, ServerObject serverObject)
        {
            client = tcpClient;
            server = serverObject;
            // получаем NetworkStream для взаимодействия с сервером
            var stream = client.GetStream();
            // создаем StreamReader для чтения данных
            Reader = new StreamReader(stream);
            // создаем StreamWriter для отправки данных
            Writer = new StreamWriter(stream);
        }
        public ClientObject(string host, string username)
        {
            Username = username;
            Connect(host);
            Close();
        }

        public async void Connect(string host)
        {
            var array = host.Split(':');
            host = array[0];
            int port = int.Parse(array[1]);
            try
            {
                client = new TcpClient();
                client.Connect(host, port); //подключение клиента
                // получаем NetworkStream для взаимодействия с сервером
                var stream = client.GetStream();
                // создаем StreamReader для чтения данных
                Reader = new StreamReader(stream);
                // создаем StreamWriter для отправки данных
                Writer = new StreamWriter(stream);
                // запускаем новый поток для получения данных
                await Task.Run(() => ReceiveMessageAsync(Reader));
                // запускаем ввод сообщений
                await SendMessageAsync(Writer);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private async Task SendMessageAsync(StreamWriter writer)
        {
            // сначала отправляем имя
            await writer.WriteLineAsync(Username);
            await writer.FlushAsync();
            Console.WriteLine("Для отправки сообщений введите сообщение и нажмите Enter");

            while (true)
            {
                string message = Console.ReadLine();
                await writer.WriteLineAsync(message);
                await writer.FlushAsync();
            }
        }

        private async Task<string> ReceiveMessageAsync(StreamReader reader)
        {
            while (true)
            {
                try
                {
                    // считываем ответ в виде строки
                    return await reader.ReadLineAsync();
                }
                catch
                {
                    return "";
                }
            }
        }

        public async Task ProcessAsync()
        {
            try
            {
                // получаем имя пользователя
                string message = $"{Username} вошел в чат";
                // посылаем сообщение о входе в чат всем подключенным пользователям
                await server.BroadcastMessageAsync(message, Id);
                Console.WriteLine(message);
                // в бесконечном цикле получаем сообщения от клиента
                while (true)
                {
                    try
                    {
                        message = await Reader.ReadLineAsync();
                        if (message == null) continue;
                        message = $"{Username}: {message}";
                        Console.WriteLine(message);
                        await server.BroadcastMessageAsync(message, Id);
                    }
                    catch
                    {
                        message = $"{Username} покинул чат";
                        Console.WriteLine(message);
                        await server.BroadcastMessageAsync(message, Id);
                        break;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                // в случае выхода из цикла закрываем ресурсы
                server.RemoveConnection(Id);
            }
        }
        // закрытие подключения
        protected internal void Close()
        {
            Writer.Close();
            Reader.Close();
            client.Close();
        }
    }
}
