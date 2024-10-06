using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace TCPserver
{
    public class ServerJson
    {
        public void Start()
        {
            TcpListener server = new TcpListener(IPAddress.Any, 2024);
            server.Start();

            Console.WriteLine("Server is running..");

            TcpClient socket = server.AcceptTcpClient();

            Task.Run(() =>
            {
                TcpClient temp = socket;
                DoClientWJson(temp);
            });
        }

        public void DoClientWJson(TcpClient client)
        {
            StreamReader sr = new StreamReader(client.GetStream());
            StreamWriter sw = new StreamWriter(client.GetStream());
            Console.WriteLine($"Server is connected with Client {client.Client.RemoteEndPoint}");

            while (true)
            {
                string input = sr.ReadLine();
                var c = JsonSerializer.Deserialize<Metoder>(input);
                int result;

                switch (c.metode.ToLower())
                {
                    case "random":
                        Random random = new Random();
                        result = random.Next(c.tal1, c.tal2 + 1);
                        sw.WriteLine(JsonSerializer.Serialize(result));
                        sw.Flush();
                        break;
                    case "add":
                        result = c.tal1 + c.tal2;
                        sw.WriteLine(JsonSerializer.Serialize(result));
                        sw.Flush();
                        break;
                    case "sub":
                        result = c.tal1 - c.tal2;
                        sw.WriteLine(JsonSerializer.Serialize(result));
                        sw.Flush();
                        break;
                    default:
                        sw.WriteLine("Forkert Input. Prøv igen");
                        sw.Flush();
                        break;
                }
            }
        }


    }
}
